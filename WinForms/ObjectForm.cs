using System;
using System.Drawing;
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
            EditingFigureControl.Location = new Point(12, 14);
            EditingFigureControl.ReadOnly = false;
            EditingFigureControl.Size = new Size(310, 225);
            
            #if DEBUG
            buttonRandom.Visible = true;
            #endif
        }

        public ObjectForm(int numRow)
        {
            InitializeComponent();

            EditingFigureControl.Parent = groupBoxEditing;
            EditingFigureControl.Location = new Point(12, 14);
            EditingFigureControl.ReadOnly = false;
            EditingFigureControl.Size = new Size(344,247);
            EditingFigureControl.Figure = FiguresList.listFigures[numRow];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (EditingFigureControl.CloseCondition())
            {
                EditingFigure = EditingFigureControl.Figure;
                Close();
            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int figureName = random.Next(3);

            EditingFigureControl.FigureRandomName(figureName);
            
            if (figureName == 1)
            {
                var rectangle = new Figures.Rectangle();
                rectangle.StartX = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                rectangle.StartY = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                rectangle.Width = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
                rectangle.Length = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
                EditingFigureControl.Figure = rectangle;
            }
            else if (figureName == 0)
            {
                var circle = new Circle();
                circle.StartX = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                circle.StartY = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                circle.Radius = Convert.ToDouble(1.111 + random.NextDouble() * (99.999 - 1.111));
                EditingFigureControl.Figure = circle;
            }
            else if (figureName == 2)
            {
                var triangle = new Triangle();
                triangle.StartX = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                triangle.StartY = Convert.ToDouble(1.111 + random.NextDouble() * (999.999 - 1.111));
                triangle.SideA = Convert.ToDouble(11.111 + random.NextDouble() * (19.999 - 11.111));
                triangle.SideB = Convert.ToDouble(11.111 + random.NextDouble() * (19.999 - 11.111));
                triangle.SideC = Convert.ToDouble(11.111 + random.NextDouble() * (19.999 - 11.111));
                EditingFigureControl.Figure = triangle;
            }
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            try
            {
                EditingFigure = EditingFigureControl.Figure;
                EditingFigure.GetArea();
                EditingFigureControl.Figure = EditingFigure;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Возможно, данные сторон геометрической фигуры не соответствуют правилам построе ");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Не были введены параметры фигуры");
            } 
        }
    }
}
