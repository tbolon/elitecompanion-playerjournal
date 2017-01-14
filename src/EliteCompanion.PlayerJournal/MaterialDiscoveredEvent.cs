namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When a new material is discovered.
    /// </summary>
    public class MaterialDiscoveredEvent : BaseEvent
    {
        public MaterialCategory Category { get; set; }

        public string Name { get; set; }

        public int DiscoveryNumber { get; set; }
    }
}
