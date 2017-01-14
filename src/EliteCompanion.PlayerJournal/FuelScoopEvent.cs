namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When scooping fuel from star.
    /// </summary>
    public class FuelScoopEvent : BaseEvent
    {
        /// <summary>
        /// Tons of fuel scooped.
        /// </summary>
        public float Scooped { get; set; }

        /// <summary>
        /// Total fuel level after scooping.
        /// </summary>
        public float Total { get; set; }
    }
}
