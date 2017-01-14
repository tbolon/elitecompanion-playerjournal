namespace EliteCompanion.PlayerJournal
{
    public class MissionAbandonedEvent : BaseEvent
    {
        public string Name { get; set; }

        public int MissionID { get; set; }
    }
}
