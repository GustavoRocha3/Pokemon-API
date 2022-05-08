using Newtonsoft.Json;

namespace PokeApi
{
    public class PokemonResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("types")]
        public string Types { get; set; }
        [JsonProperty("abilities")]
        public string Abilities { get; set; }
        [JsonProperty("wight")]
        public string Weight { get; set; }
        [JsonProperty("height")]
        public string Height { get; set; }
        [JsonProperty("sprites")]
        public string Sprites { get; set; }
    }
}