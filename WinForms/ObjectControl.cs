using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figures;

namespace WinForms
{
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
                    var Rect = new Figures.Rectangle();

                    Rect.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    Rect.StartY = Convert.ToDouble(maskedTextBoxY.Text);

                    Rect.Width = Convert.ToDouble(maskedTextBoxWidth.Text);
                    Rect.Length = Convert.ToDouble(maskedTextBoxLength.Text);
                    _object = Rect;
                }
                else if (comboBoxFigureType.SelectedIndex == 1)
                {
                    var Round = new Figures.Circle();

                    Round.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    Round.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    Round.Radius = Convert.ToDouble(maskedTextBoxRadius.Text);

                    _object = Round;
                }
                else if (comboBoxFigureType.SelectedIndex == 2)
                {
                    var Trigon = new Figures.Triangle();

                    Trigon.StartX = Convert.ToDouble(maskedTextBoxX.Text);
                    Trigon.StartY = Convert.ToDouble(maskedTextBoxY.Text);
                    Trigon.SetSides(Convert.ToDouble(maskedTextBoxSideA.Text), Convert.ToDouble(maskedTextBoxSideB.Text), Convert.ToDouble(maskedTextBoxSideC.Text));
                    _object = Trigon;
                }
                return _object;
            }
            set
            {
                var Common = (Figures.IFigure) value;
                maskedTextBoxX.Text = Convert.ToString(Common.StartX);
                maskedTextBoxY.Text = Convert.ToString(Common.StartY);
                if (value is Figures.Rectangle)
                {
                    var Rect = (Figures.Rectangle)value;
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

        public bool ReadOnly
        {
            get { return ReadOnly; }
            set
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
        }
    }
}
