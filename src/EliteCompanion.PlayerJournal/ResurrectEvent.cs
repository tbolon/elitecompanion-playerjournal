namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When the player restarts after death.
    /// </summary>
    public class ResurrectEvent : BaseEvent
    {
        /// <summary>
        /// The option selected on the insurance rebuy screen
        /// </summary>
        public string Option { get; set; }

        public int Price { get; set; }

        public bool Bankrupt { get; set; }
    }
}
