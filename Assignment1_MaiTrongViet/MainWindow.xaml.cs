using GUI;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment1_MaiTrongViet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICosmeticService cosmeticService = null;

        public MainWindow()
        {
            InitializeComponent();
            cosmeticService = new CosmeticService();
            Load_Combobox();
            
        }



        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                dtg_Cosmetics.ItemsSource = cosmeticService.GetCosmetics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong!!!");
            }
        }
        //Refresh
        private void Refresh()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDes.Text = "";
            txtPrice.Text = "";
            txtQuality.Text = "";
            CategoryID.SelectedIndex = 0;

            btn_Create.IsEnabled = true;
            btn_Update.IsEnabled = false;
            btn_Delete.IsEnabled = false;
            txtID.IsEnabled = true;
        }
        

        private void Load_Combobox()
        {
            var listCategory = cosmeticService.GetCategories().Select(eachRow => new
            {
                eachRow.CategoryId,
                eachRow.CategoryName
            }).ToList();
            CategoryID.ItemsSource = listCategory;
            CategoryID.DisplayMemberPath = "CategoryName";
            CategoryID.SelectedValuePath = "CategoryId";
            CategoryID.SelectedIndex = 0;
        }

        private void CategoryID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        

        private void dtg_Cosmetics_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cosmetic selectedCosmetic = dtg_Cosmetics.SelectedItem as Cosmetic;
            //Gán kiểu data thành Cosmetics(as ...)

            if (selectedCosmetic != null)
            {
                txtID.Text = selectedCosmetic.CosmeticId;
                txtName.Text = selectedCosmetic.CosmeticName;
                txtDes.Text = selectedCosmetic?.Description;
                txtPrice.Text = selectedCosmetic.Price.ToString();
                txtQuality.Text = selectedCosmetic.Quality.ToString();
                CategoryID.SelectedValue = selectedCosmetic?.CategoryId;
                txtID.IsEnabled = false;
                btn_Create.IsEnabled = false;
                btn_Update.IsEnabled = true;
                btn_Delete.IsEnabled = true;
            }
            
        }

        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            
            var updatedCosmetic = cosmeticService.GetCosmetic(txtID.Text);
            updatedCosmetic.CosmeticName = txtName.Text;
            updatedCosmetic.Description = txtDes.Text;
            updatedCosmetic.Price = int.Parse(txtPrice.Text);
            updatedCosmetic.CategoryId = CategoryID.SelectedValue.ToString();

            bool result = cosmeticService.UpdateCosmetic(updatedCosmetic);

            if (result)
            {
                MessageBox.Show("Update product successfully");
                dtg_Cosmetics.ItemsSource = cosmeticService.GetCosmetics();
                Refresh();
            }
            else
            {
                MessageBox.Show("Update product failed");
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            
            Cosmetic cosmetic = new Cosmetic();
            cosmetic.CosmeticId = txtID.Text;
            
            cosmetic.CosmeticName = txtName.Text;
            cosmetic.Description = txtDes.Text;
            cosmetic.Price = int.Parse(txtPrice.Text);
            cosmetic.Quality = int.Parse(txtQuality.Text);
            cosmetic.CategoryId = CategoryID.SelectedValue.ToString();

            bool isSuccess = cosmeticService.AddCosmetic(cosmetic);
            if (isSuccess)
            {
                MessageBox.Show("Thêm thành công mỹ phẩm");
                dtg_Cosmetics.ItemsSource = cosmeticService.GetCosmetics();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {
            var cosmeticId = txtID.Text;
            var cosmetic = cosmeticService.GetCosmetic(cosmeticId);
            bool result = cosmeticService.DeleteCosmetic(cosmetic);

            if (result)
            {
                MessageBox.Show("Delete product successfully");
                dtg_Cosmetics.ItemsSource = cosmeticService.GetCosmetics();
                Refresh();
            }
            else
            {
                MessageBox.Show("Delete product failed");
            }
        }

        private void btn_Refresh_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dtg_Cosmetics.ItemsSource = cosmeticService.GetCosmetics();
            }
            else
            {
                dtg_Cosmetics.ItemsSource = cosmeticService.GetCosmetics().Where(eachRow => eachRow.CosmeticName.ToLower().Contains(txtSearch.Text.ToLower()));
            }
        }

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void logout_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            WelcomeWindow welcomeWindow = new WelcomeWindow();
            welcomeWindow.Show();
        }

        private void btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            WelcomeWindow welcomeWindow = new WelcomeWindow();
            welcomeWindow.Show();
        }
    }
}
