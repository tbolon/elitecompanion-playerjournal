using Newtonsoft.Json;

namespace EliteCompanion.PlayerJournal
{
    public class FileHeaderEvent : BaseEvent
    {
        [JsonProperty("part")]
        public int Part { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("gameversion")]
        public string GameVersion { get; set; }

        [JsonProperty("build")]
        public string Build { get; set; }
    }
}
