namespace EliteCompanion.PlayerJournal
{
    public class EscapeInterdictionEvent : BaseEvent
    {
        public string Interdictor { get; set; }

        public bool IsPlayer { get; set; }
    }
}
