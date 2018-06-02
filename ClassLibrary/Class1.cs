using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
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
        //idplayer
        public double PlayerID { get; set; }
        /// <summary>
        /// ur best hero
        public string SignatureHero { get; set; }
        /// <summary>
        /// Win/Lose Ratio
        public double WinRate { get; set; }
        /// <summary>
        /// PositionInGame
        public List<Currency> PrimaryRole { get; set; }
        /// <summary>
        /// SoloMMR
        public Rating SoloRating { get; set; }
        /// <summary>
        //Stars in solo rank
        public int RateStars { get; set; }
        /// <summary>
        /// 
        public SmthAboutPlayer()
        {


        }
    }
    public class ActivitiesClass //отдельная база
    {
        public int id { get; set; }
        public string name { get; set; }
    }
    public enum Currency
    {
        MidLane,
        HardLane,
        Roam,
        Support,
        Carry
    }
    public enum Rating
    {
        Herald,
        Guardian,
        Crusader,
        Archon,
        Legend,
        Ancient,
        Divine
    }
}



