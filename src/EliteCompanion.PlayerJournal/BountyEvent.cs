namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When the player is awarded a bounty for a kill.
    /// </summary>
    public class BountyEvent : BaseEvent
    {
        /// <summary>
        /// An array of Faction names and the Reward values, as the target can have multiple bounties payable by different factions.
        /// </summary>
        public BountyReward[] Rewards { get; set; }

        public string Target { get; set; }

        public int TotalReward { get; set; }

        public string VictimFaction { get; set; }

        /// <summary>
        /// If credit for the kill is shared with other players, this has the number of other players involved.
        /// </summary>
        public int SharedWithOthers { get; set; }
    }
}
