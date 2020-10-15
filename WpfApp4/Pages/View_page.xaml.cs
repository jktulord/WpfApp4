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
    /// Логика взаимодействия для View_page.xaml
    /// </summary>
    public partial class View_page : Page
    {
        public View_page()
        {
            InitializeComponent();
            Person person = BinarySerialization.ReadFromBinaryFile<Person>("C:/Users/186173.KIP/source/repos/WpfApp4/WpfApp4/data.bin");
            InitPersonItemBox(person);
        }
        public void InitPersonItemBox(Person person)
        {
            ListBoxItem Cur_ItemBox = new ListBoxItem();
            ControlTemplate Temp = (ControlTemplate)FindResource("PersonInfo");
            Cur_ItemBox.Template = Temp;
            
            StackPanel SP1 = (StackPanel)Cur_ItemBox.Template.FindName("grid1", Cur_ItemBox);
            TextBox AgiText = ()SP1.StackPanel.FindName("AgiStr", grid1);
            AgiText.Text = "Agi: " + person.Agi;
            TextBox IntText = (TextBox)Cur_ItemBox.Template.FindName("IntStr", Cur_ItemBox);
            TextBox WisText = (TextBox)Cur_ItemBox.Template.FindName("WisStr", Cur_ItemBox);

            firstlist.Items.Add(Cur_ItemBox);
        }
    }
}
