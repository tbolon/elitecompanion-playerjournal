namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// Whenever materials are collected.
    /// </summary>
    public class MaterialCollectedEvent : BaseEvent
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
        /// Number of units collected.
        /// </summary>
        public int Count { get; set; }
    }
}
