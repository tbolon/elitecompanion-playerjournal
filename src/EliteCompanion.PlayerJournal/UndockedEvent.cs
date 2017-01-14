namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When liftoff from a landing pad in a station, outpost or settlement.
    /// </summary>
    public class UndockedEvent : BaseEvent, IHasStationName
    {
        public string StationName { get; set; }
    }
}
