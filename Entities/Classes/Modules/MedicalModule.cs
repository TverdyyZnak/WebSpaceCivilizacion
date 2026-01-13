using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes.Moduls
{
    public class MedicalModule : Module
    {
        public List<Hero> heroList = new List<Hero>();
        public int herosMaxCount = 4;
        public int time = 120; //В секундах

        public MedicalModule(string name, string desc, int lvl = 1)
        {
            id = Guid.NewGuid();
            this.name = name;
            description = desc;
            this.lvl = lvl;
        }
    
        public void TreatHeros()
        {
            foreach (var hero in heroList) 
            {
                hero.TakeHelp(lvl * 5);
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
