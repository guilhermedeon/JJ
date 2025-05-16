using System.Text.Json.Serialization;

namespace TestJJ.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public required int Id { get; set; }

        [JsonPropertyName("name")]
        public required string Name { get; set; }

        [JsonPropertyName("username")]
        public required string Username { get; set; }

        [JsonPropertyName("email")]
        public required string Email { get; set; }

        [JsonPropertyName("address")]
        public required Address Address { get; set; }

        [JsonPropertyName("phone")]
        public required string Phone { get; set; }

        [JsonPropertyName("website")]
        public required string Website { get; set; }

        [JsonPropertyName("company")]
        public required Company Company { get; set; }
    }
}
