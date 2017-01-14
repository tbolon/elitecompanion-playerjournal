namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When buying system data via the galaxy map.
    /// </summary>
    public class BuyExplorationDataEvent : BaseEvent
    {
        public string System { get; set; }

        public int Cost { get; set; }
    }
}
