using System.Text.Json.Serialization;

namespace GenAIApp.Models
{
    public class OpenAiResponse
    {
        [JsonPropertyName("text")]
        public required string Text {get; set;}
    }
}