using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes.Moduls
{
    public class EnergyModule : Module
    {
        public List<Hero> heroList = new List<Hero>();
        public int horosMaxCount = 4;
        public int times = 60; // В секундах

        public EnergyModule(string name, string desc, int lvl = 1)
        {
            id = Guid.NewGuid();
            this.name = name;
            description = desc;
            this.lvl = lvl;
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
