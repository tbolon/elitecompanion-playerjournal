﻿namespace EliteCompanion.PlayerJournal
{
    public class ModuleBuyEvent : BaseEvent
    {
        public string Slot { get; set; }

        public string BuyItem { get; set; }

        public int BuyPrice { get; set; }

        public string Ship { get; set; }

        public int ShipID { get; set; }

        public string SellItem { get; set; }

        public int SellPrice { get; set; }
    }
}
