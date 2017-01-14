using System;
using Newtonsoft.Json;

namespace EliteCompanion.PlayerJournal
{
    public class MissionAcceptedEvent : BaseEvent
    {
        public string Faction { get; set; }

        public string Name { get; set; }

        public string DestinationSystem { get; set; }

        public string DestinationStation { get; set; }

        public DateTime Expiry { get; set; }

        [JsonProperty("MissionID")]
        public int MissionId { get; set; }
    }
}