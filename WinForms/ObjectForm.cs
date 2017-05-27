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
    public partial class ObjectForm : Form
    {
        private ObjectControlBasic EditingFigureControl = new ObjectControlBasic();

        public IFigure EditingFigure;

        public ObjectForm()
        {
            InitializeComponent();

            EditingFigureControl.Parent = groupBoxEditing;
            EditingFigureControl.Location = new System.Drawing.Point(12, 14);
            EditingFigureControl.ReadOnly = false;
            EditingFigureControl.Size = new System.Drawing.Size(344, 247);
            EditingFigureControl.TabIndex = 11;
            //EditingFigureControl.Parent = this;
            //EditingFigureControl.Location = new Point(5, 5);
            //EditingFigureControl.ReadOnly = false;

        }
       
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            EditingFigure = EditingFigureControl.Figure;
            //DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            //Random random = new Random();
            //int figureName = random.Next(3);

            //switch (figureName)
            //{
            //    case 0:
            //    {
                    
            //        break;
            //    }
            //    case 1:
            //    {
                   
            //        break;
            //    }
            //    case 2:
            //    {
                    
            //        break;
            //    }
            //}
            //figure.StartX = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
            //figure.StartY = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
           
            //if ()
            //{
            //   var rectangle = new Figures.Rectangle(); 
            //   rectangle.Width = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
            //   rectangle.Length = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
            //}
            //else if (comboBoxFigureType.SelectedIndex == 1)
            //{
            //    var circle = new Circle();
            //    circle.Radius = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
            //}
            //else if (comboBoxFigureType.SelectedIndex == 2)
            //{
            //    var triangle = new Triangle();
            //    triangle.SideA = Convert.ToDouble(1111.111 + random.NextDouble() * (1999.999 - 1111.111));
            //    triangle.SideB = Convert.ToDouble(1111.111 + random.NextDouble() * (1999.999 - 1111.111));
            //    triangle.SideC = Convert.ToDouble(1111.111 + random.NextDouble() * (1999.999 - 1111.111));
            //}
        }
    }
}
