namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When claiming payment for combat bounties and bonds.
    /// </summary>
    public class RedeemVoucherEvent : BaseEvent
    {
        /// <summary>
        /// Type of voucher. eg. "bounty".
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Net amount received, after any broker fee.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Broker percentage, if redeemed through a broker.
        /// </summary>
        public float BrokerPercentage { get; set; }
    }
}
