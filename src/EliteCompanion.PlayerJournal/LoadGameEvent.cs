using Newtonsoft.Json;

namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When loading from main menu into game.
    /// </summary>
    public class LoadGameEvent : BaseEvent
    {
        /// <summary>
        /// Commander name.
        /// </summary>
        public string Commander { get; set; }

        /// <summary>
        /// Current ship type.
        /// </summary>
        public string Ship { get; set; }

        /// <summary>
        /// Ship id number.
        /// </summary>
        [JsonProperty("ShipID")]
        public int ShipId { get; set; }

        /// <summary />
        public bool StartLanded { get; set; }

        /// <summary />
        public bool StartDead { get; set; }

        /// <summary>
        /// Open, Solo or Group.
        /// </summary>
        public string GameMode { get; set; }

        /// <summary>
        /// name of group (if in a group).
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// current credit balance.
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// Current load.
        /// </summary>
        public int Loan { get; set; }
    }
}
