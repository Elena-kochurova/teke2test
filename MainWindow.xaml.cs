using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using teke2test.StrTele2;



namespace teke2test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Str1());
        }
        private void ButtonBase_OnCliсk(object sender , RoutedEventArgs e)
        {
            Window2 window2 = new Window2(); // Создаём объект классна 2ой страницы
            window2.Show(); // Приминяем к нему метод который показывает этот объект

            

        }

        private void MainWindow_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
