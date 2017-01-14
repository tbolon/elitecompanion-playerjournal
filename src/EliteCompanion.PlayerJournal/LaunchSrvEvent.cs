namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When deploying the SRV from a ship onto planet surface.
    /// </summary>
    /// <seealso cref="DockSrvEvent"/>
    public class LaunchSrvEvent : BaseEvent
    {
        public string Loadout { get; set; }
    }
}
