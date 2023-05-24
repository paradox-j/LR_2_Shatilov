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
    /// Логика взаимодействия для AddEditClientsPage.xaml
    /// </summary>
    public partial class AddEditClientsPage : Page
    {
        //Добавляемый/изменяемый объект
        Clients client;
        public AddEditClientsPage(Clients client)
        {
            InitializeComponent();
            //Проверка добавляется элемент или изменяется
            if (client == null) 
            { 
                //Создание нового объекта
                client = new Clients() { ClientGender = "м" };
                //Добавление объекта в таблицу
                ConDB.Context.Clients.Add(client);
            }
            //Привязка передаваемого объекта к контексту и объекту добавлений/изменения
            DataContext = this.client = client;
            //Заполнение combobox данными
            ClientSexCmb.ItemsSource = "м,ж".Split(',');
            //Присвоение combobox значения свойства объекта
            ClientSexCmb.Text = client.ClientGender;
        }

        //Кнопка сохранения
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //Проверка являются ли все символы телефона числами
            if (!client.ClientPhone.All(char.IsDigit))
            {
                MessageBox.Show("Телефон состоит только из цифр");
                return;
            }
            //Обработка исключения при ошибке
            try
            {
                //Сохранение изменений в базе данных
                ConDB.Context.SaveChanges();
                //Возврат на предыдущую страницу
                Nav.Back();
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения");
            }
        }

        //Присвоение значения свойству объекта при смене выбираемого элемента в combobox
        private void ClientSexCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            client.ClientGender = ClientSexCmb.SelectedValue.ToString();
        }
    }
}
