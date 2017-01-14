namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When creating a new commander.
    /// </summary>
    public class NewCommanderEvent : BaseEvent
    {
        /// <summary>
        /// New commander name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Selected starter package.
        /// </summary>
        public string Package { get; set; }
    }
}
