namespace EliteCompanion.PlayerJournal
{
    public class SupercruiseEntryEvent : BaseEvent, IHasStarSystem
    {
        public string StarSystem { get; set; }
    }
}