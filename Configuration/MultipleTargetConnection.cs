using Newtonsoft.Json;
using System.Collections.Generic;

namespace WorkflowParsing.Configuration
{
    public class MultipleTargetConnection : Connection
    {
        [JsonProperty("targets")]
        public IList<string> Targets { get; set; }
    }
}
