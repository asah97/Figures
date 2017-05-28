using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Figures;

namespace WinForms
{
    public partial class FiguresForm : Form
    {
        private ObjectControlBasic mainFigureControl = new ObjectControlBasic();

        public FiguresForm()
        {
            InitializeComponent();

            mainFigureControl.Parent = groupBoxData;
            mainFigureControl.Location = new System.Drawing.Point(7, 15);
            mainFigureControl.ReadOnly = true;
            mainFigureControl.Size = new System.Drawing.Size(344, 247);

            if (FiguresList.listFigures.Count != 0)
            {
               mainFigureControl.Figure = FiguresList.listFigures[dataGridViewFigures.SelectedCells[0].RowIndex];
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ObjectForm formAdd = new ObjectForm();
            formAdd.ShowDialog();

            var figure = formAdd.EditingFigure;
            if (figure == null)
            {
                return;
            }
            dataGridViewFigures.Rows.Add(figure.GetType().Name, figure.StartX, figure.StartY, figure.GetArea());
            FiguresList.listFigures.Add(figure);
            mainFigureControl.Figure = FiguresList.listFigures[dataGridViewFigures.SelectedCells[0].RowIndex];
        }

        //Кнопка удаления строки из списка 
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewFigures.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст!");
            }
            else
            {
                int removeIndex = dataGridViewFigures.CurrentCell.RowIndex;
                dataGridViewFigures.Rows.RemoveAt(removeIndex);
                FiguresList.listFigures.RemoveAt(removeIndex);
                mainFigureControl.Clear();;
            }
        }

        //Кнопка изменения данных в строке списка через форму создания фигуры
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridViewFigures.Rows.Count == 0)
            {
                MessageBox.Show("Список пуст!");
            }
            else
            {
                int modIndex = dataGridViewFigures.CurrentCell.RowIndex;

                ObjectForm formMod = new ObjectForm(modIndex);
                formMod.EditingFigure = FiguresList.listFigures[modIndex];
                formMod.ShowDialog();
                var newFigure = formMod.EditingFigure;
                if (formMod.EditingFigure == null)
                {
                    return;
                }
                FiguresList.listFigures.Insert(dataGridViewFigures.SelectedCells[0].RowIndex, newFigure);
                FiguresList.listFigures.RemoveAt(dataGridViewFigures.SelectedCells[0].RowIndex + 1);
                dataGridViewFigures.Rows.Clear();
                foreach (var data in FiguresList.listFigures)
                {
                    dataGridViewFigures.Rows.Add(data.GetType().Name, data.StartX, data.StartY, data.GetArea());
                }
             }
        }

        //Поиск данных по названию фигуры     
        private void textBoxSearchType_TextChanged(object sender, EventArgs e)
        {
            dataGridViewFigures.ClearSelection();
            for (int i = 0; i < dataGridViewFigures.Rows.Count; i++)
            {
                dataGridViewFigures.Rows[i].Visible = false;
                if (dataGridViewFigures[0, i].Value.ToString() == textBoxSearchType.Text)
                {
                    dataGridViewFigures.Rows[i].Visible = true;
                }
            }
            if (textBoxSearchType.Text == "")
            {
                for (int i = 0; i < dataGridViewFigures.Rows.Count; i++)
                    dataGridViewFigures.Rows[i].Visible = true;
            }
        }

       //Сериализация (сохранение) списка
       private void savingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serialization serial = new Serialization();
            JsonSerializer ser = serial.SerialAccess;

            saveFile.Filter = "Списки фигур (*.goo)|*.goo";
            if (FiguresList.listFigures.Count == 0)
            {
                MessageBox.Show("Список фигур пуст.");
            }
            else if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFile.FileName))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        ser.Serialize(writer, FiguresList.listFigures);
                    }
                }
                MessageBox.Show("Список сохранен.");
            }
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serialization serial = new Serialization();
            JsonSerializer ser = serial.SerialAccess;

            openFile.Filter = "Списки фигур (.goo)|*.goo";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    using (JsonReader reader = new JsonTextReader(sr))
                    {
                        FiguresList.listFigures = (List<IFigure>)ser.Deserialize(reader, typeof(List<IFigure>));
                        dataGridViewFigures.Rows.Clear();
                        foreach (var data in FiguresList.listFigures)
                        {
                            dataGridViewFigures.Rows.Add(data.GetType().Name, data.StartX, data.StartY, data.GetArea());
                        }
                    }
                }
            }
        }

        private void dataGridViewFigures_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridViewFigures.CurrentCell;
            int position = cell.RowIndex;
            mainFigureControl.Figure = FiguresList.listFigures[position];
        }
    }
}
