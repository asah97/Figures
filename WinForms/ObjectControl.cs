using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    [System.ComponentModel.DefaultBindingProperty("CreatingControl")]
    public partial class ObjectControl : UserControl
    {
        public ObjectControl()
        {
            InitializeComponent();
        }

        private Object _object;

        public Object Object
        {
            get
            {
                if (comboBoxFigureType.SelectedIndex == 0)
                {
                    var rect = new Figures.Rectangle();

                    rect.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    rect.StartY = Convert.ToDouble(maskedTextBoxY.Text);

                    rect.Width = Convert.ToDouble(maskedTextBoxWidth.Text);
                    rect.Length = Convert.ToDouble(maskedTextBoxLength.Text);
                    _object = rect;
                }
                else if (comboBoxFigureType.SelectedIndex == 1)
                {
                    var round = new Figures.Circle();

                    round.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    round.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    round.Radius = Convert.ToDouble(maskedTextBoxRadius.Text);

                    _object = round;
                }
                else if (comboBoxFigureType.SelectedIndex == 2)
                {
                    var trigon = new Figures.Triangle();

                    trigon.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    trigon.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    trigon.SetSides(Convert.ToDouble(maskedTextBoxSideA.Text), Convert.ToDouble(maskedTextBoxSideB.Text), Convert.ToDouble(maskedTextBoxSideC.Text));
                    _object = trigon;
                }
                return _object;
            }
            set
            {
                var common = (Figures.IFigure)value;
                maskedTextBoxX.Text = Convert.ToString(common.StartX);
                maskedTextBoxY.Text = Convert.ToString(common.StartY);
                if (value is Figures.Rectangle)
                {
                    var rect = (Figures.Rectangle)value;
                    comboBoxFigureType.SelectedIndex = 0;

                    maskedTextBoxWidth.Text = Convert.ToString(rect.Width);
                    maskedTextBoxLength.Text = Convert.ToString(rect.Length);
                }
                else if (value is Figures.Circle)
                {
                    var round = (Figures.Circle)value;
                    comboBoxFigureType.SelectedIndex = 1;

                    maskedTextBoxRadius.Text = Convert.ToString(round.Radius);
                }
                else if (value is Figures.Triangle)
                {
                    var trigon = (Figures.Triangle)value;
                    comboBoxFigureType.SelectedIndex = 2;

                    maskedTextBoxSideA.Text = Convert.ToString(trigon.SideA);
                    maskedTextBoxSideB.Text = Convert.ToString(trigon.SideB);
                    maskedTextBoxSideC.Text = Convert.ToString(trigon.SideC);
                }
            }
        }

        public bool ReadOnly 
        {
            get { return ReadOnly; }
            set
            {
                if (ReadOnly)
                {
                    maskedTextBoxX.ReadOnly = true;
                    maskedTextBoxY.ReadOnly = true;
                    maskedTextBoxLength.ReadOnly = true;
                    maskedTextBoxWidth.ReadOnly = true;
                    maskedTextBoxRadius.ReadOnly = true;
                    maskedTextBoxSideA.ReadOnly = true;
                    maskedTextBoxSideB.ReadOnly = true;
                    maskedTextBoxSideC.ReadOnly = true;
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
                }
            }
        }
    }
}
