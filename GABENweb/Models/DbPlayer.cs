using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ClassLibrary;

namespace GABENweb.Models
{
    public class DbPlayer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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
        public virtual Collection<DbCurrency> PrimaryRole { get; set; }
        /// <summary>
        /// SoloMMR
        public Rating SoloRating { get; set; }
        /// <summary>
        //Stars in solo rank
        public int RateStars { get; set; }
    }

    public class DbCurrency
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Currency Role { get; set; }
    }
}