using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vasutihalozatok.Entity
{
    class Datatextcontent : DbContext
    {



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {





         //   modelBuilder.Entity<City>().HasOne(x => x.varos).WithMany(x => x.a);

            modelBuilder.Entity<Jaratok>().HasOne(x => x.kiidnulo_varos).WithMany(x => x.osszjarat);
          //  modelBuilder.Entity<Jaratok>().HasOne(x => x.megerkezo_varos).WithMany(x => x.osszjarat);
        }



        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {

            dbContextOptionsBuilder.UseSqlServer("Data Source=LAPTOP-5P62571S\\SQLEXPRESS;" +
                                                        "Initial Catalog=jaratok;" +
                                                       "Integrated Security=SSPI;");
        }



    }
}
