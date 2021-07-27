using Newtonsoft.Json.Linq;
using System;
using WorkflowParsing.Configuration;

namespace WorkflowParsing.Core
{
    [Obsolete]
    public class ConnectionConverter : JsonCreationConverter<Connection>
    {
        protected override Connection Create(Type objectType, JObject jObject)
        {
            if (FieldExists("Target", jObject))
            {
                return new SingleTargetConnection();
            }
            else if (FieldExists("Targets", jObject))
            {
                return new MultipleTargetConnection();
            }
            else
            {
                return new Connection();
            }
        }

        private bool FieldExists(string fieldName, JObject jObject)
        {
            return jObject[fieldName] != null;
        }
    }
}
