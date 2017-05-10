namespace WinForms
{
    partial class FiguresForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiguresForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchType = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.dataGridViewFigures = new System.Windows.Forms.DataGridView();
            this.FigureType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStartY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxSideC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSideB = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSideA = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRadius = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxX = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxY = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFigures)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSearchType);
            this.groupBox1.Controls.Add(this.buttonModify);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.buttonRemove);
            this.groupBox1.Controls.Add(this.dataGridViewFigures);
            this.groupBox1.Location = new System.Drawing.Point(9, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object List";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(248, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search figure type:";
            // 
            // textBoxSearchType
            // 
            this.textBoxSearchType.Location = new System.Drawing.Point(350, 156);
            this.textBoxSearchType.Name = "textBoxSearchType";
            this.textBoxSearchType.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchType.TabIndex = 5;
            this.textBoxSearchType.TextChanged += new System.EventHandler(this.textBoxSearchType_TextChanged);
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModify.Location = new System.Drawing.Point(134, 154);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(58, 23);
            this.buttonModify.TabIndex = 4;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(6, 154);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(58, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.Location = new System.Drawing.Point(70, 154);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(58, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove ";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // dataGridViewFigures
            // 
            this.dataGridViewFigures.AllowUserToAddRows = false;
            this.dataGridViewFigures.AllowUserToDeleteRows = false;
            this.dataGridViewFigures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFigures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FigureType,
            this.ColumnStartX,
            this.ColumnStartY,
            this.ColumnSquare});
            this.dataGridViewFigures.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewFigures.Name = "dataGridViewFigures";
            this.dataGridViewFigures.ReadOnly = true;
            this.dataGridViewFigures.Size = new System.Drawing.Size(446, 134);
            this.dataGridViewFigures.TabIndex = 0;
            // 
            // FigureType
            // 
            this.FigureType.HeaderText = "Figure type";
            this.FigureType.Name = "FigureType";
            this.FigureType.ReadOnly = true;
            // 
            // ColumnStartX
            // 
            this.ColumnStartX.HeaderText = "Start X";
            this.ColumnStartX.Name = "ColumnStartX";
            this.ColumnStartX.ReadOnly = true;
            // 
            // ColumnStartY
            // 
            this.ColumnStartY.HeaderText = "Start Y";
            this.ColumnStartY.Name = "ColumnStartY";
            this.ColumnStartY.ReadOnly = true;
            // 
            // ColumnSquare
            // 
            this.ColumnSquare.HeaderText = "Square";
            this.ColumnSquare.Name = "ColumnSquare";
            this.ColumnSquare.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(61, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripFile
            // 
            this.toolStripFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(49, 22);
            this.toolStripFile.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Title = "Сохранить список";
            // 
            // openFile
            // 
            this.openFile.FileName = "Открыть список";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.maskedTextBoxSideC);
            this.groupBox2.Controls.Add(this.maskedTextBoxSideB);
            this.groupBox2.Controls.Add(this.maskedTextBoxSideA);
            this.groupBox2.Controls.Add(this.maskedTextBoxRadius);
            this.groupBox2.Controls.Add(this.maskedTextBoxLength);
            this.groupBox2.Controls.Add(this.maskedTextBoxWidth);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(482, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 101);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Square Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Width";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Length";
            // 
            // maskedTextBoxSideC
            // 
            this.maskedTextBoxSideC.Location = new System.Drawing.Point(216, 68);
            this.maskedTextBoxSideC.Mask = "09.099";
            this.maskedTextBoxSideC.Name = "maskedTextBoxSideC";
            this.maskedTextBoxSideC.ReadOnly = true;
            this.maskedTextBoxSideC.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideC.TabIndex = 9;
            // 
            // maskedTextBoxSideB
            // 
            this.maskedTextBoxSideB.Location = new System.Drawing.Point(216, 42);
            this.maskedTextBoxSideB.Mask = "09.099";
            this.maskedTextBoxSideB.Name = "maskedTextBoxSideB";
            this.maskedTextBoxSideB.ReadOnly = true;
            this.maskedTextBoxSideB.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideB.TabIndex = 8;
            // 
            // maskedTextBoxSideA
            // 
            this.maskedTextBoxSideA.Location = new System.Drawing.Point(216, 17);
            this.maskedTextBoxSideA.Mask = "09.099";
            this.maskedTextBoxSideA.Name = "maskedTextBoxSideA";
            this.maskedTextBoxSideA.ReadOnly = true;
            this.maskedTextBoxSideA.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideA.TabIndex = 7;
            // 
            // maskedTextBoxRadius
            // 
            this.maskedTextBoxRadius.Location = new System.Drawing.Point(50, 69);
            this.maskedTextBoxRadius.Mask = "09.099";
            this.maskedTextBoxRadius.Name = "maskedTextBoxRadius";
            this.maskedTextBoxRadius.ReadOnly = true;
            this.maskedTextBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRadius.TabIndex = 6;
            // 
            // maskedTextBoxLength
            // 
            this.maskedTextBoxLength.Location = new System.Drawing.Point(50, 43);
            this.maskedTextBoxLength.Mask = "09.099";
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.ReadOnly = true;
            this.maskedTextBoxLength.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxLength.TabIndex = 5;
            // 
            // maskedTextBoxWidth
            // 
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(50, 18);
            this.maskedTextBoxWidth.Mask = "09.099";
            this.maskedTextBoxWidth.MaximumSize = new System.Drawing.Size(500, 500);
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.ReadOnly = true;
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxWidth.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Side C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Side B";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Side A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Radius";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.maskedTextBoxX);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.maskedTextBoxY);
            this.groupBox3.Location = new System.Drawing.Point(482, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 76);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start coordinate";
            // 
            // maskedTextBoxX
            // 
            this.maskedTextBoxX.Location = new System.Drawing.Point(50, 19);
            this.maskedTextBoxX.Mask = "#09.099";
            this.maskedTextBoxX.Name = "maskedTextBoxX";
            this.maskedTextBoxX.ReadOnly = true;
            this.maskedTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxX.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "StartY";
            // 
            // maskedTextBoxY
            // 
            this.maskedTextBoxY.Location = new System.Drawing.Point(50, 45);
            this.maskedTextBoxY.Mask = "#09.099";
            this.maskedTextBoxY.Name = "maskedTextBoxY";
            this.maskedTextBoxY.ReadOnly = true;
            this.maskedTextBoxY.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxY.TabIndex = 6;
            // 
            // FiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(825, 216);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FiguresForm";
            this.Text = "FiguresForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFigures)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewFigures;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.DataGridViewTextBoxColumn FigureType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStartY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSquare;
        private System.Windows.Forms.TextBox textBoxSearchType;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideB;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideA;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRadius;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxY;
    }
}

