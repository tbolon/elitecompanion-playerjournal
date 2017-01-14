namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When a player increases their access to an engineer.
    /// </summary>
    public class EngineerProgressEvent : BaseEvent
    {
        public string Engineer { get; set; }

        public int Rank { get; set; }

        public EngineerProgress Progress { get; set; }
    }
}
