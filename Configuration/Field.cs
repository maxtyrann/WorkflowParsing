using Newtonsoft.Json;
using WorkflowParsing.Abstract;

namespace WorkflowParsing.Configuration
{
    public class Field : IField
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }
    }
}
