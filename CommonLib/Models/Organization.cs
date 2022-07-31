using Newtonsoft.Json;

namespace CommonLib.Models
{
    /// <summary>
    /// Организация
    /// </summary>
    public class Organization
    {
        [JsonProperty("Название")]
        public string Name { get; set; }

        [JsonProperty("Адрес")]
        public string Address { get; set; }

        public Organization(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
