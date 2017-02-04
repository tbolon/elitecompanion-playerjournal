namespace EliteCompanion.PlayerJournal
{
    public class PayFinesEvent : BaseEvent
    {
        public int Amount { get; set; }

        public float BrokerPercentage { get; set; }
    }
}
