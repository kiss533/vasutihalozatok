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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vasutihalozatok.Entity;
using System.IO;


namespace Vasutihalozatok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
 {

        private Datatextcontent datatextcontent = Datatextcontent.Instance;

        public MainWindow()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("cities.txt");
            List<City> varosok = new List<City>();
            while (!reader.EndOfStream)
            {
                string sor = reader.ReadLine();
                string[] soradatok = sor.Split(' ');

             //   City kiindul = new City();

             //   kiindul.varos = sor;

                
                City megerkez = new City();

                megerkez.varos = soradatok[0];

                
                /*
                City betolt = new City();

                int tavol = int.Parse(soradatok[2]);

                Entity.Jaratok j = new Entity.Jaratok();

                j.kiidnulo_varos = kiindul;
                j.megerkezo_varos = megerkez;
                j.Tavolsag = tavol;

                //  j.kiindulo_varos =
                jarat.Add(j);
                */

                varosok.Add(megerkez);
                datatextcontent.Varosok.Add(megerkez);
            //    datatextcontent.SaveChanges();

            }

            reader.Close();

            

            foreach (var item in varosok)
            {
                indulo.ItemsSource = varosok.Select(x => x.varos).ToList();


                cel.ItemsSource = varosok.Select(x => x.varos).ToList();


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Jaratok j = new Jaratok();

            j.Show();

        }
    }
}
