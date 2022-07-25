using Newtonsoft.Json;

namespace CommonLib.Models
{
    public class Bookmark
    {
        [JsonProperty("Примечание")]
        public string Note { get; set; }

        [JsonProperty("Страница")]
        public int Page { get; set; }

        public Bookmark(string note, int page)
        {
            Note = note;
            Page = page;
        }
    }
}