using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasutihalozatok.Entity
{
    public class Jaratok : Azon
    {
        public City kiidnulo_varos { get; set; }
        public City megerkezo_varos { get; set; }
        public int Tavolsag { get; set; }
       
    //    public virtual ICollection<City> allomasok { get; set; }

    }
}
