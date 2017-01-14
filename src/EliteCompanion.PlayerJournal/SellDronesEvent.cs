namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When selling unwanted drones back to the market.
    /// </summary>
    /// <seealso cref="BuyDronesEvent"/>
    public class SellDronesEvent : BaseEvent
    {
        public string Type { get; set; }

        public int Count { get; set; }

        public int SellPrice { get; set; }

        public int TotalSale { get; set; }
    }
}
