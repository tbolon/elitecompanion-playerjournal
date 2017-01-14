namespace EliteCompanion.PlayerJournal
{
    public class ModuleSellEvent : BaseEvent
    {
        public string Slot { get; set; }

        public string SellItem { get; set; }

        public int SellPrice { get; set; }

        public string Ship { get; set; }

        public int ShipID { get; set; }
    }
}
