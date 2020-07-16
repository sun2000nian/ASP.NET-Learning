using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Movie
    {
        [JsonPropertyName("id")]
        public string ID { get; set; }

        [JsonPropertyName("maker")]
        public string maker { get; set; }
        [JsonPropertyName("title")]
        public string thetitle { get; set; }

        [JsonPropertyName("MyRates")]
        public int[] rates { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Movie>(this);
    }
}
