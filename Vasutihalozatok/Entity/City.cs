using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasutihalozatok.Entity
{
    class City : Azon
    {
        public string varos { get; set; }

        public virtual ICollection<Jaratok> osszjarat { get; set; }
    }
}
