namespace WinForms
{
    partial class ObjectControlBasic
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxCoordinates = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxY = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxX = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFigure = new System.Windows.Forms.ComboBox();
            this.groupBoxSquareData = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxSideC = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSideB = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSideA = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRadius = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxLength = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxWidth = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSquare = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.groupBoxCoordinates.SuspendLayout();
            this.groupBoxSquareData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCoordinates
            // 
            this.groupBoxCoordinates.Controls.Add(this.label2);
            this.groupBoxCoordinates.Controls.Add(this.label1);
            this.groupBoxCoordinates.Controls.Add(this.maskedTextBoxY);
            this.groupBoxCoordinates.Controls.Add(this.maskedTextBoxX);
            this.groupBoxCoordinates.Location = new System.Drawing.Point(15, 3);
            this.groupBoxCoordinates.Name = "groupBoxCoordinates";
            this.groupBoxCoordinates.Size = new System.Drawing.Size(161, 79);
            this.groupBoxCoordinates.TabIndex = 0;
            this.groupBoxCoordinates.TabStop = false;
            this.groupBoxCoordinates.Text = "Coordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start X";
            // 
            // maskedTextBoxY
            // 
            this.maskedTextBoxY.Location = new System.Drawing.Point(43, 47);
            this.maskedTextBoxY.Mask = "#00.000";
            this.maskedTextBoxY.Name = "maskedTextBoxY";
            this.maskedTextBoxY.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxY.TabIndex = 1;
            // 
            // maskedTextBoxX
            // 
            this.maskedTextBoxX.Location = new System.Drawing.Point(43, 21);
            this.maskedTextBoxX.Mask = "#00.000";
            this.maskedTextBoxX.Name = "maskedTextBoxX";
            this.maskedTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxX.TabIndex = 0;
            // 
            // comboBoxFigure
            // 
            this.comboBoxFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigure.FormattingEnabled = true;
            this.comboBoxFigure.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Triangle"});
            this.comboBoxFigure.Location = new System.Drawing.Point(194, 22);
            this.comboBoxFigure.Name = "comboBoxFigure";
            this.comboBoxFigure.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigure.TabIndex = 1;
            this.comboBoxFigure.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigure_SelectedIndexChanged);
            // 
            // groupBoxSquareData
            // 
            this.groupBoxSquareData.Controls.Add(this.label8);
            this.groupBoxSquareData.Controls.Add(this.label7);
            this.groupBoxSquareData.Controls.Add(this.label6);
            this.groupBoxSquareData.Controls.Add(this.label5);
            this.groupBoxSquareData.Controls.Add(this.label4);
            this.groupBoxSquareData.Controls.Add(this.label3);
            this.groupBoxSquareData.Controls.Add(this.maskedTextBoxSideC);
            this.groupBoxSquareData.Controls.Add(this.maskedTextBoxSideB);
            this.groupBoxSquareData.Controls.Add(this.maskedTextBoxSideA);
            this.groupBoxSquareData.Controls.Add(this.maskedTextBoxRadius);
            this.groupBoxSquareData.Controls.Add(this.maskedTextBoxLength);
            this.groupBoxSquareData.Controls.Add(this.maskedTextBoxWidth);
            this.groupBoxSquareData.Location = new System.Drawing.Point(15, 88);
            this.groupBoxSquareData.Name = "groupBoxSquareData";
            this.groupBoxSquareData.Size = new System.Drawing.Size(300, 102);
            this.groupBoxSquareData.TabIndex = 2;
            this.groupBoxSquareData.TabStop = false;
            this.groupBoxSquareData.Text = "Square Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Side C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Side B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Side A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // maskedTextBoxSideC
            // 
            this.maskedTextBoxSideC.Location = new System.Drawing.Point(191, 73);
            this.maskedTextBoxSideC.Mask = "00.000";
            this.maskedTextBoxSideC.Name = "maskedTextBoxSideC";
            this.maskedTextBoxSideC.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideC.TabIndex = 5;
            // 
            // maskedTextBoxSideB
            // 
            this.maskedTextBoxSideB.Location = new System.Drawing.Point(191, 46);
            this.maskedTextBoxSideB.Mask = "00.000";
            this.maskedTextBoxSideB.Name = "maskedTextBoxSideB";
            this.maskedTextBoxSideB.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideB.TabIndex = 4;
            // 
            // maskedTextBoxSideA
            // 
            this.maskedTextBoxSideA.Location = new System.Drawing.Point(191, 19);
            this.maskedTextBoxSideA.Mask = "00.000";
            this.maskedTextBoxSideA.Name = "maskedTextBoxSideA";
            this.maskedTextBoxSideA.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxSideA.TabIndex = 3;
            // 
            // maskedTextBoxRadius
            // 
            this.maskedTextBoxRadius.Location = new System.Drawing.Point(43, 73);
            this.maskedTextBoxRadius.Mask = "00.000";
            this.maskedTextBoxRadius.Name = "maskedTextBoxRadius";
            this.maskedTextBoxRadius.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxRadius.TabIndex = 2;
            // 
            // maskedTextBoxLength
            // 
            this.maskedTextBoxLength.Location = new System.Drawing.Point(43, 46);
            this.maskedTextBoxLength.Mask = "00.000";
            this.maskedTextBoxLength.Name = "maskedTextBoxLength";
            this.maskedTextBoxLength.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxLength.TabIndex = 1;
            // 
            // maskedTextBoxWidth
            // 
            this.maskedTextBoxWidth.Location = new System.Drawing.Point(43, 19);
            this.maskedTextBoxWidth.Mask = "00.000";
            this.maskedTextBoxWidth.Name = "maskedTextBoxWidth";
            this.maskedTextBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxWidth.TabIndex = 0;
            // 
            // textBoxSquare
            // 
            this.textBoxSquare.Location = new System.Drawing.Point(206, 197);
            this.textBoxSquare.Name = "textBoxSquare";
            this.textBoxSquare.ReadOnly = true;
            this.textBoxSquare.Size = new System.Drawing.Size(100, 20);
            this.textBoxSquare.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Square";
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(15, 194);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(78, 23);
            this.buttonSquare.TabIndex = 5;
            this.buttonSquare.Text = "Count square";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // ObjectControlBasic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxSquare);
            this.Controls.Add(this.groupBoxSquareData);
            this.Controls.Add(this.comboBoxFigure);
            this.Controls.Add(this.groupBoxCoordinates);
            this.Name = "ObjectControlBasic";
            this.Size = new System.Drawing.Size(344, 247);
            this.groupBoxCoordinates.ResumeLayout(false);
            this.groupBoxCoordinates.PerformLayout();
            this.groupBoxSquareData.ResumeLayout(false);
            this.groupBoxSquareData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCoordinates;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxY;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxX;
        private System.Windows.Forms.ComboBox comboBoxFigure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxSquareData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideC;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideB;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSideA;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRadius;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxLength;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWidth;
        private System.Windows.Forms.TextBox textBoxSquare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSquare;
    }
}
