using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nu3.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MealCategory
    {
        Breakfast,
		Lunch,
        Dinner,
        Supper,
        Snack,
        General
	}
}