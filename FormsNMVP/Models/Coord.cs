using Newtonsoft.Json;

namespace FormsNMVP.Models
{
    public class Coord
    {
        [JsonProperty("lon")] public double Lon { get; set; }

        [JsonProperty("lat")] public double Lat { get; set; }
    }
}