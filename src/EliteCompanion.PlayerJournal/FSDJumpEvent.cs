using Newtonsoft.Json;

namespace EliteCompanion.PlayerJournal
{
    public class FSDJumpEvent : BaseEvent
    {
        public string StarSystem { get; set; }

        public double[] StarPos { get; set; }

        public string SystemAllegiance { get; set; }

        public string SystemEconomy { get; set; }

        public string SystemGovernment { get; set; }

        public string SystemSecurity { get; set; }

        [JsonProperty("JumpDist")]
        public float JumpDistance { get; set; }

        public float FuelUsed { get; set; }

        public float FuelLevel { get; set; }

        public string SystemFaction { get; set; }

        public string FactionState { get; set; }
    }
}