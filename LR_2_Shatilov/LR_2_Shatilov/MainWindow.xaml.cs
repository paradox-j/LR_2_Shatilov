using LR_2_Shatilov.AppData;
using LR_2_Shatilov.Pages;
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

namespace LR_2_Shatilov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Привязка объекта навигации к фрейму 
            Nav.MainFrame = MainFrame;
            //Установка стартовой страницы
            Nav.Navigate(new MainPage());
        }

        //Управление видимостью кнопки Назад
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            BackBtn.Visibility = MainFrame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }

        //Возврат на предыдущую страницу
        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if(MainFrame.CanGoBack) MainFrame.GoBack();
        }
    }
}
