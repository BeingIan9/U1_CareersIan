//*Ian Markham
//March 5
//University Program
//Learn about the computer science program
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

namespace U1_CareersIan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnprogram_Click(object sender, RoutedEventArgs e)
        {
            imgcampus.Visibility = System.Windows.Visibility.Visible;
            txtprogram.Visibility = System.Windows.Visibility.Visible;
            imgprerequisite.Visibility = System.Windows.Visibility.Hidden;
            txtprerequisite.Visibility = System.Windows.Visibility.Hidden;
            imgcourses.Visibility = System.Windows.Visibility.Hidden;
            txtcourses.Visibility = System.Windows.Visibility.Hidden;
            btnelectric.Visibility = System.Windows.Visibility.Hidden;
            btnsoftware.Visibility = System.Windows.Visibility.Hidden;
            btngame.Visibility = System.Windows.Visibility.Hidden;
            imgelectric.Visibility = System.Windows.Visibility.Hidden;
            txtelectric.Visibility = System.Windows.Visibility.Hidden;
            imgsoftware.Visibility = System.Windows.Visibility.Hidden;
            txtsoftware.Visibility = System.Windows.Visibility.Hidden;
            imggame.Visibility = System.Windows.Visibility.Hidden;
            txtgame.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnprerequisite_Click(object sender, RoutedEventArgs e)
        {
            imgprerequisite.Visibility = System.Windows.Visibility.Visible;
            txtprerequisite.Visibility = System.Windows.Visibility.Visible;
            imgcampus.Visibility = System.Windows.Visibility.Hidden;
            txtprogram.Visibility = System.Windows.Visibility.Hidden;
            imgcourses.Visibility = System.Windows.Visibility.Hidden;
            txtcourses.Visibility = System.Windows.Visibility.Hidden;
            btnelectric.Visibility = System.Windows.Visibility.Hidden;
            btnsoftware.Visibility = System.Windows.Visibility.Hidden;
            btngame.Visibility = System.Windows.Visibility.Hidden;
            imgelectric.Visibility = System.Windows.Visibility.Hidden;
            txtelectric.Visibility = System.Windows.Visibility.Hidden;
            imgsoftware.Visibility = System.Windows.Visibility.Hidden;
            txtsoftware.Visibility = System.Windows.Visibility.Hidden;
            imggame.Visibility = System.Windows.Visibility.Hidden;
            txtgame.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btncourses_Click(object sender, RoutedEventArgs e)
        {
            imgcourses.Visibility = System.Windows.Visibility.Visible;
            txtcourses.Visibility = System.Windows.Visibility.Visible;
            imgcampus.Visibility = System.Windows.Visibility.Hidden;
            txtprogram.Visibility = System.Windows.Visibility.Hidden;
            imgprerequisite.Visibility = System.Windows.Visibility.Hidden;
            txtprerequisite.Visibility = System.Windows.Visibility.Hidden;
            btnelectric.Visibility = System.Windows.Visibility.Hidden;
            btnsoftware.Visibility = System.Windows.Visibility.Hidden;
            btngame.Visibility = System.Windows.Visibility.Hidden;
            imgelectric.Visibility = System.Windows.Visibility.Hidden;
            txtelectric.Visibility = System.Windows.Visibility.Hidden;
            imgsoftware.Visibility = System.Windows.Visibility.Hidden;
            txtsoftware.Visibility = System.Windows.Visibility.Hidden;
            imggame.Visibility = System.Windows.Visibility.Hidden;
            txtgame.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btncareers_Click(object sender, RoutedEventArgs e)
        {
            btnelectric.Visibility = System.Windows.Visibility.Visible;
            btnsoftware.Visibility = System.Windows.Visibility.Visible;
            btngame.Visibility = System.Windows.Visibility.Visible;
            imgcampus.Visibility = System.Windows.Visibility.Hidden;
            txtprogram.Visibility = System.Windows.Visibility.Hidden;
            imgprerequisite.Visibility = System.Windows.Visibility.Hidden;
            txtprerequisite.Visibility = System.Windows.Visibility.Hidden;
            imgcourses.Visibility = System.Windows.Visibility.Hidden;
            txtcourses.Visibility = System.Windows.Visibility.Hidden;
            imgelectric.Visibility = System.Windows.Visibility.Hidden;
            txtelectric.Visibility = System.Windows.Visibility.Hidden;
            imgsoftware.Visibility = System.Windows.Visibility.Hidden;
            txtsoftware.Visibility = System.Windows.Visibility.Hidden;
            imggame.Visibility = System.Windows.Visibility.Hidden;
            txtgame.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnelectric_Click(object sender, RoutedEventArgs e)
        {
            imgelectric.Visibility = System.Windows.Visibility.Visible;
            txtelectric.Visibility = System.Windows.Visibility.Visible;
            imgsoftware.Visibility = System.Windows.Visibility.Hidden;
            txtsoftware.Visibility = System.Windows.Visibility.Hidden;
            imggame.Visibility = System.Windows.Visibility.Hidden;
            txtgame.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnsoftware_Click(object sender, RoutedEventArgs e)
        {
            imgelectric.Visibility = System.Windows.Visibility.Hidden;
            txtelectric.Visibility = System.Windows.Visibility.Hidden;
            imgsoftware.Visibility = System.Windows.Visibility.Visible;
            txtsoftware.Visibility = System.Windows.Visibility.Visible;
            imggame.Visibility = System.Windows.Visibility.Hidden;
            txtgame.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btngame_Click(object sender, RoutedEventArgs e)
        {
            imgelectric.Visibility = System.Windows.Visibility.Hidden;
            txtelectric.Visibility = System.Windows.Visibility.Hidden;
            imgsoftware.Visibility = System.Windows.Visibility.Hidden;
            txtsoftware.Visibility = System.Windows.Visibility.Hidden;
            imggame.Visibility = System.Windows.Visibility.Visible;
            txtgame.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
