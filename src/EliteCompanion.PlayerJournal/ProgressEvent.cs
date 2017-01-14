namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When you start the game, contains rank progression informations.
    /// </summary>
    public class ProgressEvent : BaseEvent
    {
        /// <summary>
        /// Percent progress to next Combat rank.
        /// </summary>
        public int Combat { get; set; }

        /// <summary>
        /// Percent progress to next Trade rank.
        /// </summary>
        public int Trade { get; set; }

        /// <summary>
        /// Percent progress to next Explore rank.
        /// </summary>
        public int Explore { get; set; }

        /// <summary>
        /// Percent progress to next Empire rank.
        /// </summary>
        public int Empire { get; set; }

        /// <summary>
        /// Percent progress to next Federation rank.
        /// </summary>
        public int Federation { get; set; }

        /// <summary>
        /// Percent progress to next CQC rank.
        /// </summary>
        public int CQC { get; set; }
    }
}
