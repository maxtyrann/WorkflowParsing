using Newtonsoft.Json;

namespace WorkflowParsing.Configuration
{
    public class Option
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
