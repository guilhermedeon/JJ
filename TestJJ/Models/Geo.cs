using System.Text.Json.Serialization;

namespace TestJJ.Models
{
    public class Geo
    {
        [JsonPropertyName("lat")]
        public required string Lat { get; set; }

        [JsonPropertyName("lng")]
        public required string Lng { get; set; }
    }
}
