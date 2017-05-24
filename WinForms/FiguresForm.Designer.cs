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
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.objectControlMainForm = new WinForms.ObjectControlBasic();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFigures)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(458, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object List";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(249, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search figure type:";
            // 
            // textBoxSearchType
            // 
            this.textBoxSearchType.Location = new System.Drawing.Point(351, 177);
            this.textBoxSearchType.Name = "textBoxSearchType";
            this.textBoxSearchType.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchType.TabIndex = 5;
            this.textBoxSearchType.TextChanged += new System.EventHandler(this.textBoxSearchType_TextChanged);
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModify.Location = new System.Drawing.Point(134, 175);
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
            this.buttonAdd.Location = new System.Drawing.Point(6, 175);
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
            this.buttonRemove.Location = new System.Drawing.Point(70, 175);
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
            this.dataGridViewFigures.Size = new System.Drawing.Size(446, 149);
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
            this.openingToolStripMenuItem,
            this.savingToolStripMenuItem});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(49, 22);
            this.toolStripFile.Text = "Файл";
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openingToolStripMenuItem.Text = "Открыть";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // savingToolStripMenuItem
            // 
            this.savingToolStripMenuItem.Name = "savingToolStripMenuItem";
            this.savingToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.savingToolStripMenuItem.Text = "Сохранить";
            this.savingToolStripMenuItem.Click += new System.EventHandler(this.savingToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Title = "Сохранить список";
            // 
            // openFile
            // 
            this.openFile.FileName = "Открыть список";
            // 
            // objectControlMainForm
            // 
            this.objectControlMainForm.Figure = null;
            this.objectControlMainForm.Location = new System.Drawing.Point(467, 3);
            this.objectControlMainForm.Name = "objectControlMainForm";
            this.objectControlMainForm.ReadOnly = false;
            this.objectControlMainForm.Size = new System.Drawing.Size(344, 247);
            this.objectControlMainForm.TabIndex = 0;
            // 
            // FiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(821, 262);
            this.Controls.Add(this.objectControlMainForm);
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
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private ObjectControlBasic objectControlMainForm;
    }
}

