namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When scanning some types of data links.
    /// </summary>
    public class DataScannedEvent : BaseEvent
    {
        /// <summary>
        /// eg. "TouristBeacon", "DataLink", "DataPoint", "ListeningPost", "AbandonedDataLog", "WreckedShip".
        /// </summary>
        public string Type { get; set; }
    }
}
