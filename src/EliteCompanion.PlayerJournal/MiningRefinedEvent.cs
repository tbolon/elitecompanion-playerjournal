using System;
using System.Collections.Generic;
using System.Text;

namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When mining fragments are converted unto a unit of cargo by refinery.
    /// </summary>
    public class MiningRefinedEvent : BaseEvent
    {
        public string CargoType { get; set; }
    }
}
