using Newtonsoft.Json;
using WorkflowParsing.Abstract;

namespace WorkflowParsing.Configuration
{
    public class Connection : IConnection
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
