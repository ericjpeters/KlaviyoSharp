using System.Linq;
using System.Runtime.Serialization;

namespace KlaviyoSharp;

internal static class EnumExtensions
{
    /// <summary>
    /// Convert Enum to string
    /// </summary>
    /// <typeparam name="T">Enum type</typeparam>
    /// <param name="value">Enum Value</param>
    /// <returns></returns>
    public static string ToEnumString<T>(this T value)
        where T : struct, Enum
    {
        Type enumType = typeof(T);
        string? name = Enum.GetName(enumType, value);

        string? ouptut = null;
        if (!String.IsNullOrWhiteSpace(name))
        {
            ouptut = ((EnumMemberAttribute[]?)enumType?
                            .GetField(name)?
                            .GetCustomAttributes(typeof(EnumMemberAttribute), true))?
                            .SingleOrDefault()?
                            .Value;
        }

        return ouptut ?? value.ToString();
    }
}