   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.addEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  addEmployeeWindow��5	   	   $	��700��6#   $	��430��60    � 	Resources 5
        PLWPF.ImageConverter   ImageConverter��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��530* �6   �� 5      $	��74* �6   .+�5   
   �� -   5         ��Name$ EmployeeTitle��5      $��Add Employee��6'   $��Center=�6?   $��26(�6]   $��105,10,37,10q�6k   $��3��6�   $	��250��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $	��Add��6$   $
��Bold"�62   $��26(�6D   $
��Left=�6R   $��	98,10,0,0q�6m   $��2��6�   $	��Top=�6�   $	��187��6�   $��53��6�   {�.  6�   �� 5   
   -   5        $ Back2Button��5      $
��Back��6&   $��Right=�65   $��
0,37,342,0q�6Q   $��2��6e   $	��Top=�6r   $��65��6�   $��25��6�   � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��	25,20,0,0q�69   $��1��6L   $	��Top=�6Y   $	��510��6q   $	��405��6~    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6    �� 5#      $
��Auto �6    �� 5$      $
��Auto �6    �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6    �� 5,      $
��Auto �6    �� 5-      $
��Auto �6    .+�50      �� $��Address:��6   $��0��6'   $��4��67   $
��Left=�6D   $��3q�6_   $��Center=�6j   �� 51      -   5         ��Name$ addressTextBox��51      $��1��6.   $��4��6>   $
��Left=�6K   $��23��6f   $��3q�6r   $��Center=�6�   $	��120��6�   ��6}   �� *	Address+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   �� 52      $��Date Birth:��6   $��0��6*   $��3��6:   $
��Left=�6G   $��3q�6b   $��Center=�6n   (  "System.Windows.Controls.DatePicker  53      -   5          Name$ dateBirthDatePicker��53      $��1��66   $��3��6F   $
��Left=�6S   $��3q�6n   $��Center=�6�      SelectedDate 6z   �� *	DateBirth+$ TwoWay=�	 . 
 . 6�   �� 54      $��degree Type:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��6��6a   $��Center=�6n   �� 55      -   5         ��Name$ degreeTypeComboBox��55      $��1��63   $
��Left=�6g   $
��Auto��6�   $��3q�6�   $��6��6�   $��Center=�6�   $	��120��6�    �� SelectedItem 6C   �� *
degreeType+56      �� 57      $��Center=�6   $��8��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Specialization:��6r   �� 58      -   5        $ specialComboBox��58      $	��120��60   $��Bottom=�6<   $��8��6�   $��3,0,0,5q�6�   $��23��6�   $
��Left=�6�   $��1��6�    �� Text 6W   �� *	Special+$ TwoWay=�	 . 
 . 6  �� 5:      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��2��6`   $��Center=�6m   �� 5;      -	   5        $ firstNameTextBox��5;      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��2��6r   $��Center=�6�   $	��120��6�   ��6   �� *	FirstName+$ TwoWay=�	 . 
 . 6�   �� 5<      $��Graduate Army:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��7��6c   $��Center=�6p   �� 5=      -
   5         ��Name$ graduateArmyCheckBox��5=      $�� ��65   $��1��6@   $
��Left=�6P   $��7��6k   $��3q�6�   $��Center=�6�    d� 	IsChecked 6x   �� *GraduateArmy+$ TwoWay=�	 . 
 . 6�   �� 5>      $	��Id:��6   $��0��6"   $
��Left=�62   $��3q�6M   $��0��6X   $��Center=�6e   �� 5?      -   5        $ 	idTextBox��5?      $��1��6)   $
��Left=�69   $��23��6T   $��3q�6`   $��0��6k   $��Center=�6�   $	��120��6�   ��6x   �� *Id+$ TwoWay=�	 . 
 . 6�   �� 5@      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��1��6_   $��Center=�6l   �� 5A      -   5        $ lastNameTextBox��5A      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��1��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+$ TwoWay=�	 . 
 . 6�   �� 5B      $��
Phone Num:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��5��6_   $��Center=�6l   �� 5C      -   5        $ phoneNumTextBox��5C      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��5��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
PhoneNum+$ TwoWay=�	 . 
 . 6  � 5D      -   5        $ grid2��5D      $
��Left=�6"   $��	1,3,-16,0q�6=   $��14��6P   $	��Top=�6^   $��2��6v   $	��244��6�    5E      �� 5F      $
��Auto �6'   $��99��64   �� 5G      $
��Auto �6'   $	��130��64    5I      �� 5J      $
��Auto �6$   �� 5K      $
��Auto �6$   �� 5L      $
��Auto �6$   �� 5M      $
��Auto �6$   �� 5N      $
��Auto �6$   �� 5O      $
��Auto �6$   .+�5Q      �� $��Account No:��6   $��0��6.   $
��Left=�6>   $��3,3,0,3q�6Y   $��5��6j   $��Center=�6w   $��26��6�   $��75��6�   �� 5R      -   5        $ accountNoTextBox��5R      $��1��64   $
��Left=�6D   $��24��6_   $��3q�6k   $��5��6v   $��Center=�6�   $	��120��6   {�.  ��6�   �� *	AccountNo+$ TwoWay=�	 . 
 . 67  �� 5S      $��
Bank Name:��6   $��0��6-   $
��Left=�6=   $��3,3,0,3q�6X   $��1��6i   $��Center=�6v   $��26��6�   $��73��6�   �� 5T      -   5        $ bankNameTextBox��5T      $��1��63   $
��Left=�6C   $��24��6^   $��3,4,0,4q�6j   $��1��6{   $��Center=�6�   $	��120��6  {�.  ��6�   �� *
BankName+$ TwoWay=�	 . 
 . 6  �� 5U      $��Bank No:��6   $��0��6+   $
��Left=�6;   $��3,3,0,3q�6V   $��0��6g   $��Center=�6t   $��26��6�   $��58��6�   �� 5V      -   5        $ bankNoTextBox��5V      $��1��62   $
��Left=�6B   $��24��6]   $��3,4,0,4q�6i   $��0��6z   $��Center=�6�   $	��120��6   6�   �� *BankNo+$ TwoWay=�	 . 
 . 6  �� 5W      $��Branch Add:��6   $��0��6.   $
��Left=�6>   $��3,3,0,3q�6Y   $��3��6j   $��Center=�6w   $��26��6�   $��74��6�   �� 5X      -   5        $ branchAddTextBox��5X      $��1��64   $
��Left=�6D   $��24��6_   $��3,4,0,4q�6k   $��3��6|   $��Center=�6�   $	��120��6  {�.  ��6�   �� *	BranchAdd+$ TwoWay=�	 . 
 . 6  �� 5Y      $��Branch City:��6   $��0��6/   $
��Left=�6?   $��3,3,0,3q�6Z   $��4��6k   $��Center=�6x   $��26��6�   $��72��6�   �� 5Z      -   5        $ branchCityTextBox��5Z      $��1��65   $
��Left=�6E   $��24��6`   $��3,4,0,4q�6l   $��4��6}   $��Center=�6�   $	��120��6	  {�.  ��6�   �� *
BranchCity+$ TwoWay=�	 . 
 . 6  �� 5[      $��
Branch No:��6   $��0��6-   $
��Left=�6=   $��3,3,0,3q�6X   $��2��6i   $��Center=�6v   $��26��6�   $��68��6�   �� 5\      -   5        $ branchNoTextBox��5\      $��1��64   $
��Left=�6D   $��24��6_   $��3,4,0,4q�6k   $��2��6|   $��Center=�6�   $	��120��6  {�.   6�   �� *
BranchNo+$ TwoWay=�	 . 
 . 6#  5]      �� 5^      $��5��6   $��1��6&   $��144,2,-92,31q�66   $��2q�6L   
����  �._�5_      �� .+�5`      �� -   5         ��Name$ employeeImage��5`      $	��100��5b      $	��100��6    $
��Fill=�5e      $��94��6'   ��5a      �� *ImageSource+$ TwoWay=� �� 	Converter# [  5i      �� 5j      -   5        $ changeImageButton��5j      $��Change Image��5k      $��
9,10,10,10q�5l      5m      5n      5o      5p      5q      5r      