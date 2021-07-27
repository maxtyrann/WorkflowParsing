using Newtonsoft.Json;
using System.Collections.Generic;
using WorkflowParsing.Abstract;
using WorkflowParsing.Core;

namespace WorkflowParsing.Configuration
{
    public class Node
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fields"), JsonConverter(typeof(JsonFieldConverter))]
        public IList<IField> Fields { get; set; }

        [JsonProperty("metadata")]
        public IList<KeyValuePair<string, string>> Metadata { get; set; }
    }
}
