   M S B A M L   `   `   `  ����D  @WpfApp777, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WpfApp777	WpfApp777  5   	       WpfApp777.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WpfApp777     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �  � ShowGridLines .  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      �� 5      $��50 �6     � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      .+�5      �� $��./img/rabZheka.jpg��5      $��2��5      �� 5       �� Orientation$ Vertical=�5   	   $��3��5   	   $��Bottom=�5   	   .+�5      �� -   5         ��Name$ 
ExitButton��5      $��
Выход��5       $��50��5"      5#      &   System.Windows.Controls.DataGrid  5$      $��1��5%      $��1��5&         CanUserAddRows .     AutoGenerateColumns .  ��5)      �� *
WorkerList+   Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Имя��5,      1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5-      �� *Name+  5.      $	 Возраст��5/      
 50      �� *Age+  51      $	 Зарплата��52      
 53      �� *Salary+  54      $(	 "Дата начала работы��55      
 56      �� *BeginningWork+  57      $	 Должность��58      
 59      �� *
Position+5;      � 5<       � Orientation$ 
Horizontal=�5=   	   $��1��5>   	   $��50��5?   	   5A      � 5B      $��1��6   .+�5C      �� $��Должности:��5D      $��Center=�5E      �� 5G      -   5        $��BreedFilterComboBox��5H      $��Center=�5I      $	��100��5J       �� SelectedIndex$ 0��5K      ��5L      �� *WorkerPositionList+��5N      �� 5O      .R�5P      �� ��5Q      �� *Title+5R      5T      �� 5U      $��искать��5V      $��Center=�5W      �� 5X      -   5         ��Name$ SearchFilterTextBox��5[      $	��200��5Y      $��Center=�5Z      5\      �� 5]      $��Возраст:��5^      $��Center=�5_      	� 5`      -   5         	� 	GroupName$	 Age��5a      
 � Tag$ 1��5b      $!��по возрастанию��5c       d� 	IsChecked$
 TrueY�5d      $��Center=�5f      	� 5g      -   5        $	 Age��5h      $ 2��5i      $��по убыванию��5j      $��Center=�5l      5m      5n      5o      5p      