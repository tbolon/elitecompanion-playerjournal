namespace EliteCompanion.PlayerJournal
{
    public class RepairEvent : BaseEvent
    {
        public string Item { get; set; }

        public int Cost { get; set; }
    }
}
