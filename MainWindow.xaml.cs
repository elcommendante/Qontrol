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

namespace Qontrol
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

        private void BtnClickMainPage(object sender, RoutedEventArgs e)
        {
            Main.Content = new MainPage();
        }

        private void BtnClickPageTasks(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageTasks();
        }

        private void BtnClickPageCalculator(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageCalculator();
        }

        private void BtnClickPageNotes(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageNotes();
        }

        private void BtnClickPageCalendar(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageCalendar();
        }

        private void BtnClickExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnClickMaximize(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            
        }

        private void BtnClickMinimize(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
