using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDbContext.DbEntity
{
    public class UserEntity
    {
        public Guid id { get; set; }
        public string login { get; set; } = string.Empty;
        public string hPassword { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public bool isAdmin { get; set; }
    }
}
