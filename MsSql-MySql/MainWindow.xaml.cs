using MsSql_MySql.Data;
using MsSql_MySql.ViewModels;
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

namespace MsSql_MySql
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MsSqlReader _msReader;
        private readonly MySqlReader _myReader;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();

            _msReader = new MsSqlReader(this);
            _myReader = new MySqlReader(this);
        }

        private async void Button_MsSQL(object sender, RoutedEventArgs e)
        {
            await _msReader.ReadComuni();
        }

        private async void Button_MySQL(object sender, RoutedEventArgs e)
        {
            await _myReader.ReadComuni();
        }
    }
}
