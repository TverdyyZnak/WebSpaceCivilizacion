using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Hero
    {
        public Guid id { get;}
        public string name { get;} = string.Empty;
        public int maxHp { get; } = 100;
        public int currentHp { get; set; }
        public int strong { get; set; } = 1;
        public int agility { get; set; } = 1;
        public int intelect { get; set; } = 1;
        public int charisma { get; set; } = 1;
        
        public bool isAlive = true; // Живой или мёртвый
        public bool inModule = false;
        public Armor? armor { get; set; }
        public Weapon? weapon { get; set; }


        private Hero(string name, int maxHp = 100, int strong = 1, int agility = 1, int intelect = 1, int charisma = 1)
        {
            Guid id = Guid.NewGuid();
            this.name = name;
            this.maxHp = maxHp;
            this.currentHp = maxHp;
            this.strong = strong;
            this.agility = agility;
            this.intelect = intelect;
            this.charisma = charisma;
        }

        public static (Hero? hero, string error) CreateNewHero(string name, int strong = 1, int agility = 1, int intelect = 1, int charisma = 1)
        {
            string errorMsg = string.Empty;

            if(name.Length > Constants._nameLength)
            {
                errorMsg += "Name length is too long; ";
            }

            if(strong > Constants._maxCountOfStats ||  agility > Constants._maxCountOfStats || intelect > Constants._maxCountOfStats || charisma > Constants._maxCountOfStats)
            {
                errorMsg += "Hero Stats are more them stats in rules; ";
            }

            if (errorMsg.Length != 0)
            {
                return (null, errorMsg);
            }
            return (new Hero(name, strong, agility, intelect, charisma), errorMsg);
        }

        public void GiveArmor(Armor armor)
        {
            this.armor = armor;
        }

        public void RemoveArmore()
        {
            armor = null;
        }

        public void GiveWeapon(Weapon weapon) 
        {
            this.weapon = weapon;
        }

        public void RemoveWeapon()
        {
            weapon = null;
        }

        public void TakeDmg(int dmg)
        {
            currentHp -= dmg;
            if (currentHp < 0) 
            { 
                currentHp = 0;
                isAlive = false;
            }
        }

        public void TakeHelp(int hp)
        {
            isAlive = true;
            currentHp += hp;
            if (currentHp > maxHp)
            {
                currentHp = maxHp;
            }
        }
    }
}
