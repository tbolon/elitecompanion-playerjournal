﻿namespace EliteCompanion.PlayerJournal
{
    public class RankEvent : BaseEvent
    {
        public int Combat { get; set; }

        public int Trade { get; set; }

        public int Explore { get; set; }

        public int Empire { get; set; }

        public int Federation { get; set; }

        public int CQC { get; set; }
    }
}
