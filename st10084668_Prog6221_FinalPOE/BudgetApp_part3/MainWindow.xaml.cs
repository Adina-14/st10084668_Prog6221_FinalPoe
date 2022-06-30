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

namespace BudgetApp_part3
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

        private void tbStart_MouseMove(object sender, MouseEventArgs e)
        {
            //changes the foreground of the button when the mouse is over it
            btnStart.Foreground = Brushes.Green;

        }

        private void btnStart_MouseLeave(object sender, MouseEventArgs e)
        {
            //changes the foreground of the button when the mouse is not over it
            btnStart.Foreground = Brushes.White;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            //moving to next form/Window Finance
           Finance f = new Finance();
            this.Hide();//Hiding this window
            f.Show();//show finance window
            
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //Exiting application
            Application.Current.Shutdown();
        }
    }
}
