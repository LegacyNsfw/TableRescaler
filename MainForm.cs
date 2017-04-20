using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSFW.TableRescaler
{
    public partial class MainForm : Form
    {
        private bool autoRescale = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            this.autoRescale = false;

            try
            {
                string tableText = Clipboard.GetData(System.Windows.Forms.DataFormats.Text) as string;
                if (string.IsNullOrEmpty(tableText))
                {
                    throw new ApplicationException("Doesn't contain text.");
                }

                Table temporaryTable = new Table();
                Util.LoadTable(tableText, temporaryTable);

                Util.PopulateTable(this, temporaryTable, this.sourceDataGridView);
                
                this.originalColumns.Text = temporaryTable.ColumnHeaders.Count.ToString();
                this.originalRows.Text = temporaryTable.RowHeaders.Count.ToString();

                this.rescaledColumns.Text = temporaryTable.ColumnHeaders.Count.ToString();
                this.rescaledRows.Text = temporaryTable.RowHeaders.Count.ToString();

                this.minColumn.Text = temporaryTable.ColumnHeaders[0].ToString();
                this.maxColumn.Text = temporaryTable.ColumnHeaders[temporaryTable.ColumnHeaders.Count - 1].ToString();

                this.minRow.Text = temporaryTable.RowHeaders[0].ToString();
                this.maxRow.Text = temporaryTable.RowHeaders[temporaryTable.RowHeaders.Count - 1].ToString();

                this.Rescale();
                
                Util.FormatTable(this, this.sourceDataGridView);
                Util.FormatTable(this, this.rescaledDataGridView);
            }
            catch (ApplicationException ex)
            {
                string errorMessageFormat = "Clipboard does not contain valid table data.\r\n{0}";
                MessageBox.Show(string.Format(errorMessageFormat, ex.Message));
            }
            finally
            {
                this.autoRescale = true;
            }
        }

        private void Rescale()
        {
            uint rows;
            if (!uint.TryParse(this.rescaledRows.Text, out rows))
            {
                return;
            }

            uint columns;
            if (!uint.TryParse(this.rescaledColumns.Text, out columns))
            {
                return;
            }

            RescaleInitialize((int) rows, (int) columns);
            RescalePopulate((int) rows, (int) columns);
        }

        private void RescaleInitialize(int rows, int columns)
        {
            this.rescaledDataGridView.Rows.Clear();
            this.rescaledDataGridView.Columns.Clear();
            DataGridViewCell template = new DataGridViewTextBoxCell();

            for (int columnIndex = 0; columnIndex < columns; columnIndex++)
            {
                DataGridViewColumn column = new DataGridViewColumn(template);
                column.HeaderCell.Value = GetRescaledColumnHeader(columnIndex, columns);
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                column.Width = Util.ColumnWidth;
                column.HeaderText = GetRescaledColumnHeader(columnIndex, columns).ToString(Util.DoubleFormat);
                column.HeaderCell.Style = Util.DefaultStyle;

                this.rescaledDataGridView.Columns.Add(column);
            }

            this.rescaledDataGridView.Rows.Clear();
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = GetRescaledRowHeader(rowIndex, rows).ToString();
                row.HeaderCell.Style = Util.DefaultStyle;
                this.rescaledDataGridView.Rows.Add(row);
            }

        }

        private void RescalePopulate(int rows, int columns)
        {
            for (int columnIndex = 0; columnIndex < columns; columnIndex++)
            {
                for (int rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    this.PopulateCell(columnIndex, rowIndex);
                }
            }
        }

        private void PopulateCell(int column, int row)
        {
            double x = double.Parse(this.rescaledDataGridView.Columns[column].HeaderText);
            double y = double.Parse((string)this.rescaledDataGridView.Rows[row].HeaderCell.Value);

            double value = GetValueFromOriginalTable(x, y);
            this.rescaledDataGridView.Rows[row].Cells[column].Value = value.ToString(Util.DoubleFormat);
        }

        private double GetValueFromOriginalTable(double x, double y)
        {
            int maxRow = this.sourceDataGridView.Rows.Count - 1;
            int maxColumn = this.sourceDataGridView.Columns.Count - 1;
            double minX = this.GetColumnHeader(0);
            double maxX = this.GetColumnHeader(maxColumn);
            double minY = this.GetRowHeader(0);
            double maxY = this.GetRowHeader(maxRow);

            int lowColumn;
            int highColumn;

            if (x <= minX)
            {
                lowColumn = 0;
                highColumn = 0;
            }
            else if (x > maxX)
            {
                lowColumn = maxColumn;
                highColumn = maxColumn;
            }
            else
            {
                lowColumn = 0;
                highColumn = 1;

                for (int i = 0; (i < this.sourceDataGridView.Columns.Count); i++)
                {
                    double columnValue = GetColumnHeader(i);
                    if ((x > columnValue) && (highColumn < maxColumn))
                    {
                        lowColumn++;
                        highColumn++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int lowRow;
            int highRow;

            if (y <= minY)
            {
                lowRow = 0;
                highRow = 0;
            }
            else if (y > maxY)
            {
                lowRow = maxRow;
                highRow = maxRow;
            }
            else
            {
                lowRow = 0;
                highRow = 1;

                for (int j = 0; (j < this.sourceDataGridView.Rows.Count); j++)
                {
                    double rowValue = GetRowHeader(j);
                    if ((y > rowValue) && (highRow < maxRow))
                    {
                        lowRow++;
                        highRow++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            double columnWeight = (highColumn == lowColumn) ? 0 :
                (x - GetColumnHeader(lowColumn)) / (GetColumnHeader(highColumn) - GetColumnHeader(lowColumn));

            double rowWeight = (highRow == lowRow) ? 0 :
                (y - GetRowHeader(lowRow)) / (GetRowHeader(highRow) - GetRowHeader(lowRow));

            double r1 = GetCellValue(lowRow, lowColumn);
            double r2 = ((GetCellValue(highRow, lowColumn) - r1) * rowWeight);
            double r3 = ((GetCellValue(lowRow, highColumn) - r1) * columnWeight);
            return r1 + r2 + r3;
        }

        private double GetRowHeader(int row)
        {
            string value = (string)this.sourceDataGridView.Rows[row].HeaderCell.Value;
            return double.Parse(value);
        }

        private double GetColumnHeader(int column)
        {
            string value = (string)this.sourceDataGridView.Columns[column].HeaderCell.Value;
            return double.Parse(value);
        }

        private double GetCellValue(int row, int column)
        {
            string value = (string)this.sourceDataGridView.Rows[row].Cells[column].Value;
            return double.Parse(value);
        }

        private double GetRescaledColumnHeader(int column, int columns)
        {
            double min;
            if (!double.TryParse(this.minColumn.Text, out min))
            {
                // TODO: Error
                return 0;
            }

            double max;
            if (!double.TryParse(this.maxColumn.Text, out max))
            {
                // TODO: Error
                return 0;
            }

            if (max <= min)
            {
                // TODO: Error
                return 0;
            }

            double difference = max - min;
            double portion = (double)column / (double)(columns - 1);
            return (portion * difference) + min;
        }

        private double GetRescaledRowHeader(int row, int rows)
        {
            double min;
            if (!double.TryParse(this.minRow.Text, out min))
            {
                // TODO: Error
                return 0;
            }

            double max;
            if (!double.TryParse(this.maxRow.Text, out max))
            {
                // TODO: Error
                return 0;
            }

            if (max <= min)
            {
                // TODO: Error
                return 0;
            }

            double difference = max - min;
            double portion = (double)row / (double)(rows - 1);
            return (portion * difference) + min;
        }

        private void RescaleAndReformat()
        {
            if (this.autoRescale)
            {
                try
                {
                    this.Rescale();
                    Util.FormatTable(this, this.rescaledDataGridView);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString(), "Rescaling error.");
                }
            }
        }

        private void rescaledColumns_TextChanged(object sender, EventArgs e)
        {
            this.RescaleAndReformat();
        }

        private void rescaledRows_TextChanged(object sender, EventArgs e)
        {
            this.RescaleAndReformat();
        }

        private void minColumn_TextChanged(object sender, EventArgs e)
        {
            this.RescaleAndReformat();
        }

        private void minRow_TextChanged(object sender, EventArgs e)
        {
            this.RescaleAndReformat();
        }

        private void maxColumn_TextChanged(object sender, EventArgs e)
        {
            this.RescaleAndReformat();
        }

        private void maxRow_TextChanged(object sender, EventArgs e)
        {
            this.RescaleAndReformat();
        }

        private void rescaledDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // This is just a convenient place to put a breakpoint.
            // It has no other purpose.
            this.ToString();
        }
    }
}
