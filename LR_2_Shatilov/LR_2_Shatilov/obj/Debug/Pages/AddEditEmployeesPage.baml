   M S B A M L   `   `   `  ����H  DLR_2_Shatilov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LR_2_Shatilov.PagesLR_2_Shatilov.Pages  5      .    (LR_2_Shatilov.Pages.AddEditEmployeesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:LR_2_Shatilov.Pages     5        N� Title$  AddEditEmployeesPage��5	       N� FontSize$ 16(�6$   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Фамилия��6   $��Center=�6#   $��Right=�6>   $��0��6Z   $��5q�6g   �� 5   
   $��Имя��6   $��Center=�6   $��Right=�6:   $��1��6V   $��5q�6c   �� 5   
   $��Отчество��6   $��Center=�6$   $��Right=�6?   $��2��6[   $��5q�6h   �� 5   
   $��Пол��6   $��Center=�6   $��Right=�6:   $��3��6V   $��5q�6c   �� 5   
   $��Телефон��6   $��Center=�6#   $��Right=�6>   $��4��6Z   $��5q�6g   �� 5   
   $��Email��6   $��Center=�6!   $��Right=�6<   $��5��6X   $��5q�6e   �� 5   
   $��1��6   $��0��6"   $��10q�6/   ��6;   �� *EmployeeSurname+�� 5    
   $��1��6   $��1��6"   $��10q�6/   ��6;   �� *EmployeeName+�� 5!   
   $��1��6   $��2��6"   $��10q�6/   ��6;   �� *EmployeePatronymic+�� 5"   
   -   5         ��Name$ EmployeeSexCmb��5"      $��3��6+   $��1��68   $��10q�6H   6T   �� 5#   
   $��1��6   $��4��6"   $��10q�6/   ��6;   �� *EmployeePhone+�� 5$   
   $��1��6   $��5��6"   $��10q�6/   ��6;   �� *EmployeeEmail+�� 5%   
   -   5         ��Name$ SaveBtn��5%      $��2��6"   $��6��66      mainBtn#��[  6C    �� 	IsDefault . $��Сохранить��6u   6�   5&      5'      