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
    /// Логика взаимодействия для ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
        }

        //Метод заполнения datagrid данными
        public void UpdateDG()
        {
            var clients = ConDB.Context.Clients.ToList();
            ClientsDG.ItemsSource = clients;
        }

        //Переход на страницу добавления нового элемента таблицы
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new AddEditClientsPage(null));
        }

        //Удаление выбранных в datagrid элементов
        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            //Выборка коллекции удаляемых объектов
            var delClients = ClientsDG.SelectedItems.Cast<Clients>().ToList();
            //Предупреждение об удалении
            if (MessageBox.Show($"Удалить {delClients.Count} записей?", "Предупреждение!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                //Цикл перебора коллекции
                foreach (var client in delClients)
                {
                    //Проверка сущесвтованя данных в зависимой таблице
                    if (ConDB.Context.Attendance.Any(x => x.ClientID == client.ClientID))
                    {
                        MessageBox.Show("Невозможно удалить записи, они используются в другой таблице");
                        return;
                    }
                }
                try
                {
                    //Удаление коллекции элементов
                    ConDB.Context.Clients.RemoveRange(delClients);
                    //Сохранение изменений
                    ConDB.Context.SaveChanges();
                }
                catch 
                {
                    MessageBox.Show("Ошибка удаления");
                }
            }
            UpdateDG();
        }

        //Переход на страницу изменения выбранной записи
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new AddEditClientsPage((sender as Button).DataContext as Clients));
        }

        //Обновление привязки datagrid при загрузке страницы
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateDG();

        }
    }
}
