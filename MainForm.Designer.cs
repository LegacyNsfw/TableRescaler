namespace NSFW.TableRescaler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceDataGridView = new System.Windows.Forms.DataGridView();
            this.rescaledDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.originalColumns = new System.Windows.Forms.TextBox();
            this.originalRows = new System.Windows.Forms.TextBox();
            this.rescaledRows = new System.Windows.Forms.TextBox();
            this.rescaledColumns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pasteButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.minColumn = new System.Windows.Forms.TextBox();
            this.minRow = new System.Windows.Forms.TextBox();
            this.maxColumn = new System.Windows.Forms.TextBox();
            this.maxRow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rescaledDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceDataGridView
            // 
            this.sourceDataGridView.AllowUserToAddRows = false;
            this.sourceDataGridView.AllowUserToDeleteRows = false;
            this.sourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.sourceDataGridView, 3);
            this.sourceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceDataGridView.Location = new System.Drawing.Point(3, 108);
            this.sourceDataGridView.Name = "sourceDataGridView";
            this.sourceDataGridView.RowTemplate.Height = 24;
            this.sourceDataGridView.Size = new System.Drawing.Size(731, 414);
            this.sourceDataGridView.TabIndex = 5;
            // 
            // rescaledDataGridView
            // 
            this.rescaledDataGridView.AllowUserToAddRows = false;
            this.rescaledDataGridView.AllowUserToDeleteRows = false;
            this.rescaledDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.rescaledDataGridView, 6);
            this.rescaledDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rescaledDataGridView.Location = new System.Drawing.Point(740, 108);
            this.rescaledDataGridView.Name = "rescaledDataGridView";
            this.rescaledDataGridView.RowTemplate.Height = 24;
            this.rescaledDataGridView.Size = new System.Drawing.Size(733, 414);
            this.rescaledDataGridView.TabIndex = 15;
            this.rescaledDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rescaledDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Table";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rescaled Table";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columns";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rows";
            // 
            // originalColumns
            // 
            this.originalColumns.Location = new System.Drawing.Point(224, 73);
            this.originalColumns.Name = "originalColumns";
            this.originalColumns.ReadOnly = true;
            this.originalColumns.Size = new System.Drawing.Size(91, 22);
            this.originalColumns.TabIndex = 4;
            // 
            // originalRows
            // 
            this.originalRows.Location = new System.Drawing.Point(224, 38);
            this.originalRows.Name = "originalRows";
            this.originalRows.ReadOnly = true;
            this.originalRows.Size = new System.Drawing.Size(91, 22);
            this.originalRows.TabIndex = 3;
            // 
            // rescaledRows
            // 
            this.rescaledRows.Location = new System.Drawing.Point(862, 73);
            this.rescaledRows.Name = "rescaledRows";
            this.rescaledRows.Size = new System.Drawing.Size(91, 22);
            this.rescaledRows.TabIndex = 12;
            this.rescaledRows.TextChanged += new System.EventHandler(this.rescaledRows_TextChanged);
            // 
            // rescaledColumns
            // 
            this.rescaledColumns.Location = new System.Drawing.Point(862, 38);
            this.rescaledColumns.Name = "rescaledColumns";
            this.rescaledColumns.Size = new System.Drawing.Size(91, 22);
            this.rescaledColumns.TabIndex = 9;
            this.rescaledColumns.TextChanged += new System.EventHandler(this.rescaledColumns_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rows";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Columns";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.03006F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.03006F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.04008F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.316632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.316632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.316632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.316632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.316632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.316632F));
            this.tableLayoutPanel1.Controls.Add(this.rescaledDataGridView, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sourceDataGridView, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.rescaledColumns, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.rescaledRows, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.originalRows, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.originalColumns, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pasteButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.copyButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.minColumn, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.minRow, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.maxColumn, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.maxRow, 8, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1476, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pasteButton
            // 
            this.pasteButton.Location = new System.Drawing.Point(224, 3);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(91, 29);
            this.pasteButton.TabIndex = 1;
            this.pasteButton.Text = "&Paste";
            this.pasteButton.UseVisualStyleBackColor = true;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(862, 3);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(91, 29);
            this.copyButton.TabIndex = 7;
            this.copyButton.Text = "&Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(984, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(984, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Min";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1228, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Max";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1228, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Max";
            // 
            // minColumn
            // 
            this.minColumn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minColumn.Location = new System.Drawing.Point(1106, 41);
            this.minColumn.Name = "minColumn";
            this.minColumn.Size = new System.Drawing.Size(100, 22);
            this.minColumn.TabIndex = 10;
            this.minColumn.TextChanged += new System.EventHandler(this.minColumn_TextChanged);
            // 
            // minRow
            // 
            this.minRow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.minRow.Location = new System.Drawing.Point(1106, 76);
            this.minRow.Name = "minRow";
            this.minRow.Size = new System.Drawing.Size(100, 22);
            this.minRow.TabIndex = 13;
            this.minRow.TextChanged += new System.EventHandler(this.minRow_TextChanged);
            // 
            // maxColumn
            // 
            this.maxColumn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxColumn.Location = new System.Drawing.Point(1350, 41);
            this.maxColumn.Name = "maxColumn";
            this.maxColumn.Size = new System.Drawing.Size(100, 22);
            this.maxColumn.TabIndex = 11;
            this.maxColumn.TextChanged += new System.EventHandler(this.maxColumn_TextChanged);
            // 
            // maxRow
            // 
            this.maxRow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maxRow.Location = new System.Drawing.Point(1350, 76);
            this.maxRow.Name = "maxRow";
            this.maxRow.Size = new System.Drawing.Size(100, 22);
            this.maxRow.TabIndex = 14;
            this.maxRow.TextChanged += new System.EventHandler(this.maxRow_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Table Rescaler";
            ((System.ComponentModel.ISupportInitialize)(this.sourceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rescaledDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sourceDataGridView;
        private System.Windows.Forms.DataGridView rescaledDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox originalColumns;
        private System.Windows.Forms.TextBox originalRows;
        private System.Windows.Forms.TextBox rescaledRows;
        private System.Windows.Forms.TextBox rescaledColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox minColumn;
        private System.Windows.Forms.TextBox minRow;
        private System.Windows.Forms.TextBox maxColumn;
        private System.Windows.Forms.TextBox maxRow;
    }
}

