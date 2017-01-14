namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When taking off from planet surface.
    /// </summary>
    /// <seealso cref="TouchdownEvent"/>
    public class LiftoffEvent : BaseEvent
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
