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

namespace teke2test.StrTele2
{
    /// <summary>
    /// Логика взаимодействия для Str3.xaml
    /// </summary>
    public partial class Str3 : Page
    {
        public Str3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack(); /*переход на предыдущию страницу*/
        }
    }
}
