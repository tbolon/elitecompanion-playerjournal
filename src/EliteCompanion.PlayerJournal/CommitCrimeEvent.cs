namespace EliteCompanion.PlayerJournal
{
    public class CommitCrimeEvent : BaseEvent
    {
        public string CrimeType { get; set; }

        public string Faction { get; set; }

        public string Victim { get; set; }

        public int Bounty { get; set; }
    }
}
