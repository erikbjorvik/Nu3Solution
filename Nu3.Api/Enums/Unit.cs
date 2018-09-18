using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nu3.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Unit
    {
		Portion,
		Psc,
		Ml,
		Cl,
		Dl,
		L,
		Mg,
		G,
		Hg,
		Kg
    }
}