using System;
using System.Collections.Generic;
using System.Text;

namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When a mission is completed.
    /// </summary>
    public class MissionCompletedEvent : BaseEvent
    {
        public string Name { get; set; }

        public string Faction { get; set; }

        public int MissionID { get; set; }

        public string DestinationSystem { get; set; }

        public string DestinationStation { get; set; }

        public int Reward { get; set; }

        public string Commodity { get; set; }

        public int Count { get; set; }

        public string Target { get; set; }

        public string TargetType { get; set; }

        public string TargetFaction { get; set; }

        public int Donation { get; set; }

        public string[] PermitsAwarded { get; set; }

        public ItemCount[] CommodityReward { get; set; }
    }
}