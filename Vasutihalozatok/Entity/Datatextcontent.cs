using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vasutihalozatok.Entity
{
    public class Datatextcontent : DbContext
    {
        private static Datatextcontent datatextcontent;

        public static Datatextcontent Instance
        {
            get
            {
                if (datatextcontent == null)
                {
                    datatextcontent = new Datatextcontent();
                }
                return datatextcontent;
            }
        }
        public DbSet<City> Varosok { get; set; }
        public DbSet<Jaratok> Jaratok { get; set; }

        public DbSet<Person> Felhasznalok { get; set; }

        private Datatextcontent()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {

            dbContextOptionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=vasuthalozat;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }



    }
}
