   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	       PLWPF.addContractWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  addContractWindow��5	   	   $	��550��6#   $	��400��60   .��5      �  � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��375* �6   �� 5      $	��79* �6   .+�5   
   �� -   5         ��Name$ ContactTitle��5      $��Add Contract��6&   $��Center=�6>   $��26(�6\   $��105,10,37,365q�6j   $��2��6�   $	��250��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $	��Add��6$   $
��Bold"�62   $��26(�6D   $
��Left=�6R   $��	98,10,0,0q�6m   $��2��6�   $	��Top=�6�   $	��187��6�   $��53��6�   {�.  ��5      �� 5       �� Triggers 5      �� 5       �� Binding 6&   ��  �� ElementName$ employeeIdComboBox�� �� Path$ 
EmployeeId� �� Value  6j   .a�5      �� 	 �� Property	 � {�
 �� Value
 .  6A   5      �� 5       6&   �� $ hoursNumTextBox��$
 Text� 06a   .a�5      �� 	 � {�
 .  6A   5      �� 5       6&   �� $ hoursNumTextBox��$
 Text�  6a   .a�5      �� 	 � {�
 .  6A   5      5"      5$      �� 5%   
   -   5        $ Back2Button��5%      $
��Back��6&   $��Right=�65   $��
0,38,310,0q�6Q   $��2��6e   $	��Top=�6r   $��65��6�   $��25��6�   � 5'   
   � 5(   
   -   5         �Name$ grid1��5(      $
��Left=�6   $��	68,27,0,0q�69   $��1��6L   $	��Top=�6Y    � ColumnDefinitions 5)      �� 5*      $
��Auto �6#   �� 5+      $
��Auto �6#    5-      �� 5.      $
��Auto �6    �� 5/      $
��Auto �6    �� 50      $
��Auto �6    �� 51      $
��Auto �6    �� 52      $
��Auto �6    �� 53      $
��Auto �6    �� 54      $
��Auto �6    �� 55      $
��Auto �6    �� 56      $
��Auto �6    �� 57      $
��Auto �6    .+�59      �� $��Date Beging Employin:��6   $��0��64   $
��Left=�6D   $��3q�6_   $��4��6j   $��Center=�6w   (  "System.Windows.Controls.DatePicker  5:      -   5          Name$" dateBegingEmployinDatePicker��5:      $��1��6?   $
��Left=�6O   $��3q�6j   $��4��6u   $��Center=�6�      SelectedDate 6�   �� *DateBegingEmployin+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 5;      $��Date End Employing:��6   $��0��62   $
��Left=�6B   $��3q�6]   $��5��6h   $��Center=�6u     5<      -   5        $  dateEndEmployingDatePicker��5<      $��1��6=   $
��Left=�6M   $��3q�6h   $��5��6s   $��Center=�6�    6�   �� *DateEndEmploying+$ TwoWay=� .  . 6�   �� 5=      $��Employee Id:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 5>      -   5         ��Name$ employeeIdComboBox��5>      $��1��63   $
��Auto��6u   $	��3,5q�6�   $��0��6�   $��Center=�6�    �� SelectedValue 6C   �� *
EmployeeId+$ TwoWay=�6�   �� 5?      $��Employer Id:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��1��6a   $��Center=�6n   �� 5@      -   5        $ employerIdComboBox��5@      $��1��63   $
��Left=�6u   $
��Auto��6�   $��3q�6�   $��1��6�   $��Center=�6�   $	��120��6�    6C   �� *
EmployerId+$ TwoWay=�5A      �� 5B      $��Hour Salary G:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��2��6c   $��Center=�6p   �� 5C      $��
Hours Num:��6   $��0��6)   $
��Left=�69   $��3,0,0,3q�6T   $��3��6e   $��Bottom=�6r   �� 5D      $��3q�6   $��2��6$   $��1��61   .+�5E          PLWPF.NumericUpDownControl  -	   5          Name$ salaryNumUpDown��5E   -   $��Center=�6F   $��3,0,2,0q�6c   $��26��6t   $	��115��6�      Value 6�   �� *HourSalaryG+$ TwoWay=� .  . 5G      �� 5H      -
   5         ��Name$ hoursNumTextBox��5H      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��3��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
HoursNum+$ TwoWay=� .  . 6  �� 5I      $��Is Interview:��6   $��0��6,   $
��Left=�6<   $��3,0,0,3q�6W   $��6��6h   $��Bottom=�6u   �� 5J      -   5         ��Name$ isInterviewCheckBox��5J      $�� ��64   $��1��6?   $
��Left=�6O   $��3q�6�   $��6��6�   $��Center=�6�    d� 	IsChecked 6j   �� *IsInterview+$ TwoWay=� .  . 6�   �� 5K      $��Is Sign:��6   $��0��6'   $
��Left=�67   $��3q�6R   $��7��6]   $��Center=�6j   �� 5L      -   5        $ isSignCheckBox��5L      $�� ��6/   $��1��6:   $
��Left=�6J   $��3q�6�   $��7��6�   $��Center=�6�    6e   �� *IsSign+$ TwoWay=� .  . 6�   5M      5N      5O      