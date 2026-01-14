using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Classes
{
    public class Item
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
