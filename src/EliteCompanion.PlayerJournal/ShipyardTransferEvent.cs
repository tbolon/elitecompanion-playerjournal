namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When requesting a ship at another station be transported to this station.
    /// </summary>
    public class ShipyardTransferEvent : BaseEvent
    {
        public string ShipType { get; set; }

        public int ShipID { get; set; }

        public string System { get; set; }

        public double Distance { get; set; }

        public int TransferPrice { get; set; }
    }
}
