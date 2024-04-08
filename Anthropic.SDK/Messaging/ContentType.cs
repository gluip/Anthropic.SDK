using System.Text.Json.Serialization;

namespace Anthropic.SDK.Messaging
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ContentType
    {
        text,

        image,

        tool_use, // "tool_use
        tool_result
    }
}