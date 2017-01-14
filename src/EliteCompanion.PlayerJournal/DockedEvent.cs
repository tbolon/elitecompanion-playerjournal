namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When landing at landing pad in a space station, outpost, or surface settlement.
    /// </summary>
    public class DockedEvent : BaseEvent, IHasStarSystem, IHasStationName
    {
        /// <summary>
        /// Name of station.
        /// </summary>
        public string StationName { get; set; }

        /// <summary>
        /// Type of station, see <see cref="StationTypes"/>.
        /// </summary>
        public string StationType { get; set; }

        public string StarSystem { get; set; }

        public string StationFaction { get; set; }

        public string FactionState { get; set; }

        public string StationGovernment { get; set; }

        public string StationAllegiance { get; set; }

        public string StationEconomy { get; set ;}
    }
}