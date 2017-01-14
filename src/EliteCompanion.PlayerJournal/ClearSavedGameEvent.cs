namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When you reset your game.
    /// </summary>
    public class ClearSavedGameEvent : BaseEvent
    {
        /// <summary>
        /// Commander name.
        /// </summary>
        public string Name { get; set; }
    }
}
