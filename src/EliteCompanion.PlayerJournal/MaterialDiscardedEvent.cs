namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// Whenever materials are discarded.
    /// </summary>
    public class MaterialDiscardedEvent : BaseEvent
    {
        /// <summary>
        /// Type of material (Raw/Encoded/Manufactured)
        /// </summary>
        public MaterialCategory Category { get; set; }

        /// <summary>
        /// Name of material.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Number of units discarded.
        /// </summary>
        public int Count { get; set; }
    }
}
