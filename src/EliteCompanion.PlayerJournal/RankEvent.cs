namespace EliteCompanion.PlayerJournal
{
    /// <summary>
    /// When you start the game, contains rank informations.
    /// </summary>
    public class RankEvent : BaseEvent
    {
        /// <summary>
        /// Current Combat rank on scale 0-8.
        /// </summary>
        /// <remarks>
        /// 0='Harmless', 1='Mostly Harmless', 2='Novice', 3='Competent', 4='Expert', 5='Master', 6='Dangerous', 7='Deadly', 8='Elite'
        /// </remarks>
        public int Combat { get; set; }

        /// <summary>
        /// Current Trade rank on scale 0-8.
        /// </summary>
        /// <remarks>
        /// 0='Penniless', 1='Mostly Pennliess', 2='Peddler', 3='Dealer', 4='Merchant', 5='Broker', 6='Entrepreneur', 7='Tycoon', 8='Elite'
        /// </remarks>
        public int Trade { get; set; }

        /// <summary>
        /// Current Explore rank on scale 0-8.
        /// </summary>
        /// <remarks>
        /// 0='Aimless', 1='Mostly Aimless', 2='Scout', 3='Surveyor', 4='Explorer', 5='Pathfinder', 6='Ranger', 7='Pioneer', 8='Elite'
        /// </remarks>
        public int Explore { get; set; }

        /// <summary>
        /// Current Empire military rank.
        /// </summary>
        /// <remarks>
        /// 0='None', 1='Outsider', 2='Serf', 3='Master', 4='Squire', 5='Knight', 6='Lord', 7='Baron',  8='Viscount ', 9='Count', 10= 'Earl', 11='Marquis' 12='Duke', 13='Prince', 14='King'
        /// </remarks>
        public int Empire { get; set; }

        /// <summary>
        /// Current Federation military rank.
        /// </summary>
        /// <remarks>
        /// 0='None', 1='Recruit', 2='Cadet', 3='Midshipman', 4='Petty Officer', 5='Chief Petty Officer', 6='Warrant Officer', 7='Ensign', 8='Lieutenant',
        /// 9='Lt. Commander', 10='Post Commander', 11= 'Post Captain', 12= 'Rear Admiral', 13='Vice Admiral', 14='Admiral'
        /// </remarks>
        public int Federation { get; set; }

        /// <summary>
        /// Current CQC rank on scale 0-8.
        /// </summary>
        /// <remarks>
        /// 0='Helpless', 1='Mostly Helpless', 2='Amateur', 3='Semi Professional', 4='Professional', 5='Champion', 6='Hero', 7='Legend', 8='Elite'
        /// </remarks>
        public int CQC { get; set; }
    }
}
