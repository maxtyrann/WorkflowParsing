using Newtonsoft.Json;

namespace WorkflowParsing.Configuration
{
    public class SingleTargetConnection : Connection
    {
        [JsonProperty("target")]
        public string Target { get; set; }
    }
}
