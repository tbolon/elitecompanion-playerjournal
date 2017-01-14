namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When hull health drops below a threshold (20% steps).
    /// </summary>
    public class HullDamageEvent : BaseEvent
    {
        public float Health { get; set; }

        /// <summary>
        /// true if player is piloting the ship/fighter taking damage.
        /// </summary>
        public bool PlayerPilot { get; set; }

        /// <summary>
        /// true for ship-launched fighter.
        /// </summary>
        public bool Fighter { get; set; }

    }
}
