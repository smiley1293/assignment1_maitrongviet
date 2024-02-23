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
    /// Interaction logic for MainWindowStaff.xaml
    /// </summary>
    public partial class MainWindowStaff : Window
    {
        private readonly ICosmeticService cosmeticService = null;

        public MainWindowStaff()
        {
            InitializeComponent();
            cosmeticService = new CosmeticService();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dtg_Cosmetic_Staff.ItemsSource = cosmeticService.GetCosmetics();
            }
            else
            {
                dtg_Cosmetic_Staff.ItemsSource = cosmeticService.GetCosmetics().Where(eachRow => eachRow.CosmeticName.ToLower().Contains(txtSearch.Text.ToLower()));
            }
        }

        private void dtg_Cosmetic_Staff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dtg_Cosmetic_Staff_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dtg_Cosmetic_Staff.ItemsSource = cosmeticService.GetCosmetics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong!!!");
            }
        }
    }
}
