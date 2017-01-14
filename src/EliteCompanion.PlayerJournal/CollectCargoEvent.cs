namespace EliteCompanion.PlayerJournal
{
    public class CollectCargoEvent : BaseEvent
    {
        public string Type { get; set; }

        public bool Stolen { get; set; }
    }
}
