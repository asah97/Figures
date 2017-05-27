using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace WinForms
{
    public partial class ObjectControlBasic : UserControl
    {
        private bool _readOnly;
        private IFigure _object;
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            textBoxSquare.Text = Convert.ToString(Figure.GetArea());
        }

        public ObjectControlBasic()
        {
            InitializeComponent();
        }

    
        //private bool _empty;
       
        public IFigure Figure
        {
            get
            {
                if (comboBoxFigure.SelectedIndex == 0)
                {
                    var round = new Circle();

                    round.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    round.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    round.Radius = Convert.ToDouble(maskedTextBoxRadius.Text);

                    _object = round;
                }
                else if (comboBoxFigure.SelectedIndex == 1)
                {
                    var rect = new Rectangle();

                rect.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                rect.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                rect.Width = Convert.ToDouble(maskedTextBoxWidth.Text);
                rect.Length = Convert.ToDouble(maskedTextBoxLength.Text);

                return rect;
                }
                else if (comboBoxFigure.SelectedIndex == 2)
                {
                    var trigon = new Triangle();

                    trigon.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    trigon.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    trigon.SetSides(Convert.ToDouble(maskedTextBoxSideA.Text), Convert.ToDouble(maskedTextBoxSideB.Text), Convert.ToDouble(maskedTextBoxSideC.Text));
                    _object = trigon;
                }
                return _object;
            }

            set
            {
                _object = value;
                maskedTextBoxX.Text = Convert.ToString(value.StartX);
                maskedTextBoxY.Text = Convert.ToString(value.StartY);
                textBoxSquare.Text = Convert.ToString(value.GetArea());
                if (value is Figures.Rectangle)
                {
                    var rect = (Figures.Rectangle)value;
                    comboBoxFigure.SelectedIndex = 1;

                    maskedTextBoxWidth.Text = Convert.ToString(rect.Width);
                    maskedTextBoxLength.Text = Convert.ToString(rect.Length);
                }
                else if (value is Figures.Circle)
                {
                    var round = (Figures.Circle)value;
                    comboBoxFigure.SelectedIndex = 0;

                    maskedTextBoxRadius.Text = Convert.ToString(round.Radius);
                }
                else if (value is Figures.Triangle)
                {
                    var trigon = (Figures.Triangle)value;
                    comboBoxFigure.SelectedIndex = 2;

                    maskedTextBoxSideA.Text = Convert.ToString(trigon.SideA);
                    maskedTextBoxSideB.Text = Convert.ToString(trigon.SideB);
                    maskedTextBoxSideC.Text = Convert.ToString(trigon.SideC);
                }
            }
        }

        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;
                if (_readOnly)
                {
                    maskedTextBoxX.ReadOnly = true;
                    maskedTextBoxY.ReadOnly = true;
                    maskedTextBoxLength.ReadOnly = true;
                    maskedTextBoxWidth.ReadOnly = true;
                    maskedTextBoxRadius.ReadOnly = true;
                    maskedTextBoxSideA.ReadOnly = true;
                    maskedTextBoxSideB.ReadOnly = true;
                    maskedTextBoxSideC.ReadOnly = true;
                    _readOnly = true;
                }
                else
                {
                    maskedTextBoxX.ReadOnly = false;
                    maskedTextBoxY.ReadOnly = false;
                    maskedTextBoxLength.ReadOnly = false;
                    maskedTextBoxWidth.ReadOnly = false;
                    maskedTextBoxRadius.ReadOnly = false;
                    maskedTextBoxSideA.ReadOnly = false;
                    maskedTextBoxSideB.ReadOnly = false;
                    maskedTextBoxSideC.ReadOnly = false;
                    _readOnly = false;
                }
            }
        }

        //public bool EmptyCheck()
        //{
        //    return _readOnly;
        //    //if (maskedTextBoxX.Text = "")
        //}

         
        private void comboBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBoxRadius.Visible = comboBoxFigure.SelectedIndex == 0;
            maskedTextBoxWidth.Visible = comboBoxFigure.SelectedIndex == 1;
            maskedTextBoxLength.Visible = comboBoxFigure.SelectedIndex == 1;
            maskedTextBoxSideA.Visible = comboBoxFigure.SelectedIndex == 2;
            maskedTextBoxSideB.Visible = comboBoxFigure.SelectedIndex == 2;
            maskedTextBoxSideC.Visible = comboBoxFigure.SelectedIndex == 2;
        }
    }
}
