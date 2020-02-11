using ShopCore;
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

namespace ShopApp.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        private User _currentUser;
        public AddProductPage(User user)
        {
            InitializeComponent();
            this._currentUser = user;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            if(nameTB.Text != "" && priceTB.Text != "" && amountTB.Text != "")
            {
                String name = nameTB.Text;
                int price = Int32.Parse(priceTB.Text);
                int ampuntAvailable = Int32.Parse(amountTB.Text);
                String description = descriptionTB.Text;

                Product newProduct = new Product(name, price, ampuntAvailable, description);

                newProduct.InsertIntoDatabase();

                if ((bool)cat1CB.IsChecked)
                {
                    newProduct.AddCategory(1);
                }
                if ((bool)cat2CB.IsChecked)
                {
                    newProduct.AddCategory(2);
                }
                if ((bool)cat3CB.IsChecked)
                {
                    newProduct.AddCategory(3);
                }
                if ((bool)cat4CB.IsChecked)
                {
                    newProduct.AddCategory(4);
                }

                this.NavigationService.Navigate(new EditProducts(_currentUser));
            }
        }
    }
}
