using System.ComponentModel;

namespace EliteCompanion.PlayerJournal
{
    public class LocationEvent : BaseEvent, IHasStarSystemInfo, IHasBody, IHasStationName
    {
        [DefaultValue(false)]
        public bool Docked { get; set; }

        /// <summary>
        /// Name of station.
        /// </summary>
        public string StationName { get; set; }

        /// <summary>
        /// Type of station, see <see cref="StationTypes"/>.
        /// </summary>
        public string StationType { get; set; }

        public string Body { get; set; }

        public string BodyType { get; set; }

        public string StarSystem { get; set; }

        public double[] StarPos { get; set; }

        public string SystemAllegiance { get; set; }

        public string SystemEconomy { get; set; }

        public string SystemGovernment { get; set; }

        public string SystemSecurity { get; set; }

        public string SystemFaction { get; set; }

        public string FactionState { get; set; }

        public string[] Powers { get; set; }

        /// <summary>
        /// One of <see cref="PowerPlayStates"/>.
        /// </summary>
        public string PowerplayState { get; set; }
    }
}
