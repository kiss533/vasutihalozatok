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

namespace user
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void beallitas()
        {
            string password = Console.ReadLine();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            Console.WriteLine(hashedPassword);
            Console.WriteLine("Login");
            string loginPassword = Console.ReadLine();
            Console.WriteLine("A bírt jelszó egyezik? " + BCrypt.Net.BCrypt.Verify(loginPassword, hashedPassword));
        }

    }
}


