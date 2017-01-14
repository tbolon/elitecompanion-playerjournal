namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When purchasing goods in the market.
    /// </summary>
    public class MarketBuyEvent : BaseEvent
    {
        /// <summary>
        /// Cargo type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Number of units.
        /// </summary>
        public int Count { get; set; }

        public int BuyPrice { get; set; }

        public int TotalCost { get; set; }
    }
}
