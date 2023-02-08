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
    /// Логика взаимодействия для Str1.xaml
    /// </summary>
    public partial class Str1 : Page
    {
        public Str1()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnCliсk(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate( new Str2());  /* переход на страницу*/
        }
    }
}
