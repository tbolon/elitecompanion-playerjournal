namespace EliteCompanion.PlayerJournal
{
    public class ReceiveTextEvent : BaseEvent
    {
        public string From { get; set; }

        public string Message { get; set; }

        public string Channel { get; set; }
    }
}