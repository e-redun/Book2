
using Newtonsoft.Json;

namespace CommonLib.Models
{
    public class Person
    {
        [JsonProperty("Фамилия")]
        public string Surname { get; set; }

        [JsonProperty("Имя")]
        public string Firstname { get; set; }

        [JsonProperty("Отчество")]
        public string Patronymic { get; set; }
    }
}