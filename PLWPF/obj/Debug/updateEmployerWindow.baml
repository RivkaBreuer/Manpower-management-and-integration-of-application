   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	        PLWPF.updateEmployerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  updateEmployerWindow��5   	   $	��550��6&   $	��400��63   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��370* �6   �� 5      $	��89* �6   .+�5   
   �� -   5         ��Name$ EmployerTitle��5      $��Update Employer��6'   $��Center=�6B   $��26(�6`   $��	87,5,65,5q�6n   $	��240��6�   �� 5   
   -   5         ��Name$ updateButton��5      $��Update��6'   $
��Bold"�68   $��26(�6J   $
��Left=�6X   $��	98,10,0,0q�6s   $��2��6�   $	��Top=�6�   $	��187��6�   $��53��6�   {�.  6�   �� 5   
   -   5        $ Back5Button��5      $
��Back��6&   $��Right=�65   $��
0,38,310,0q�6Q   $��2��6e   $	��Top=�6r   $��65��6�   $��25��6�   � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��	54,34,0,0q�69   $��1��6L   $	��Top=�6Y   $	��300��6q   $	��281��6~    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5#      �� $��Address:��6   $��0��6'   $
��Left=�67   $��3q�6R   $��3��6]   $��Center=�6j   �� 5$      -   5         ��Name$ addressTextBox��5$      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��3��6p   $��Center=�6�   $	��120��6  {�.  ��6}   �� *	Address+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 
 �� UpdateSourceTrigger$
 Explicit=�6"  �� 5%      $��Company Name:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��6��6b   $��Center=�6o   �� 5&      -   5        $ companyNameTextBox��5&      $��1��62   $
��Left=�6B   $��23��6]   $��3,0,0,5q�6i   $��6��6z   $��Bottom=�6	  $	��120��6$  {�.  ��6�   �� *CompanyName+$ TwoWay=� . 	 . $
 Explicit=�60  �� 5'      $��Date Establishment:��6   $��0��62   $
��Left=�6B   $��3q�6]   $��7��6h   $��Center=�6u   (  "System.Windows.Controls.DatePicker  5(      -   5          Name$! dateEstablishmentDatePicker��5(      $��1��6>   $
��Left=�6N   $��3q�6i   $��7��6t   $��Center=�6  {�.     SelectedDate 6�   �� *DateEstablishment+$ TwoWay=� . 	 . $
 Explicit=�6,  �� 5)      $��First Name:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��2��6`   $��Center=�6m   �� 5*      -   5        $ firstNameTextBox��5*      $��1��60   $
��Left=�6@   $��23��6[   $��2q�6g   $��2��6r   $��Center=�6�   $	��120��6  {�.  ��6   �� *	FirstName+$ TwoWay=� . 	 . $
 Explicit=�6&  �� 5+      $	��Id:��6   $��0��6"   $
��Left=�62   $��3q�6M   $��0��6X   $��Center=�6e   �� 5,      -	   5         ��Name$ 
idComboBox��5,      $��1��6+    �� DisplayMemberPath$ Id��6;   $
��Left=�6R   $
��Auto��6m   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�    �� Text 6{   �� *Id+6�   �� 5-      $��Is Company:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��5��6`   $��Center=�6m   �� 5.      -
   5         ��Name$ isCompanyCheckBox��5.      $�� ��62   $��1��6=   $
��Left=�6M   $��3q�6�   $��5��6�   $��Center=�6  {�.   d� 	IsChecked 6h   �� *	IsCompany+$ TwoWay=� . 	 . $
 Explicit=�6V  �� 5/      $��
Last Name:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��1��6_   $��Center=�6l   �� 50      -   5        $ lastNameTextBox��50      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��1��6q   $��Center=�6�   $	��120��6  {�.  ��6~   �� *
LastName+$ TwoWay=� . 	 . $
 Explicit=�6$  �� 51      $��
Phone Num:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��4��6_   $��Center=�6l   �� 52      -   5        $ phoneNumTextBox��52      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��4��6q   $��Center=�6�   $	��120��6  {�.  ��6~   �� *
PhoneNum+$ TwoWay=� . 	 . $
 Explicit=�66  �� 53      $��Field:��6   $��0��6&   $
��Left=�66   $��3q�6Q   $��8��6\   $��Center=�6i   �� 54      -   5        $ skillComboBox��54      $��1��6.   $
��Left=�6s   $
��Auto��6�   $��3q�6�   $��8��6�   $��Center=�6�   $	��120��6�    6>   �� *Field+$
 Explicit=�55      57      58      59      