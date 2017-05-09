namespace WinForms
{
    partial class CreatingForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBoxX = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxY = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRandomData = new System.Windows.Forms.Button();
            this.comboBoxFigureType = new System.Windows.Forms.ComboBox();
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
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCountSquare = new System.Windows.Forms.Button();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.errorProviderX = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderY = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderRadius = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSideA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSideB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSideC = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSideA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSideB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSideC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "StartY";
            // 
            // maskedTextBoxX
            // 
            this.maskedTextBoxX.Location = new System.Drawing.Point(50, 19);
            this.maskedTextBoxX.Mask = "#09.099";
            this.maskedTextBoxX.Name = "maskedTextBoxX";
            this.maskedTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxX.TabIndex = 5;
            this.maskedTextBoxX.Leave += new System.EventHandler(this.maskedTextBoxX_Leave);
            // 
            // maskedTextBoxY
            // 
            this.maskedTextBoxY.Location = new System.Drawing.Point(50, 45);
            this.maskedTextBoxY.Mask = "#09.099";
            this.maskedTextBoxY.Name = "maskedTextBoxY";
            this.maskedTextBoxY.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxY.TabIndex = 6;
            this.maskedTextBoxY.Leave += new System.EventHandler(this.maskedTextBoxY_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.maskedTextBoxX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedTextBoxY);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start coordinate";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(177, 228);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 8;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(263, 228);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRandomData
            // 
            this.buttonRandomData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRandomData.Location = new System.Drawing.Point(11, 228);
            this.buttonRandomData.Name = "buttonRandomData";
            this.buttonRandomData.Size = new System.Drawing.Size(92, 23);
            this.buttonRandomData.TabIndex = 10;
            this.buttonRandomData.Text = "Random Data";
            this.buttonRandomData.UseVisualStyleBackColor = true;
            this.buttonRandomData.Visible = false;
            this.buttonRandomData.Click += new System.EventHandler(this.buttonRandomData_Click);
            // 
            // comboBoxFigureType
            // 
            this.comboBoxFigureType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFigureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigureType.Items.AddRange(new object[] {
            "Прямоугольник",
            "Круг",
            "Треугольник"});
            this.comboBoxFigureType.Location = new System.Drawing.Point(208, 12);
            this.comboBoxFigureType.Name = "comboBoxFigureType";
            this.comboBoxFigureType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigureType.TabIndex = 11;
            this.comboBoxFigureType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigures_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 98);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Square Data";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Width";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Length";
            // 
            // maskedTextBoxSideC
            // 
            this.maskedTextBoxSideC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSideC.Location = new System.Drawing.Point(205, 68);
            this.maskedTextBoxSideC.Mask = "09.099";
            this.maskedTextBoxSideC.Name = "maskedTextBoxSideC";
            this.maskedTextBoxSideC.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideC.TabIndex = 9;
            this.maskedTextBoxSideC.Leave += new System.EventHandler(this.maskedTextBoxSideC_Leave);
            // 
            // maskedTextBoxSideB
            // 
            this.maskedTextBoxSideB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSideB.Location = new System.Drawing.Point(205, 42);
            this.maskedTextBoxSideB.Mask = "09.099";
            this.maskedTextBoxSideB.Name = "maskedTextBoxSideB";
            this.maskedTextBoxSideB.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideB.TabIndex = 8;
            this.maskedTextBoxSideB.Leave += new System.EventHandler(this.maskedTextBoxSideB_Leave);
            // 
            // maskedTextBoxSideA
            // 
            this.maskedTextBoxSideA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBoxSideA.Location = new System.Drawing.Point(205, 17);
            this.maskedTextBoxSideA.Mask = "09.099";
            this.maskedTextBoxSideA.Name = "maskedTextBoxSideA";
            this.maskedTextBoxSideA.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideA.TabIndex = 7;
            this.maskedTextBoxSideA.Leave += new System.EventHandler(this.maskedTextBoxSideA_Leave);
            // 
            // maskedTextBoxRadius
            // 
            this.maskedTextBoxRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxRadius.Location = new System.Drawing.Point(50, 69);
            this.maskedTextBoxRadius.Mask = "09.099";
            this.maskedTextBoxRadius.Name = "maskedTextBoxRadius";
            this.maskedTextBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRadius.TabIndex = 6;
            this.maskedTextBoxRadius.Leave += new System.EventHandler(this.maskedTextBoxRadius_Leave);
            // 
            // maskedTextBoxLength
            // 
            this.maskedTextBoxLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxLength.Location = new System.Drawing.Point(50, 43);
            this.maskedTextBoxLength.Mask = "09.099";
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxLength.TabIndex = 5;
            this.maskedTextBoxLength.Leave += new System.EventHandler(this.maskedTextBoxLength_Leave);
            // 
            // maskedTextBoxWidth
            // 
            this.maskedTextBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(50, 18);
            this.maskedTextBoxWidth.Mask = "09.099";
            this.maskedTextBoxWidth.MaximumSize = new System.Drawing.Size(500, 500);
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxWidth.TabIndex = 4;
            this.maskedTextBoxWidth.Leave += new System.EventHandler(this.maskedTextBoxWidth_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Side C";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 45);
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
            this.label4.Location = new System.Drawing.Point(167, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Side A";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Radius";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(176, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Square";
            // 
            // buttonCountSquare
            // 
            this.buttonCountSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCountSquare.Location = new System.Drawing.Point(11, 199);
            this.buttonCountSquare.Name = "buttonCountSquare";
            this.buttonCountSquare.Size = new System.Drawing.Size(91, 23);
            this.buttonCountSquare.TabIndex = 15;
            this.buttonCountSquare.Text = "Count square";
            this.buttonCountSquare.UseVisualStyleBackColor = true;
            this.buttonCountSquare.Click += new System.EventHandler(this.buttonCountSquare_Click);
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSquare.Location = new System.Drawing.Point(217, 202);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.ReadOnly = true;
            this.textBoxSquare.Size = new System.Drawing.Size(100, 20);
            this.textBoxSquare.TabIndex = 16;
            // 
            // errorProviderX
            // 
            this.errorProviderX.ContainerControl = this;
            // 
            // errorProviderY
            // 
            this.errorProviderY.ContainerControl = this;
            // 
            // errorProviderWidth
            // 
            this.errorProviderWidth.ContainerControl = this;
            // 
            // errorProviderLength
            // 
            this.errorProviderLength.ContainerControl = this;
            // 
            // errorProviderRadius
            // 
            this.errorProviderRadius.ContainerControl = this;
            // 
            // errorProviderSideA
            // 
            this.errorProviderSideA.ContainerControl = this;
            // 
            // errorProviderSideB
            // 
            this.errorProviderSideB.ContainerControl = this;
            // 
            // errorProviderSideC
            // 
            this.errorProviderSideC.ContainerControl = this;
            // 
            // CreatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(350, 263);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.buttonCountSquare);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBoxFigureType);
            this.Controls.Add(this.buttonRandomData);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreatingForm";
            this.Text = "CreatingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSideA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSideB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSideC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRandomData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxX;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxY;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideB;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideA;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRadius;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        private System.Windows.Forms.Button buttonCountSquare;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.ErrorProvider errorProviderX;
        private System.Windows.Forms.ErrorProvider errorProviderY;
        private System.Windows.Forms.ErrorProvider errorProviderWidth;
        private System.Windows.Forms.ErrorProvider errorProviderLength;
        private System.Windows.Forms.ErrorProvider errorProviderRadius;
        private System.Windows.Forms.ErrorProvider errorProviderSideA;
        private System.Windows.Forms.ErrorProvider errorProviderSideB;
        private System.Windows.Forms.ErrorProvider errorProviderSideC;
        private System.Windows.Forms.ComboBox comboBoxFigureType;
    }
}