namespace EliteCompanion.PlayerJournal
{
    public class DockingGrantedEvent : BaseEvent
    {
        public int LandingPad { get; set; }

        public string StationName { get; set; }
    }

}