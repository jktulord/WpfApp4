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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Uri Add_page = new Uri("Pages/Add_page.xaml", UriKind.Relative);
        private Uri View_page = new Uri("Pages/View_page.xaml", UriKind.Relative);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_page_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = Add_page;
        }

        private void View_page_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Source = View_page;
        }
    }
}
