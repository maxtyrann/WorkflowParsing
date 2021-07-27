using Newtonsoft.Json;

namespace WorkflowParsing.Configuration
{
    public class TextField : Field
    {
        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
