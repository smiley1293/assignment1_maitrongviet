using Assignment1_MaiTrongViet;
using ShopBO.Models;
using ShopDAO;
using ShopSERVICE;
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

namespace GUI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly ICosmeticService cosmeticService = null;
        public LoginWindow()
        {
            InitializeComponent();
            cosmeticService = new CosmeticService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            var email = txt_Email.Text;
            var password = txt_Password.Text;

            
            Account user = cosmeticService.Login(email, password);

            if(user == null)
            {
                MessageBox.Show("Email or Password is incorrect !!!");
            }
            else
            {
                if(user.RoleId == 1)
                {
                    this.Close();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }else if (user.RoleId == 2)
                {
                    this.Close();
                    MainWindowStaff mainWindowStaff = new MainWindowStaff();
                    mainWindowStaff.Show();
                }
                else
                {
                    MessageBox.Show("You have no permission to access!!!");
                }
            }
        }

        private void MyTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
