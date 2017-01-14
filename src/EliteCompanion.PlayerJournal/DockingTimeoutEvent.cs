namespace EliteCompanion.PlayerJournal
{
    public class DockingTimeoutEvent : BaseEvent, IHasStationName
    {
        public string StationName { get; set; }
    }
}
