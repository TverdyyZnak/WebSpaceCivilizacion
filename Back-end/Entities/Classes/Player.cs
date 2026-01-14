using Entities.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Player
    {
        public Guid id { get;}
        public string name { get;} = string.Empty;
        public string baseName { get;} = string.Empty;
        public GameFraction gameFraction { get;}
        public int lvl { get; set; } = 1;
        public int xp { get; set; } = 0;
        public int money { get; set; } = 0;

        private Player(Guid id, string name, string baseName, GameFraction gameFraction, int lvl, int xp, int money)
        {
            this.id = id;
            this.name = name;
            this.baseName = baseName;
            this.gameFraction = gameFraction;
            this.lvl = lvl;
            this.xp = xp;
            this.money = money;
        }

        public static (Player? player, string error) CreateNewPlayer(Guid id, string name, string baseName, GameFraction gameFraction, int lvl = 0, int xp = 0, int money = 0)
        {
            string errorMsg = string.Empty;

            if (name.Length > Constants._nameLength || baseName.Length > Constants._baseNameLength) 
            {
                errorMsg += "Text in field is too long; ";
            }

            if(errorMsg.Length != 0)
            {
                return(null, errorMsg);
            }
            else
            {
                return (new Player(id, name, baseName, gameFraction, lvl, xp, money), errorMsg);
            }
        }

        public void AddMoney(int m)
        {
            this.money += m;
        }
    }
}
