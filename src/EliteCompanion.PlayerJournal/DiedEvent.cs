namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When player is killed (by a single ship or a wing).
    /// </summary>
    public class DiedEvent : BaseEvent
    {
        public string KillerName { get; set; }

        public string KillerShip { get; set; }

        public string KillerRank { get; set; }

        /// <summary>
        /// When player was killed by a wing.
        /// </summary>
        public Killer[] Killers { get; set; }
    }
}
