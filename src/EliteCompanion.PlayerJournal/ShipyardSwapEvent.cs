namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When switching to another ship already stored at this station.
    /// </summary>
    public class ShipyardSwapEvent : BaseEvent
    {
        public string ShipType { get; set; }

        public int ShipID { get; set; }

        public string StoreOldShip { get; set; }

        public int StoreShipID { get; set; }

        public string SellOldShip { get; set; }

        public int SellShipID { get; set; }
    }
}
