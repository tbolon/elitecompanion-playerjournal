namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When moving a module to a different slot on the ship
    /// </summary>
    public class ModuleSwapEvent : BaseEvent
    {
        public string FromSlot { get; set; }

        public string ToSlot { get; set; }

        public string FromItem { get; set; }

        public string ToItem { get; set; }

        public string Ship { get; set; }

        public int ShipID { get; set; }
    }
}
