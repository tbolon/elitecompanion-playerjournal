namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When a text message is sent to another player.
    /// </summary>
    /// <seealso cref="ReceiveTextEvent"/>
    public class SendTextEvent : BaseEvent
    {
        public string To { get; set; }

        public string Message { get; set; }
    }
}
