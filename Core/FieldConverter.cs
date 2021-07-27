using Newtonsoft.Json.Linq;
using System;
using WorkflowParsing.Configuration;

namespace WorkflowParsing.Core
{
    [Obsolete]
    public class FieldConverter : JsonCreationConverter<Field>
    {
        protected override Field Create(Type objectType, JObject jObject)
        {
            if (FieldExists("PlaceHolder", jObject))
            {
                return new TextField();
            }
            else if (FieldExists("SelectedValue", jObject))
            {
                return new ListField();
            }
            else
            {
                return new Field();
            }
        }

        private bool FieldExists(string fieldName, JObject jObject)
        {
            return jObject[fieldName] != null;
        }
    }
}
