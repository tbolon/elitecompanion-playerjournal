using System;

namespace EliteCompanion.PlayerJournal
{
    public static class Economies
    {
        private const string prefix = "$economy_";

        public static Economy Parse(string value, Economy defaultValue = Economy.Unknown)
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            if (value.StartsWith(prefix, StringComparison.Ordinal))
            {
                value = value.Substring(prefix.Length).TrimEnd(';');
            }

            if (Enum.TryParse(value, out Economy economy))
            {
                return economy;
            }

            return defaultValue;

        }
    }
}
