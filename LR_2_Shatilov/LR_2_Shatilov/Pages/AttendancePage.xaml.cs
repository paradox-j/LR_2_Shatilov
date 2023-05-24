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
    /// Логика взаимодействия для AttendancePage.xaml
    /// </summary>
    public partial class AttendancePage : Page
    {
        public AttendancePage()
        {
            InitializeComponent();
        }

        //Метод заполнения datagrid данными
        void UpdateDG()
        {
            var attendances = ConDB.Context.Attendance.ToList();
            AttendancesDG.ItemsSource = attendances;
        }

        //Переход на страницу изменения выбранной записи
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new AddEditAttendancePage((sender as Button).DataContext as Attendance));
        }

        //Переход на страницу добавления нового элемента таблицы
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.Navigate(new AddEditAttendancePage(null));
        }

        //Удаление выбранных в datagrid элементов
        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            //Выборка коллекции удаляемых объектов
            var delAttendances = AttendancesDG.SelectedItems.Cast<Attendance>().ToList();
            //Предупреждение об удалении
            if (MessageBox.Show($"Удалить {delAttendances.Count} записей?", "Предупреждение!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    //Удаление коллекции элементов
                    ConDB.Context.Attendance.RemoveRange(delAttendances);
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

        //Обновление привязки datagrid при загрузке страницы
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateDG();
        }
    }
}
