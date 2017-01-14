namespace EliteCompanion.PlayerJournal
{
    public class DockingCancelledEvent : BaseEvent, IHasStationName

    {
        public string StationName { get; set; }
    }
}
