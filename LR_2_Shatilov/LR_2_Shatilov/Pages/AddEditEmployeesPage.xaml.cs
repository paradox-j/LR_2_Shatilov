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
    /// Логика взаимодействия для AddEditEmployeesPage.xaml
    /// </summary>
    public partial class AddEditEmployeesPage : Page
    {
        //Добавляемый/изменяемый объект
        Employees employee;
        public AddEditEmployeesPage(Employees employee)
        {
            InitializeComponent();
            //Проверка добавляется элемент или изменяется
            if (employee == null)
            {
                //Создание нового объекта
                employee = new Employees() { EmployeeGender = "м" };
                //Добавление объекта в таблицу
                ConDB.Context.Employees.Add(employee);
            }
            //Привязка передаваемого объекта к контексту и объекту добавлений/изменения
            DataContext = this.employee = employee;
            //Заполнение combobox данными
            EmployeeSexCmb.ItemsSource = "м,ж".Split(',');
            //Присвоение combobox значения свойства объекта
            EmployeeSexCmb.Text = employee.EmployeeGender;
        }

        //Присвоение значения свойству объекта при смене выбираемого элемента в combobox
        private void EmployeeSexCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            employee.EmployeeGender = EmployeeSexCmb.SelectedValue.ToString();
        }

        //Кнопка сохранения
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            //Проверка являются ли все символы телефона числами
            if (!employee.EmployeePhone.All(char.IsDigit))
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
    }
}
