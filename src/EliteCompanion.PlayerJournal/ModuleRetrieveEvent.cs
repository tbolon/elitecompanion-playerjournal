namespace EliteCompanion.PlayerJournal
{
    public class ModuleRetrieveEvent : BaseEvent
    {
        public string Slot { get; set; }

        public string RetrievedItem { get; set; }

        public string EngineerModifications { get; set; }

        public string SwapOutItem { get; set; }

        public string Ship { get; set; }

        public int ShipID { get; set; }
    }
}
