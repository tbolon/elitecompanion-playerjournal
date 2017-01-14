namespace EliteCompanion.PlayerJournal
{
    public class MarketSellEvent : BaseEvent
    {
        public string Type { get; set; }

        public int Count { get; set; }

        public int SellPrice { get; set; }

        public int TotalSale { get; set; }

        public int AvgPricePaid { get; set; }
    }
}