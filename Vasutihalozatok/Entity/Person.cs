using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasutihalozatok.Entity
{
    public class Person : Azon
    {
        public string nev { get; set; }
        enum allas { user, admin };
        public string email { get; set; }
        public string felhasznalonev { get; set; }
        public string jelszo { get; set; }
        
    }
}
