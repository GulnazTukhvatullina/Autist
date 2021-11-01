using System;
using System.Collections.ObjectModel;
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
using System.Net;

namespace Tukhvatullina
{
    /// <summary>
    /// Логика взаимодействия для Page1_author.xaml
    /// </summary>
    public partial class Page1_author : Page
    {
        public Page1_author()
        {
            InitializeComponent();
        }

        private void autho_event_click(object sender, RoutedEventArgs e)
        {
            var z = bd_connections.connection.Avtorization.Where(a => a.Login == txt_login.Text && a.Password == txt_password.Password).FirstOrDefault();
            
            if (z != null)
            {
                NavigationService.Navigate(new page_home());
            }
            else
            {
                MessageBox.Show("логин или пароль не верные", "error", MessageBoxButton.OK,MessageBoxImage.Error);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new page_reg());
        }
    }
}
