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

namespace _26_12_2022_WPF_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> list = new List<string>() {"Красный", "Зеленый","Синий" };
        public MainWindow()
        {
            InitializeComponent();
            foreach (var item in list)
            {
                Listbox1.Items.Add(item);
                ComboBox1.Items.Add(item);
                TreeView1.Items.Add(item);
            }
            
        }
    }
}
