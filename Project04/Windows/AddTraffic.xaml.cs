using Project04.Windows;
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
using System.Windows.Shapes;

namespace Project04
{
    /// <summary>
    /// Логика взаимодействия для AddTraffic.xaml
    /// </summary>
    public partial class AddTraffic : Window
    {
        public AddTraffic()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Traffic.AddTraffic(TBtype.Text, DateTime.Parse(TBstartDate.Text) , DateTime.Parse(TBendDate.Text), double.Parse(TBdistance.Text), TBdistanceName.Text, int.Parse(TBsiteCount.Text), double.Parse(TBticketPrice.Text), int.Parse(TBticketCount.Text));
            //MainWindow main = new MainWindow();
            //main.Show();
            //Close();
       
        }
    }
}
