namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When selling a module in storage at another station
    /// </summary>
    public class ModuleSellRemoteEvent : BaseEvent
    {
        public string StorageSlot { get; set; }

        public string SellItem { get; set; }

        public int ServerId { get; set; }

        public int SellPrice { get; set; }

        public string Ship { get; set; }

        public int ShipID { get; set; }
    }
}
