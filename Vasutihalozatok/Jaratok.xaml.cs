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
        public Jaratok()
        {
            InitializeComponent();

            List<Jaratok> jarat = new List<Jaratok>();


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

                reader.Close();
              //  j.kiindulo_varos =


            }


        }
    }
}
