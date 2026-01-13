using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Inventory
    {
        public Guid PlayerId { get;}
        public List<Item> Items = new List<Item>();

        public Inventory(Guid id)
        {
             PlayerId = id;
        }

        public void AddItem(Item item) 
        {
            Items.Add(item);
        }
        public void RemoveItem(Item item) 
        {
            Items.Remove(item);
        }

        public int ItemsCount()
        {
            return Items.Count;
        }
    }
}
