using System;
using System.Collections.Generic;
using System.Text;

namespace EliteCompanion.PlayerJournal
{
    public class ScreenshotEvent : BaseEvent, IHasStarSystem
    {
        public string Filename { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string System { get; set; }

        public string Body { get; set; }

        string IHasStarSystem.StarSystem
        {
            get { return this.System; }
            set { this.System = value; }
        }
    }
}
