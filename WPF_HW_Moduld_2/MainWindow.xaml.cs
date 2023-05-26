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

namespace WPF_HW_Moduld_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string email = "azekaggg@gmail.com";
        string calendar = DateTime.Now.ToString();
        string case1 = "Погладить кота.";
        string case2 = "Поесть пельмени.";


        string journal = "Челси сдул Манчестеру 4-1 =(";
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = email;
        }

        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = calendar;
        }

        private void btnCase_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = case1;
            txtBox.Text += "\n"+case2;
        }

        private void btnJournal_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = journal;
        }

        private void btnOtherPost_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = email;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
