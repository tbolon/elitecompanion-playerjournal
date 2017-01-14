using System.Collections.Generic;

namespace EliteCompanion.PlayerJournal
{
    public class EngineerCraftEvent:BaseEvent
    {
        public string Engineer { get; set; }

        public string Blueprint { get; set; }

        public int Level { get; set; }

        public Dictionary<string, int> Ingredients { get; set; }
    }
}
