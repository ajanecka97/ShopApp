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
using System.Data.SQLite;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ShopCore;
using ShopApp.Pages;
using ShopCore.Data;

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        private Cart _cart;
        private Product _currentProduct;
        private Category _currentCategory;
        private User _currentUser;
        public ProductsPage(User currentUser)
        {
            InitializeComponent();
            _cart = new Cart();
            _currentCategory = null;
            _currentProduct = null;
            _currentUser = currentUser;


            List<Category> categories = Category.LoadListFromDatabase();


            categories[0].LoadProductsFromCategory(1);
            categories[1].LoadProductsFromCategory(2);
            categories[2].LoadProductsFromCategory(3);
            categories[3].LoadProductsFromCategory(4);

            //this.treeView.SelectedItemChanged += CategorySelected;
            foreach (var category in categories)
            {
                TreeViewItem cat = new TreeViewItem();
                cat.Header = category.Name;
                //cat.Selected += CategorySelected;
                cat.Resources["Category"] = category;
                this.treeView.Items.Add(cat);
                foreach (Product product in category.Products)
                {
                    TreeViewItem prod = new TreeViewItem();
                    prod.Header = product.Name;
                    prod.Selected += ProductSelected;
                    prod.Resources["Product"] = product;
                    cat.Items.Add(prod);
                }
            }

            foreach (Eligibility eligibility in _currentUser.Eligibility)
            {
                if(eligibility == Eligibility.manageProducts)
                {
                    this.EditProductsPanelButton.IsEnabled = true;
                }
            }
        }

        private void ProductSelected(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = sender as TreeViewItem;

            _currentProduct = item.Resources["Product"] as Product;

            this.NameLabel.Content = _currentProduct.Name;
            this.PriceLabel.Content = "Cena: " + _currentProduct.Price;
            this.DescriptionLabel.Content = "Opis: " + _currentProduct.Description;
        }
        private void CategorySelected(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = sender as TreeViewItem;

            _currentCategory = item.Resources["Category"] as Category;

            this.NameLabel.Content = _currentCategory.Name;
            this.PriceLabel.Content = "";
            this.DescriptionLabel.Content = _currentCategory.Description;
        }

        private void AddToCartButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentProduct != null &&_currentProduct.AmountAvailable > 0)
            {
                _cart.AddProduct(this._currentProduct);
                _cart.NumberOfProducts++;
                _currentProduct.AmountAvailable--;
                this.ProductsInCartLabel.Content = _cart.NumberOfProducts;
            }

        }

        private void CartButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CartPage(this._cart, _currentUser));
        }

        private void EditProductsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new EditProducts(_currentUser));
        }
    }
}
