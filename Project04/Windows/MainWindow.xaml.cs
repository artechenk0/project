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

namespace Project04.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListTraffic.ItemsSource = Traffic.traffics;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddTraffic addTraffic = new AddTraffic();
            addTraffic.Show();
            //Close();
        }

        private void BtnEOptimal_Click(object sender, RoutedEventArgs e)
        {
            Optimal optimal = new Optimal();
            optimal.Show();
            Close();
        } 

        private void BtnGraphic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Traffic[] selectedItem = ListTraffic.SelectedItems.Cast<Traffic>().ToArray();
            foreach (Traffic item in selectedItem)
            {
                Traffic.traffics.Remove(item);
            }
        }
    }
}
