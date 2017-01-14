using Newtonsoft.Json;
using System;

namespace EliteCompanion.PlayerJournal
{
    public abstract class BaseEvent
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }
    }
}
