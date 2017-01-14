namespace EliteCompanion.PlayerJournal
{
    public class InterdictedEvent : BaseEvent
    {
        public bool Submitted { get; set; }

        public string Interdictor { get; set; }

        public bool IsPlayer { get; set; }

        public string Faction { get; set; }
    }
}