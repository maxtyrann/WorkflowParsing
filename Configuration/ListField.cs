using Newtonsoft.Json;
using System.Collections.Generic;

namespace WorkflowParsing.Configuration
{
    public class ListField : Field
    {
        [JsonProperty("selectedValue")]
        public string SelectedValue { get; set; }

        [JsonProperty("values")]
        public IList<Option> Values { get; set; }
    }
}
