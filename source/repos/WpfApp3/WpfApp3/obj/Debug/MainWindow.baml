   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ShowGridLines .  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      .+�5   
   �� $��./Img/log.png��5      $��2��5      �� 5   
    �� Orientation$ Vertical=�5   	   $��3��5   	   $��Bottom=�5   	   .+�5      �� -   5         ��Name$ 
ExitButton��5      $��
Выход��5      $��50��5!      5"      � 5$   
    � Orientation$ 
Horizontal=�5%   	   $��1��5&   	   $��50��5'   	   5(      &   System.Windows.Controls.DataGrid  5)   
   $��1��5*         CanUserAddRows .     AutoGenerateColumns .  $��1��5-   (   ��6   �� *	BuyerList+	   Columns	 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Имя��50      1  +System.Windows.Controls.DataGridBoundColumn   Binding 51      �� *Name+  52      $
 Возраст��53       54      �� *Age+  55      $
 Дата покупки��56       57      �� *	DateBuy+  58      $
 Сумма покупки��59       5:      �� *SumBuy+  5;      $'
 !Статус покупателя��5<       5=      �� *Type+5@      � 5A   
   $��1��6   .+�5B      �� $��	Виды:��5C      $��Center=�5D      �� 5G      -   5        $��NameFilterComboBox��5H      $��Center=�5J      $	��100��5K       �� SelectedIndex$ 0��5L      ��5M      �� *BuyerSearchList+��5O      �� 5P      .R�5Q      �� ��5R      �� *Title+5S      5U      �� 5V      $��искать��5W      $��Center=�5X      �� 5Y      -   5         ��Name$ SearchFilterTextBox��5\      $	��200��5Z      $��Center=�5[      5]      �� 5^      $��Возраст:��5_      $��Center=�5`      	� 5a      -   5         	� 	GroupName$	 Age��5b      
 � Tag$ 1��5c      $!��по возрастанию��5d       d� 	IsChecked$
 TrueY�5e      $��Center=�5g      	� 5h      -   5        $	 Age��5i      $ 2��5j      $��по убыванию��5k      $��Center=�5m      5n      5o      5p      