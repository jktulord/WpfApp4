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
using WpfApp4.Models;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Логика взаимодействия для Add_page.xaml
    /// </summary>
    public partial class Add_page : Page
    {
        private Random rnd;
        public Add_page()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Person new_person = RandGeneration();
            BinarySerialization.WriteToBinaryFile<Person>("C:/Users/186173.KIP/source/repos/WpfApp4/WpfApp4/data.bin", new_person);
        }
        private Person RandGeneration()
        {
            Person new_person = new Person() { 
                Name = "Randy" + rnd.Next(1, 1000),
                Str= rnd.Next(1, 100),
                Agi= rnd.Next(1, 100),
                Int= rnd.Next(1, 100),
                Wis=rnd.Next(1, 100) 
            };
            return new_person;
        }
    }
}
