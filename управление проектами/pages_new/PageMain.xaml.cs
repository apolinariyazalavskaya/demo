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

namespace управление_проектами.pages_new
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        

        private void tel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("+79324831265");
        }

        private void catalog_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pages_new.PageCatalog());
        }

        private void entrance_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pages_new.PageAvtoriz());
        }
    }
}
