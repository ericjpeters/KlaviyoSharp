using Newtonsoft.Json;

namespace KlaviyoSharp.Infrastructure;

/// <summary>
/// Converts a nullable DateTime to a string in the format yyyy-MM-dd when converting to JSON
/// </summary>
internal class KlaviyoDateOnlyNullableJsonConverter : JsonConverter<KlaviyoDateOnly?>
{
    public override KlaviyoDateOnly? ReadJson(JsonReader reader,
                                              Type objectType,
                                              KlaviyoDateOnly? existingValue,
                                              bool hasExistingValue,
                                              JsonSerializer serializer)
    {
        if (reader.Value is null)
        {
            return null;
        }

        return KlaviyoDateOnly.Parse(reader.Value.ToString()!);
    }

    public override void WriteJson(JsonWriter writer, KlaviyoDateOnly? value, JsonSerializer serializer)
    {
        if (value is null)
        {
            writer.WriteNull();
        }
        else
        {
            writer.WriteValue(value.GetValueOrDefault().ToString("yyyy-MM-dd"));
        }
    }
}
