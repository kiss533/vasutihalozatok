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
using Vasutihalozatok.Auth;
using Vasutihalozatok.Controller;
// using admin;
using Vasutihalozatok.Execptions;



namespace Vasutihalozatok
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        private IAuthenticator b;

        private Datatextcontent datatextcontent = Datatextcontent.Instance;
        public Login()
        {
            InitializeComponent();

          


            // jart.IsVisible = false;
        }
        private LoginController loginController = new LoginController();

        private void btn_testDb_Click(object sender, RoutedEventArgs e)
        {
              
            /*
            try
            {
              
               var user = loginController.HandleLoginAttempt(felhasznalonev.Text, jelszo.Password);
              
                
                
                Jaratok railwayPicker = new Jaratok();
                railwayPicker.Left = this.Left;
                railwayPicker.Top = this.Top;
                Jaratok.GetWindow(railwayPicker).Show();
                this.Close();


                
            }
            /*
            catch (VasutExecption exc)
            {
                MessageBox.Show(exc.Message, "Sikertelen bejelentkezés",
                    MessageBoxButton.OK, MessageBoxImage.Error
                    );
            } 
            */
        }
        /*
        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Left = this.Left;
            registerWindow.Top = this.Top;
            RegisterWindow.GetWindow(registerWindow).Show();
            this.Close();
            Jaratok J = new Jaratok();

            J.Show();
            
        }

        */




        private void regisgomb_Click(object sender, RoutedEventArgs e)
        {

            Register reg = new Register();
            reg.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

       //  varosletrehozas let = 


        }

        private void Rendezes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();

            win.Show();
        }


        string[] elerhetoseg = new string[] { "user", "admin" };

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            


        }
    }
}
