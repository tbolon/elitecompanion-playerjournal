namespace EliteCompanion.PlayerJournal
{
    public class SupercruiseExitEvent : BaseEvent
    {
        public string StarSystem { get; set; }

        public string Body { get; set; }

        public string BodyType { get; set; }
    }
}