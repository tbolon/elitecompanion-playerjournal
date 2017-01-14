namespace EliteCompanion.PlayerJournal
{
    public class ShieldStateEvent : BaseEvent
    {
        public bool ShieldsUp { get; set; }

        public bool ShieldsDown { get; set; }
    }
}