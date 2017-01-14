namespace EliteCompanion.PlayerJournal
{
    public class DockingRequestedEvent : BaseEvent, IHasStationName
    {
        public string StationName { get; set; }
    }

}