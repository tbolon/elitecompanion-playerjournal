namespace EliteCompanion.PlayerJournal
{
    public class EjectCargoEvent : BaseEvent
    {
        /// <summary>
        /// Cargo type.
        /// </summary>
        public string Type { get; set; }

        public int Count { get; set; }

        public bool Abandoned { get; set; }

        /// <summary>
        /// Origin star system, if the cargo is related to powerplay delivery from outlying systems back to the centre.
        /// </summary>
        public string PowerplayOrigin { get; set; }
    }
}
