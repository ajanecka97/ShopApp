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
    /// Logika interakcji dla klasy EditProducts.xaml
    /// </summary>
    public partial class EditProducts : Page
    {
        private User _currentUser;
        public EditProducts(User user)
        {
            InitializeComponent();
            this.ProductsDataGrid.DataContext = Product.LoadFromDatabase();
            _currentUser = user;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddProductPage(_currentUser));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ProductsPage(_currentUser));
        }
    }
}
