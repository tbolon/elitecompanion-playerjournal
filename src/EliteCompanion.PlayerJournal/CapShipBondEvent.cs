namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When the player has been rewarded for a capital ship combat.
    /// </summary>
    public class CapShipBondEvent : BaseEvent
    {
        public int Reward { get; set; }

        public string AwardingFaction { get; set; }

        public string VictimFaction { get; set; }
    }
}
