   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	        PLWPF.deleteEmployeeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  deleteEmployeeWindow��5	   	   $	��300��6&   $	��400��63   .��5      � .+�5   
   �� -   5         ��Name$ EmployeeTitle��5      $��Delete Employee��6'   $��Center=�6B   $��26(�6`   $��85,15,57,189q�6n   $	��250��6�   �� 5   
   -   5         ��Name$ deleteButton��5      $��Delete��6'   $
��Bold"�68   $��26(�6J   $
��Left=�6X   $��140,182,0,0q�6s   $	��Top=�6�   $	��137��6�   $��43��6�   {�.  6�   �� 5   
   -   5        $ Back4Button��5      $
��Back��6&   $��Right=�65   $��0,200,297,0q�6Q   $	��Top=�6f   $��65��6~   $��25��6�   � 5   
   -   5         �Name$ grid1��5      $	��Top=�6   $��
80,100,0,0q�66   $
��Left=�6J    � RowDefinitions 5      �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��
Choose Id:��6r   �� 5      -   5         ��Name$ idComboBoxd��5      $	��120��6,   $��Center=�68   $��0��6�   $��3q�6�   $��23��6�   $
��Left=�6�   $��1��6�    �� Text 6S   �� *Id+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6�   5      5      5      