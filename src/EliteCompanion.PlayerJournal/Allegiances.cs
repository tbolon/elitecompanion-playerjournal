using System;

namespace EliteCompanion.PlayerJournal
{
    public static class Allegiances
    {
        public static Allegiance Parse(string value)
        {
            var result = Allegiance.Unknown;
            Enum.TryParse(value, true, out result);
            return result;
        }
    }
}
