using Entities.Classes.Moduls;
using Entities.Enams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes.Modules
{
    public class BusterModule : Module
    {
        public List<Hero> heroList = new List<Hero>();
        public int heroMaxCount = 2;
        public int time = 240; //В СЕКУНДАХ ПОТОМ ПОМЕНЯЯЯЯЙ
        public CharTypes charType;

        public BusterModule(string name, string desc, CharTypes charTypes, int lvl = 1)
        {
            id = Guid.NewGuid();
            this.name = name;
            description = desc;
            charType = charTypes;
            this.lvl = lvl;
        }
        
        public void UpHeroStat()
        {
            foreach (var hero in heroList) 
            {
                switch (charType)
                {
                    case CharTypes.strong:
                        
                        if(hero.strong < Constants._maxCountOfStats)
                        {
                            hero.strong++;
                        }
                        
                        break;
                    case CharTypes.agility:

                        if (hero.agility < Constants._maxCountOfStats)
                        {
                            hero.agility++;
                        }

                        break;
                    case CharTypes.intelect:

                        if (hero.intelect < Constants._maxCountOfStats)
                        {
                            hero.intelect++;
                        }

                        break;
                    case CharTypes.charisma:

                        if (hero.charisma < Constants._maxCountOfStats)
                        {
                            hero.charisma++;
                        }

                        break;
                }
            }
        }

        public void AddHero(Hero hero)
        {
            heroList.Add(hero);
            hero.inModule = true;
        }
        public void RemoveHero(Hero hero)
        {
            heroList.Remove(hero);
            hero.inModule = false;
        }
    }
}
