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

namespace U1_04_CareersBradley
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() 
        {
           
            InitializeComponent();
            txtBasicInfo.Visibility = System.Windows.Visibility.Hidden;
            txtPre.Visibility = System.Windows.Visibility.Hidden;
            btnJobs.Visibility = System.Windows.Visibility.Hidden;
            txtfirst.Visibility = System.Windows.Visibility.Hidden;
            txtjobs.Visibility = System.Windows.Visibility.Hidden;

            
            
            
            
        }

        private void btnBasic_Click(object sender, RoutedEventArgs e)
                    
        {
         guelphhumberlogo.Visibility = System.Windows.Visibility.Visible;
            btnfirst.Visibility = System.Windows.Visibility.Hidden;
            btnpre.Visibility = System.Windows.Visibility.Hidden;
            txtBasicInfo.Visibility = System.Windows.Visibility.Visible;
            txtPre.Visibility = System.Windows.Visibility.Hidden;
            btnJobs.Visibility = System.Windows.Visibility.Hidden;
            txtfirst.Visibility = System.Windows.Visibility.Hidden;
            txtjobs.Visibility = System.Windows.Visibility.Hidden;



        }

        private void btnpre_Click(object sender, RoutedEventArgs e)
        {
            guelphhumberlogo.Visibility = System.Windows.Visibility.Visible;
            btnfirst.Visibility = System.Windows.Visibility.Hidden;
            btnbasic.Visibility = System.Windows.Visibility.Hidden;
            txtBasicInfo.Visibility = System.Windows.Visibility.Hidden;
            txtPre.Visibility = System.Windows.Visibility.Visible;
            btnJobs.Visibility = System.Windows.Visibility.Hidden;
            txtfirst.Visibility = System.Windows.Visibility.Hidden;
            txtjobs.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnfirst_Click(object sender, RoutedEventArgs e)
        {
            guelphhumberlogo.Visibility = System.Windows.Visibility.Visible;
            btnpre.Visibility = System.Windows.Visibility.Hidden;
            btnbasic.Visibility = System.Windows.Visibility.Hidden;
            txtBasicInfo.Visibility = System.Windows.Visibility.Hidden;
            txtPre.Visibility = System.Windows.Visibility.Hidden;
            btnJobs.Visibility = System.Windows.Visibility.Visible;
            txtfirst.Visibility = System.Windows.Visibility.Visible;
            txtjobs.Visibility = System.Windows.Visibility.Hidden;
        }

        private void btnJobs_Click(object sender, RoutedEventArgs e)
        {
            guelphhumberlogo.Visibility = System.Windows.Visibility.Visible;
            txtfirst.Visibility = System.Windows.Visibility.Hidden;
            txtjobs.Visibility = System.Windows.Visibility.Visible;
             btnpre.Visibility = System.Windows.Visibility.Hidden;
            btnbasic.Visibility = System.Windows.Visibility.Hidden;
            txtBasicInfo.Visibility = System.Windows.Visibility.Hidden;

        }

        private void btnres_Click(object sender, RoutedEventArgs e)
        {
            guelphhumberlogo.Visibility = System.Windows.Visibility.Visible;
            btnbasic.Visibility = System.Windows.Visibility.Visible;
            btnfirst.Visibility = System.Windows.Visibility.Visible;
            btnJobs.Visibility = System.Windows.Visibility.Visible;
            btnpre.Visibility = System.Windows.Visibility.Visible;
            txtBasicInfo.Visibility = System.Windows.Visibility.Hidden;
            txtfirst.Visibility = System.Windows.Visibility.Hidden;
            txtjobs.Visibility = System.Windows.Visibility.Hidden;
            txtPre.Visibility = System.Windows.Visibility.Hidden;
            
        }
    }
}
