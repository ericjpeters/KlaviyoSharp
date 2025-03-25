using Newtonsoft.Json;

namespace KlaviyoSharp.Infrastructure;

/// <summary>
/// Converts a DateTime to a string in the format yyyy-MM-ddTHH:mm:ssZ when converting to JSON
/// </summary>
internal class DateTimeJsonConverter : JsonConverter<DateTime>
{
    public override DateTime ReadJson(JsonReader reader,
                                      Type objectType,
                                      DateTime existingValue,
                                      bool hasExistingValue,
                                      JsonSerializer serializer)
    {
        if (reader.Value is null)
        {
            return DateTime.MinValue;
        }

        return DateTime.Parse(reader.Value.ToString()!);
    }
    public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
    {
        writer.WriteValue(value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }
}
