namespace EliteCompanion.PlayerJournal
{
    public class SupercruiseExitEvent : BaseEvent, IHasStarSystem, IHasBody
    {
        public string StarSystem { get; set; }

        public string Body { get; set; }

        public string BodyType { get; set; }
    }
}