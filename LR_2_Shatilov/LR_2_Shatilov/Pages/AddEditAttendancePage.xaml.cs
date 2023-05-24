using LR_2_Shatilov.AppData;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для AddEditAttendancePage.xaml
    /// </summary>
    public partial class AddEditAttendancePage : Page
    {
        //Добавляемый/изменяемый объект
        Attendance attendance;
        public AddEditAttendancePage(Attendance attendance)
        {
            InitializeComponent();
            //Заполнение combobox данными
            ClientCmb.ItemsSource = ConDB.Context.Clients.ToList();
            //Заполнение combobox данными
            EmployeeCmb.ItemsSource = ConDB.Context.Employees.ToList();
            //Проверка добавляется элемент или изменяется
            if (attendance == null)
            {
                //Создание нового объекта
                attendance = new Attendance() { AttendanceDateTime = DateTime.Now };
                //Добавление объекта в таблицу
                ConDB.Context.Attendance.Add(attendance);
            }
            //Привязка передаваемого объекта к контексту и объекту добавлений/изменения
            DataContext =  this.attendance = attendance;
            //Заполнение combobox данными
            StatusCmb.ItemsSource = "Перенесено,Посещено,Пропущено,Отменено".Split(',');
            //Присвоение combobox значения свойства объекта
            StatusCmb.Text = attendance.Status;
            
        }

        //Кнопка сохранения
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
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
        private void StatusCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            attendance.Status = StatusCmb.SelectedValue.ToString();
        }
    }
}
