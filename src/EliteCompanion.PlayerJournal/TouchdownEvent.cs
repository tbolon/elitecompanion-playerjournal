namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When landing on a planet surface.
    /// </summary>
    /// <seealso cref="LiftoffEvent"/>
    public class TouchdownEvent : BaseEvent
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
