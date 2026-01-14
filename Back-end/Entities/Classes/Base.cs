using Entities.Classes.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Base
    {
        public Guid id { get; }
        public Guid playerId { get;}
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public List<Hero> heroList = new List<Hero>();
        public List<Module> moduleList = new List<Module>();

        private Base(Guid playerId, string name, string desc)
        {
            id = Guid.NewGuid();
            this.playerId = playerId;
            this.name = name;
            description = desc;
        }

        public static (Base? basePlayer, string error) CreateNewBase(Guid playerId, string name, string desc)
        {
            string errorMsg = string.Empty;

            if (name.Length > Constants._nameLength) 
            {
                errorMsg += "Text in fields is too long; ";
            }
            if(errorMsg.Length != 0)
            {
                return (null, errorMsg);
            }
            else
            {
                return (new Base(playerId, name, desc), errorMsg);
            }
        }
    }
}
