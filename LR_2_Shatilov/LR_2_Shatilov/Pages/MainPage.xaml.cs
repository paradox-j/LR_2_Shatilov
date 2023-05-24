using LR_2_Shatilov.AppData;
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

namespace LR_2_Shatilov.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Переход на страницу клиентов
        private void ClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new ClientsPage());
        }
        
        //Переход на страницу сотрудников
        private void EmplBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new EmployeesPage());
        }
        
        //Переход на страницу посещений
        private void AttendanceBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new AttendancePage());
        }
    }
}
