using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace teke2test.StrTele2
{
    /// <summary>
    /// Логика взаимодействия для Str2.xaml
    /// </summary>
    public partial class Str2 : Page
    {
        public Str2()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack(); /*переход на предыдущию страницу*/
        }

        private void ButtonVerification_Click(object sender, RoutedEventArgs e)
        {
            

            StreamReader reader = new StreamReader(AppContext.BaseDirectory + "Promo.txt");
            string[] promos = reader.ReadToEnd().Replace("\r", "").Split('\n');
            int a = promos.IndexOf(promoTextBox.Text);
            if (a >= 0)
            {
                //System.Timers.Timer aTimer;
                //aTimer = new System.Timers.Timer(2000);

                this.NavigationService.Navigate(new Str4());
               


                //MainWindow mainWindow = new MainWindow();
                //mainWindow.Show();

                //Thread.Sleep(2000);

            }
            else
            {
                this.NavigationService.Navigate(new Str3());
            }

            //MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=tele2_promo_code;"); //создаём объект для работы с базой данных
            //connection.Open();// открыть соединение
            //MySqlCommand command = connection.CreateCommand(); // создаю объект команды для соединеня кторое открыто выше
            //command.CommandText = $"select * from promo_code where promo = '{promoTextBox.Text}'"; //$- задала текс запроса для обекта command
            //int count = command.ExecuteNonQuery(); // запрос в БД и вернёт число строк
            //if (count > 0)
            //{
            //    Window4 window4 = new Window4();
            //    window4.Show();
            //}
            //else
            //{
            //    Window3 window3 = new Window3();
            //    window3.Show();
            //}
        }

        private void promoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }
    }
}
