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

namespace Vasutihalozatok
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private Datatextcontent datatextcontent = Datatextcontent.Instance;

        public Register()
        {
            InitializeComponent();
        }

        private void btn_testDb_Click(object sender, RoutedEventArgs e)
        {

            
                Person person = new Person()
                {
                    nev = name.Text,
                    jelszo = password.Text
                };

                datatextcontent.Felhasznalok.Add(person);
                datatextcontent.SaveChanges();
            
            
            }
    }
    }

