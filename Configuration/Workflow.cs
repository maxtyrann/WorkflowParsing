using Newtonsoft.Json;
using System.Collections.Generic;
using WorkflowParsing.Abstract;
using WorkflowParsing.Core;

namespace WorkflowParsing.Configuration
{
    public class Workflow
    {
        [JsonProperty("id")]
        public string WorkflowId { get; set; }

        [JsonProperty("name")]
        public string WorkflowName { get; set; }

        [JsonProperty("nodes")]
        public IList<Node> Nodes { get; set; }
        
        [JsonProperty("connections"), JsonConverter(typeof(JsonConnectionConverter))]
        public IList<IConnection> Connections { get; set; }

        [JsonProperty("metadata")]
        public IList<KeyValuePair<string, string>> Metadata { get; set; }
    }
}
