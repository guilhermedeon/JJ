using System.Text.Json.Serialization;

namespace TestJJ.Models
{
    public class Address
    {
        [JsonPropertyName("street")]
        public required string Street { get; set; }

        [JsonPropertyName("suite")]
        public required string Suite { get; set; }

        [JsonPropertyName("city")]
        public required string City { get; set; }

        [JsonPropertyName("zipcode")]
        public required string Zipcode { get; set; }
    }
}
