using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class AccountData
    {
        public string id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string phonenum { get; set; }
        public string email { get; set; }
    }
}
