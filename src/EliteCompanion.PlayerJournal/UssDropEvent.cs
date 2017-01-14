using Newtonsoft.Json;

namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When dropping from Supercruise at a USS.
    /// </summary>
    public class UssDropEvent : BaseEvent
    {
        [JsonProperty("USSType")]
        public string UssType {get;set;}

        [JsonProperty("USSThreat")]
        public int UssThreat { get; set; }
    }
}
