using Newtonsoft.Json;

namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When jumping from one star system to another.
    /// </summary>
    public class FSDJumpEvent : BaseEvent, IHasStarSystemInfo
    {
        /// <summary>
        /// Name of destination starsystem.
        /// </summary>
        public string StarSystem { get; set; }

        /// <summary>
        /// Star position, as an arrany [x, y, z] in light years.
        /// </summary>
        public double[] StarPos { get; set; }

        // not seen in current player's log
        ////public string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SystemAllegiance { get; set; }

        public string SystemEconomy { get; set; }

        public string SystemGovernment { get; set; }

        public string SystemSecurity { get; set; }

        public string SystemFaction { get; set; }

        public string FactionState { get; set; }

        /// <summary>
        /// Distance jumped.
        /// </summary>
        [JsonProperty("JumpDist")]
        public float JumpDistance { get; set; }

        public float FuelUsed { get; set; }

        public float FuelLevel { get; set; }

        public string[] Powers { get; set; }

        /// <summary>
        /// One of <see cref="PowerPlayStates"/>.
        /// </summary>
        public string PowerplayState { get; set; }
    }
}