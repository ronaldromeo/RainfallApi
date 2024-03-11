using System.Text;
using Newtonsoft.Json;

namespace RainfallApi.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class RainfallItem
    {
        [JsonProperty("@id")]
        public string id { get; set; }
        public DateTime dateTime { get; set; }
        public string measure { get; set; }
        public double value { get; set; }
    }

    public class RainfallMetadata
    {
        public string publisher { get; set; }
        public string licence { get; set; }
        public string documentation { get; set; }
        public string version { get; set; }
        public string comment { get; set; }
        public List<string> hasFormat { get; set; }
        public int limit { get; set; }
    }

    public class RainfallReadingModel
    {
        [JsonProperty("@context")]
        public string context { get; set; }
        public RainfallMetadata meta { get; set; }
        public List<RainfallItem> items { get; set; }
    }


}
