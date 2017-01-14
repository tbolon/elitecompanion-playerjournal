namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When purchasing drones.
    /// </summary>
    /// <seealso cref="SellDronesEvent"/>
    public class BuyDronesEvent : BaseEvent
    {
        public string Type { get; set; }

        public int Count { get; set; }

        public int BuyPrice { get; set; }

        public int TotalCost { get; set; }
    }
}
