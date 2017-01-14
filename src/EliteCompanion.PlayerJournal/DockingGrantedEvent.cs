namespace EliteCompanion.PlayerJournal
{
    public class DockingGrantedEvent : BaseEvent, IHasStationName
    {
        /// <summary>
        /// Station name.
        /// </summary>
        public string StationName { get; set; }

        /// <summary>
        /// Pad number.
        /// </summary>
        public int LandingPad { get; set; }
    }
}