   M S B A M L   `   `   `  ����H  DLR_2_Shatilov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LR_2_Shatilov.PagesLR_2_Shatilov.Pages  5      /    )LR_2_Shatilov.Pages.AddEditAttendancePage   5      0
syncfusion!http://schemas.syncfusion.com/wpf  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:LR_2_Shatilov.Pages     5        N� Title$  AddEditAttendancePage��5
       N� FontSize$ 16(�6%   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   �� $��ФИО клиента��6   $��Center=�6'   $��Right=�6B   $��0��6^   $��5q�6k   �� 5   
   $��ФИО работника��6   $��Center=�6)   $��Right=�6D   $��1��6`   $��5q�6m   �� 5   
   $!��Дата посещения��6   $��Center=�6*   $��Right=�6E   $��2��6a   $��5q�6n   �� 5   
   $��Статус��6   $��Center=�6"   $��Right=�6=   $��3��6Y   $��5q�6f   �� 5   
   $��Примечание��6   $��Center=�6&   $��Right=�6A   $��4��6]   $��5q�6j   �� 5   
   -   5        $��	ClientCmb��5      $��1��6$   $��0��64   $��10q�6A    �� DisplayMemberPath$ ClientSurname��6n    �� SelectedItem 6M   �� *	Clients+6n   �� 5   
   -   5        $��EmployeeCmb��5      $��1��6&   $��1��66   $��10q�6C   $ EmployeeSurname��6r    6O   �� *	Employees+6r   (  "System.Windows.Controls.DatePicker  5    
   $��1��6   $��2��6%   $��10q�62      SelectedDate 6>   �� *AttendanceDateTime+�� 5!   
   -   5         ��Name$ 	StatusCmb��5!      $��3��6&   $��1��63   $��10q�6C   6O   �� 5"   
   $��1��6   $��4��6"   $��10q�6/   ��6;   �� *Note+�� 5#   
   -   5         ��Name$ SaveBtn��5#      $��2��6"   $��5��66      mainBtn#��[  6C   	 �� 	IsDefault	 . $��Сохранить��6u   6�   5$      5%      