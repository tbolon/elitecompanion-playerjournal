namespace EliteCompanion.PlayerJournal
{
    public interface IHasStarSystemInfo : IHasStarSystem
    {
        double[] StarPos { get; set; }

        string SystemAllegiance { get; set; }

        string SystemEconomy { get; set; }

        string SystemGovernment { get; set; }

        string SystemSecurity { get; set; }
    }
}
