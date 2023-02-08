using Microsoft.EntityFrameworkCore.Internal;
using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace teke2test
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
           
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();// Обращаюс к обекту класса (window2) из которого вызыван этот метод,Закрываю это окно тк "передумала" в водить код. и остаётся предыдущий экран
        }


        private void ButtonVerification_Click(object sender, RoutedEventArgs e)// что делает 2ая кнопка
        {
            StreamReader reader = new StreamReader(AppContext.BaseDirectory+"Promo.txt");
            string[] promos = reader.ReadToEnd().Replace("\r","").Split('\n');
            int a = promos.IndexOf(promoTextBox.Text);
            if ( a>=0 )
            {
                //System.Timers.Timer aTimer;
                //aTimer = new System.Timers.Timer(2000);

                Window4 window4 = new Window4();  
                window4.Show();
                Thread.Sleep(2000);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();


                //MainWindow mainWindow = new MainWindow();
                //mainWindow.Show();

                //Thread.Sleep(2000);

            }
            else 
           {
               Window3 window3 = new Window3();
               window3.Show();
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
        
        private void openMainWindow()
        {
            Thread.Sleep(2000);
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

           
        }
        private void promoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
