using Newtonsoft.Json;

namespace FormsNMVP.Models
{
    public class Rain
    {
        [JsonProperty("_h")] public double H { get; set; }
    }
}