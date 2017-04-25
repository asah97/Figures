using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace WinForms
{
    
    public partial class CreatingForm : Form
    {
        private bool _maskedX = false;
        private bool _maskedY = false;
        private bool _maskedWidth = false;
        private bool _maskedLength = false;
        private bool _maskedRadius = false;
        private bool _maskedSideA = false;
        private bool _maskedSideB = false;
        private bool _maskedSideC = false;

        public CreatingForm()
        {
            InitializeComponent();

            #if DEBUG
            buttonRandomData.Visible = true;
            #endif
        }

        private void comboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFigureType.SelectedIndex)
            {
                case 0:
                    {
                        maskedTextBoxWidth.Visible = true;
                        maskedTextBoxLength.Visible = true;
                        maskedTextBoxRadius.Visible = false;
                        maskedTextBoxSideA.Visible = false;
                        maskedTextBoxSideB.Visible = false;
                        maskedTextBoxSideC.Visible = false;
                        break;
                    }
                case 1:
                    {
                        maskedTextBoxWidth.Visible = false;
                        maskedTextBoxLength.Visible = false;
                        maskedTextBoxRadius.Visible = true;
                        maskedTextBoxSideA.Visible = false;
                        maskedTextBoxSideB.Visible = false;
                        maskedTextBoxSideC.Visible = false;
                       
                        break;
                    }
                case 2:
                    {
                        maskedTextBoxWidth.Visible = false;
                        maskedTextBoxLength.Visible = false;
                        maskedTextBoxRadius.Visible = false;
                        maskedTextBoxSideA.Visible = true;
                        maskedTextBoxSideB.Visible = true;
                        maskedTextBoxSideC.Visible = true;
                        break;
                    }
            }

        }
         
        //Кнопка отмены действий      
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        //Кнопка добавления данных о фигуре в список из формы создания фигуры
        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool exitCondition = false;
            if ((maskedTextBoxX.Text != "   ,") && (maskedTextBoxY.Text != "   ,") && (maskedTextBoxWidth.Text != "  ,") && (maskedTextBoxLength.Text != "  ,") && (maskedTextBoxRadius.Text != "  ,") && (maskedTextBoxSideA.Text != "  ,") && (maskedTextBoxSideB.Text != "  ,") && (maskedTextBoxSideC.Text != "  ,"))
            {
                 exitCondition = true;
            }
            if (!(_maskedX && _maskedY) && !(exitCondition))
            {
                MessageBox.Show("Одна из начальных координат или обе координаты не были введены!");
            }
            else if (comboBoxFigureType.SelectedIndex == -1)
            {
                MessageBox.Show("Не была выбрана геометрическая фигура");
            }
            else if ((comboBoxFigureType.SelectedIndex == 0) && !(exitCondition))
            {
                if (!(_maskedLength && _maskedWidth))
                    MessageBox.Show("Длина или ширина прямоугольника не были введены!");
                else
                    exitCondition = true;
            }
            else if ((comboBoxFigureType.SelectedIndex == 1) && !(exitCondition))
            {
                if (!(_maskedRadius))
                    MessageBox.Show("Введите значение радиуса круга!");
                else
                    exitCondition = true;
            }
            else if ((comboBoxFigureType.SelectedIndex == 2) && !(exitCondition))
            {
                if (!(_maskedSideA && _maskedSideB && _maskedSideC))
                    MessageBox.Show("Одна или несколько сторон не были введены!");
                else
                    exitCondition = true;
            }

            if (exitCondition)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private IFigure _figure;

        //Описание данных о фигуре
        public IFigure Figure
        {
            get
            {
                if (comboBoxFigureType.SelectedIndex == 0)
                {
                    var Rect = new Figures.Rectangle();

                    Rect.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    Rect.StartY = Convert.ToDouble(maskedTextBoxY.Text);

                    Rect.Width = Convert.ToDouble(maskedTextBoxWidth.Text);
                    Rect.Length = Convert.ToDouble(maskedTextBoxLength.Text);
                    _figure = Rect;
                }
                else if (comboBoxFigureType.SelectedIndex == 1)
                {
                    var Round = new Figures.Circle();

                    Round.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    Round.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    Round.Radius = Convert.ToDouble(maskedTextBoxRadius.Text);
                    _figure = Round;
                }
                else if (comboBoxFigureType.SelectedIndex == 2)
                {
                    var Trigon = new Figures.Triangle();

                    Trigon.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    Trigon.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    Trigon.SetSides(Convert.ToDouble(maskedTextBoxSideA.Text), Convert.ToDouble(maskedTextBoxSideB.Text), Convert.ToDouble(maskedTextBoxSideC.Text));
                    _figure = Trigon;
                }
                return _figure;
            }
            
            set
            {
                _figure = value;
                maskedTextBoxX.Text = Convert.ToString(value.StartX);
                maskedTextBoxY.Text = Convert.ToString(value.StartY);
                if (value is Figures.Rectangle)
                {
                    var Rect = (Figures.Rectangle) value;
                    comboBoxFigureType.SelectedIndex = 0;
                                       
                    maskedTextBoxWidth.Text = Convert.ToString(Rect.Width);
                    maskedTextBoxLength.Text = Convert.ToString(Rect.Length);
                }
                else if (value is Figures.Circle)
                {
                    var Round = (Figures.Circle)value;
                    comboBoxFigureType.SelectedIndex = 1;
                                        
                    maskedTextBoxRadius.Text = Convert.ToString(Round.Radius);
                }
                else if (value is Figures.Triangle)
                {
                    var Trigon = (Figures.Triangle)value;
                    comboBoxFigureType.SelectedIndex = 2;
                                        
                    maskedTextBoxSideA.Text = Convert.ToString(Trigon.SideA);
                    maskedTextBoxSideB.Text = Convert.ToString(Trigon.SideB);
                    maskedTextBoxSideC.Text = Convert.ToString(Trigon.SideC);
                }
            }
        }

        //Кнопка подсчета площади фигуры
        private void buttonCountSquare_Click(object sender, EventArgs e)
        {
            if ((_maskedWidth && _maskedLength) || (_maskedRadius) || (_maskedSideA && _maskedSideB & _maskedSideC))
                textBoxSquare.Text = Convert.ToString(Figure.GetArea());
            else
                MessageBox.Show("Не все величины были введены");
            
        }
                
        private void maskedTextBoxX_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxX.Text == "   ,")
            {
                errorProviderX.SetError(maskedTextBoxX, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderX.Clear();
                _maskedX = true;
            }
        }

        private void maskedTextBoxY_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxY.Text == "   ,")
            {
                errorProviderY.SetError(maskedTextBoxY, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderY.Clear();
                _maskedY = true;
            }
        }
              
        private void maskedTextBoxLength_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxLength.Text == "  ,")
            {
                errorProviderLength.SetError(maskedTextBoxLength, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderLength.Clear();
                _maskedLength = true;
            }
        }

        private void maskedTextBoxWidth_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxWidth.Text == "  ,")
            {
                errorProviderWidth.SetError(maskedTextBoxWidth, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderWidth.Clear();
                _maskedWidth = true;
            }
        }

        private void maskedTextBoxRadius_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxRadius.Text == "  ,")
            {
                errorProviderRadius.SetError(maskedTextBoxRadius, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderRadius.Clear();
                _maskedRadius = true;
            }
        }

        private void maskedTextBoxSideA_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxSideA.Text == "  ,")
            {
                errorProviderSideA.SetError(maskedTextBoxSideA, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderSideA.Clear();
                _maskedSideA = true;
            }
        }

        private void maskedTextBoxSideB_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxSideB.Text == "  ,")
            {
                errorProviderSideB.SetError(maskedTextBoxSideB, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderSideB.Clear();
                _maskedSideB = true;
            }
        }

        private void maskedTextBoxSideC_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxSideC.Text == "  ,")
            {
                errorProviderSideC.SetError(maskedTextBoxSideC, "Данное поле должно быть заполненным");
            }
            else
            {
                errorProviderSideC.Clear();
                _maskedSideC = true;
            }
        }

        //Кнопка, добавляющая случайные данные о фигуре
        private void buttonRandomData_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int figureName = random.Next(3);

            switch (figureName)
            {
                case 0:
                    {
                        comboBoxFigureType.SelectedIndex = 0;
                        break;
                    }
                case 1:
                    {
                        comboBoxFigureType.SelectedIndex = 1;
                        break;
                    }
                case 2:
                    {
                        comboBoxFigureType.SelectedIndex = 2;
                        break;
                    }
            }
            maskedTextBoxX.Text = Convert.ToString(1.111 + random.NextDouble() * (999.999 - 1.111));
            maskedTextBoxY.Text = Convert.ToString(1.111 + random.NextDouble() * (999.999 - 1.111));
            _maskedX = true;
            _maskedY = true;

            if (comboBoxFigureType.SelectedIndex == 0)
            {
                maskedTextBoxWidth.Text = Convert.ToString(1.111 + random.NextDouble() * (99.999 - 1.111));
                maskedTextBoxLength.Text = Convert.ToString(1.111 + random.NextDouble() * (99.999 - 1.111));
                _maskedLength = true;
                _maskedWidth = true;
            }
            else if (comboBoxFigureType.SelectedIndex == 1)
            {
                maskedTextBoxRadius.Text = Convert.ToString(1.111 + random.NextDouble() * (99.999 - 1.111));
                _maskedRadius = true;
            }
            else if (comboBoxFigureType.SelectedIndex == 2)
            {
                maskedTextBoxSideA.Text = Convert.ToString(1111.111 + random.NextDouble() * (1999.999 - 1111.111));
                maskedTextBoxSideB.Text = Convert.ToString(1111.111 + random.NextDouble() * (1999.999 - 1111.111));
                maskedTextBoxSideC.Text = Convert.ToString(1111.111 + random.NextDouble() * (1999.999 - 1111.111));
                _maskedSideA = true;
                _maskedSideB = true;
                _maskedSideC = true;
            }
        }

    }
    
}
