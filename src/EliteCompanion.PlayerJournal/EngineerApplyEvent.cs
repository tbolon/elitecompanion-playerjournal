namespace EliteCompanion.PlayerJournal
{
    public class EngineerApplyEvent : BaseEvent
    {
        public string Engineer { get; set; }
        
        public string Blueprint { get; set; }

        public int Level { get; set; }

        public string Overide { get; set; }
    }
}
