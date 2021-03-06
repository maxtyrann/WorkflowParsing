using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using WorkflowParsing.Abstract;
using WorkflowParsing.Configuration;

namespace WorkflowParsing.Core
{

    public sealed class JsonFieldConverter : JsonConverter
    {
        // destination data type
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IField);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            List<IField> results = null;

            // Are there multiple results?
            if (reader.TokenType == JsonToken.StartArray)
            {
                // Retrieve a list of Json objects
                var jObjs = serializer.Deserialize<IList<JObject>>(reader);
                if (jObjs != null && jObjs.Count > 0)
                {
                    results = new List<IField>();

                    for (int i = 0; i < jObjs.Count; i++)
                    {
                        // Does the object contain a "type" identifier - eg: "type":
                        //var token = jObjs[i].FindTokens("type");
                        var tokens = jObjs[i].SelectTokens("type").ToList();
                        if (tokens != null && tokens.Count > 0)
                        {
                            // Only one is expected
                            switch (tokens[0].ToString())
                            {
                                // "type": "text"
                                case "text":
                                    results.Add(Convert<TextField>(jObjs[i]));
                                    break;
                                // "type": "list"
                                case "list":
                                    results.Add(Convert<ListField>(jObjs[i]));
                                    break;
                            }
                        }
                    }
                }
            }
            return results;
        }

        // Convert Json Object data into a specified class type
        private TModel Convert<TModel>(JObject jObj) where TModel : IField
        {
            return JsonHelper.ToClass<TModel>(jObj.ToString());
        }

        // one way conversion, so back to Json is not required
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
