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

namespace Tukhvatullina
{
    /// <summary>
    /// Логика взаимодействия для page_reg.xaml
    /// </summary>
    public partial class page_reg : Page
    {
        public page_reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = new Avtorization();
            a.Name = name_txt.Text;
            a.Login = login_txt.Text;
            a.Password = txt_password.Password;
            bd_connections.connection.Avtorization.Add(a);
            bd_connections.connection.SaveChanges();
            var v = bd_connections.connection.Avtorization.Where(z => z.Name == name_txt.Text && z.Login == login_txt.Text && z.Password == txt_password.Password).FirstOrDefault();
            if (v != null)
            {
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Заполните все данные");
            }
        }

        private void TextBlock_MouseDown(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            NavigationService.Navigate(new Page1_author());

        }
    }
}
