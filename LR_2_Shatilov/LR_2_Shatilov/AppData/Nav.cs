using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LR_2_Shatilov.AppData
{
    //Класс навигации для перехода по страницам в главном окне
    internal class Nav
    {
        //Объект для связи по ссылке с элементом Frame в главном окне
        internal static Frame MainFrame;
        //Метод для перехода между страницами
        internal static void Navigate(Page page)
        {
            MainFrame.Navigate(page);
        }
        //Метод для перехода между страницами
        internal static void Back()
        {
            MainFrame.GoBack();
        }
    }

    //Дополнение к классам для изменения отображения телефонных номеров
    public partial class Clients
    {
        public string ClientPhoneFormatted { get { return Convert.ToInt64(ClientPhone).ToString("+7(###)###-##-##"); } }
    }
    public partial class Employees
    {
        public string EmployeePhoneFormatted { get { return Convert.ToInt64(EmployeePhone).ToString("+7(###)###-##-##"); } }
    }
}
