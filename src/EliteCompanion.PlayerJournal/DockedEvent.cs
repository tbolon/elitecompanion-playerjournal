namespace EliteCompanion.PlayerJournal
{
    public class DockedEvent : BaseEvent
    {
        public string StationName { get; set; }

        public string StationType { get; set; }

        public string StarSystem { get; set; }

        public string StationFaction { get; set; }

        public string FactionState { get; set; }

        public string StationGovernment { get; set; }

        public string StationAllegiance { get; set; }

        public string StationEconomy { get; set ;}
    }
}