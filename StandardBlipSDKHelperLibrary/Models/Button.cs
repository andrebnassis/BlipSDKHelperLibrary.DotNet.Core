using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StandardBlipSDKHelperLibrary.Models
{
    internal class Button
    {
        [JsonConverter(typeof(StringEnumConverter))]
        internal ButtonType Type { get; set; }
        internal string Text { get; set; }
        internal string Value { get; set; }
        internal int Order { get; set; }
    }
    
}
