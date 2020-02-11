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
using ShopCore.Utility;

using ShopCore.Data;

namespace ShopApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private System.Collections.Generic.List<User> _usersAvailable;

        public LoginPage()
        {
            InitializeComponent();

            _usersAvailable = new System.Collections.Generic.List<User>();

            User admin = new User(1, "admin", "admin", "aa 123", new DateTime(1997, 12, 3), "admin@abc.com", "pass");
            admin.AddEligibility(Eligibility.manageCategories);
            admin.AddEligibility(Eligibility.manageProducts);

            _usersAvailable.Add(new User(2, "user1", "cba", "a/b 123", new DateTime(1998, 4, 12), "u1@a1.com", "p1"));
            _usersAvailable.Add(new User(3, "user2", "aqa", "a/b 113", new DateTime(2000, 1, 15), "u2@a1.com", "p2"));
            _usersAvailable.Add(admin);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserUtilities.VerifyEmail(this.EmailInput.Text))
            {
                bool found = false;
                foreach (var user in _usersAvailable)
                {
                    if (user.Email.Equals(this.EmailInput.Text) && UserUtilities.Verify(this.PasswordInput.Password, user.Password))
                    {
                        found = true;
                        this.NavigationService.Navigate(new ProductsPage(user));
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Nie ma takiego użytkownika");
                }
            }
            else
            {
                MessageBox.Show("Podany email jest nieprawidłowy");
            }
        }
    }
}
