using Newtonsoft.Json;

namespace WinForms
{
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
    }
}
