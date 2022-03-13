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
using Vasutihalozatok.Entity;


namespace admin
{
    /// <summary>
    /// Interaction logic for varosletrehozas.xaml
    /// </summary>
    public partial class varosletrehozas : Window
    {
        public varosletrehozas()
        {
            InitializeComponent();
        }
        private Datatextcontent datatextcontent = Datatextcontent.Instance;
        private void Varos_letrehozasa_Click(object sender, RoutedEventArgs e)
        {
                City cities = new City()
            {
                  varos =   letrehoz.Text 

            };

            datatextcontent.Add(cities);
            datatextcontent.SaveChanges();
        }
    }
}
