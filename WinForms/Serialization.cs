using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Figures;


namespace WinForms
{
    /// <summary>
    /// Сериализация, выделенная под целый класс 
    /// </summary>
    public class Serialization
    {
        private JsonSerializer _serializer = new JsonSerializer()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include
        };

        public JsonSerializer SerialAccess
        {
            get { return _serializer; }
            set { _serializer = value; }
        }

        public void Serializing(SaveFileDialog sv, FiguresList list)
        {
            using (StreamWriter sw = new StreamWriter(sv.FileName))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    SerialAccess.Serialize(writer, list.listFigures);
                }
            }
        }

        public void Deserializing(OpenFileDialog dg, FiguresList list)
        {
            using (StreamReader sr = new StreamReader(dg.FileName))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    list.listFigures = (List<IFigure>) SerialAccess.Deserialize(reader, typeof(List<IFigure>));
                }
            }
        }
    }
}
