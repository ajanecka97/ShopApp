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
    /// Logika interakcji dla klasy PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        private User _currentUser;
        public PaymentPage(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(nameTB.Text != "" && surnameTB.Text != "" && addressTB.Text != "" && cityTB.Text != "" && zipTB.Text != "")
            {
                BasePayment payment = new BasePayment(nameTB.Text, surnameTB.Text, addressTB.Text, cityTB.Text, zipTB.Text);
                payment.InsertIntoDatabase(_currentUser.Id);
                this.NavigationService.Navigate(new ProductsPage(_currentUser));
            }
        }
    }
}
