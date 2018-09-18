using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nu3.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Vitamin
    {
        A,
        B,
        C,
        D,
        E
    }
}