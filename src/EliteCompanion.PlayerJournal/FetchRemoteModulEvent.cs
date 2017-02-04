using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EliteCompanion.PlayerJournal
{
    public class FetchRemoteModulEvent : BaseEvent
    {
        public int StorageSlot { get; set; }

        public string StoredItem { get; set; }

        public int ServerId { get; set; }

        public int TransferCost { get; set; }

        public string Ship { get; set; }

        [JsonProperty("ShipID")]
        public int ShipId { get; set; }
    }
}
