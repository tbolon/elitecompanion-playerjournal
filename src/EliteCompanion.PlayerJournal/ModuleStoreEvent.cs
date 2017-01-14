namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When storing a module in Outfitting.
    /// </summary>
    public class ModuleStoreEvent: BaseEvent
    {
        public string Slot { get; set; }

        public string StoredItem { get; set; }

        public string EngineerModifications { get; set; }

        public string ReplacementItem { get; set; }

        public string Ship { get; set; }

        public int ShipID { get; set; }
    }
}
