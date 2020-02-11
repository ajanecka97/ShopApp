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

using ShopCore;
using ShopCore.Data;

namespace ShopApp.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy CartPage.xaml
    /// </summary>
    public partial class CartPage : Page
    {
        private Cart _cart;
        private User _currentUser;
        public CartPage(Cart cart, User user)
        {
            InitializeComponent();
            List<ProductData> products = new List<ProductData>();
            Dictionary<string, ProductData> productsDictionary = new Dictionary<string, ProductData>();
            this._cart = cart;
            this._currentUser = user;
            foreach (var product in _cart.Products)
            {
                if (productsDictionary.ContainsKey(product.Name))
                {
                    productsDictionary[product.Name].Amount = productsDictionary[product.Name].Amount + 1;
                }
                else
                {
                    ProductData productData = new ProductData(
                        product.Name,
                        product.Description,
                        product.Price,
                        1
                        );
                    productsDictionary.Add(product.Name, productData);
                }
            }
            this.ProductsDataGrid.DataContext = productsDictionary.Values;
            this.TotalValueLabel.Content = "Total value: " + CalculateValue(productsDictionary.Values);
        }

        private double CalculateValue(ICollection<ProductData> products)
        {
            double value = 0;
            foreach (var product in products)
            {
                value += product.Price * product.Amount;
            }
            return value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PaymentPage(_currentUser));
        }
    }
}
