using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace samproject
{
    /// <summary>
    /// Информация о игроке
    /// </summary>
    public class SmthAboutPlayer
    {
        /// <summary>
        /// ФИО игрока
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// NickName
        /// </summary>
        public string NickName { get; set; }
        /// <summary>
        /// SoloMMR
        public double SoloRank { get; set; }
        /// <summary>
        // PartyMMR
        public double PartyRank { get; set; }
        /// <summary>
        //idplayer
        public double PlayerID { get; set; }
        /// <summary>
        /// PositionInGame
        public Currency PrimaryRole { get; set; }
        /// <summary>
        //MaxSolo
        public double MaxSoloRank { get; set; }
        /// <summary>
        /// ur best hero
        public string SigranuteHero { get; set; }
        /// <summary>
        /// Win/Lose Ratio
        public double WinRate { get; set; }
        /// <summary>
        /// 
        public SmthAboutPlayer()
        {
            PlayerID = 0;
            FullName = "";
            NickName = "";

        }
    }
    public class ActivitiesClass //отдельная база
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public enum Currency
    {
        Support,
        Carry,
        HardLane,
        MidLane,
        Roam
    }


}

