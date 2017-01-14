namespace EliteCompanion.PlayerJournal
{
    public class SellExplorationDataEvent : BaseEvent
    {
        public string[] Systems { get; set; }

        public string[] Bodies { get; set; }

        public int BaseValue { get; set; }

        public int Bonus { get; set; }
    }
}
