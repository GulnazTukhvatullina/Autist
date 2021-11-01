using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для page_home.xaml
    /// </summary>
    public partial class page_home : Page
    {
        public static ObservableCollection<Artist> art { get; set; }
        public static ObservableCollection<string> names { get; set; }
        public static ObservableCollection<Painting_artist> paint { get; set; }
        public page_home()
        {
            InitializeComponent();
            art = new ObservableCollection<Artist>(Tukhvatullina.bd_connections.connection.Artist.ToList());
            names = new ObservableCollection<string>();
            foreach(Artist artist in art)
            {
                names.Add($"{artist.Surname} {artist.Name} {artist.Middle_name}");
            }

            this.DataContext = this;
        }

        private void name_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as Artist;
        }

        private void info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            paint = new ObservableCollection<Painting_artist>(Tukhvatullina.bd_connections.connection.Painting_artist.ToList());
        }
    }
}
