using CommonLib.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace CommonLib.Services
{
    public class NewtonJsonService : IJsonService
    {
        private JsonConverter[] converters;

        public NewtonJsonService()
        {
            converters = GetConverters("dd.MM.yyyy");
        }

        private JsonConverter[] GetConverters(string dateTimeFormat)
        {
            var output = new List<JsonConverter>();
            output.Add(new StringEnumConverter());
            output.Add(new IsoDateTimeConverter { DateTimeFormat = dateTimeFormat });

            return output.ToArray();
        }

        public Book Deserialize(string jsonData)
        {
            return JsonConvert.DeserializeObject<Book>(jsonData, converters);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented, this.converters);
        }
    }
}