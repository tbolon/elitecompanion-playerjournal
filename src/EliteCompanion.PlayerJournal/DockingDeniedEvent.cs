namespace EliteCompanion.PlayerJournal
{
    public class DockingDeniedEvent : BaseEvent, IHasStationName
    {
        public string StationName { get; set; }

        /// <summary>
        /// Reason for denial.
        /// </summary>
        /// <remarks>
        /// Reasons include: NoSpace, TooLarge, Hostile, Offences, Distance, ActiveFighter, NoReason.
        /// </remarks>
        public string Reason { get; set; }
    }
}
