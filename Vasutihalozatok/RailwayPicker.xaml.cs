using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Vasutihalozatok.Controller;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vasutihalozatok
{
    /// <summary>
    /// Interaction logic for RailwayPicker.xaml
    /// </summary>
    public partial class RailwayPicker : Window
    {
        public RailwayPicker()
        {
            InitializeComponent();
            railwayPickerController.SubscibeToLogout(UserAuthenticator_LogoutEvent);
        }

            

            private RaliwayPackerController railwayPickerController = new RaliwayPackerController();
       

        private void UserAuthenticator_LogoutEvent()
        {
            Login loginWindow = new Login();
            loginWindow.Left = this.Left;
            loginWindow.Top = this.Top;
            Login.GetWindow(loginWindow).Show();
            railwayPickerController.UnsubscribeFromLogout(UserAuthenticator_LogoutEvent);
            this.Close();
        }
        /*
        public RailwayPicker(string userRealName) : this()
        {
            la_title.Content += " " + userRealName;
        }
        */
        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            railwayPickerController.Logout();
        }
    }
    

}
 
