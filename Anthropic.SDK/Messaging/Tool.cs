using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Anthropic.SDK.Messaging
{
    public class InputSchema
    {
        public string type { get; set; } = "object";
        public Dictionary<string, Property> properties { get; set; }
        public IList<string> required { get; set; }
    }
    
    public class Tool
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("input_schema")]
        public InputSchema Arguments { get; set; }
    }

    public class Property
    {
        public string type { get; set; }
        public string description { get; set; }
    }

}
