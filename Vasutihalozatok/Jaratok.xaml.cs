using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.IO;
using Vasutihalozatok.Entity;



namespace Vasutihalozatok
{
    /// <summary>
    /// Interaction logic for Jaratok.xaml
    /// </summary>
    public partial class Jaratok : Window
    {

        private Datatextcontent datatextcontent = Datatextcontent.Instance;
        public Jaratok()
        {
           

        InitializeComponent();

            List<Entity.Jaratok> jarat = new List<Entity.Jaratok>();


            StreamReader reader = new StreamReader("railways.txt");

            while(!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] soradatok = sor.Split(';');

               City kiindul = new  City();

                kiindul.varos = soradatok[0];


                City megerkez = new City();

                megerkez.varos = soradatok[1];


                City betolt = new City();

                int tavol = int.Parse(soradatok[2]);

                Entity.Jaratok j = new Entity.Jaratok();

                j.kiidnulo_varos = kiindul;
                j.megerkezo_varos = megerkez;
                j.Tavolsag = tavol;

                //  j.kiindulo_varos =
                jarat.Add(j);
                datatextcontent.Jaratok.Add(j);
               
                datatextcontent.SaveChanges();
                
            }

            reader.Close();
            /*
            var a = jarat.Select(x => x.kiidnulo_varos);               
          //  var b = jarat.Select(x => x.megerkezo_varos).ToList();
           // var c = jarat.Select(x => x.Tavolsag).ToList();
           var jaratas = from item in jarat select $"{item.kiidnulo_varos} \t {item.megerkezo_varos} \t {item.Tavolsag}";

            */



            foreach (var item in jarat)
            {


                //  jarattabla.ItemsSource = kiindulo;


                jarattabla.ItemsSource = jarat;
                             // listak.Text = item.kiidnulo_varos;

                // jarattabla.Columns[0]  = a;

             //  jarat.Select(x => x.kiidnulo_varos).ToList();
              //  jarat.Select(x => x.megerkezo_varos).ToList();

            }


        }
    }
}
