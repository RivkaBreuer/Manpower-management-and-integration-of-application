   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	        PLWPF.deleteContractWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  deleteContractWindow��5   	   $	��300��6&   $	��400��63   .��5	      � .+�5
   
   �� -   5         ��Name$ ContractTitle��5
      $��Delete Contract��6'   $��Center=�6B   $��26(�6`   $��85,15,57,189q�6n   $	��250��6�   �� 5   
   -   5         ��Name$ deleteButton��5      $��Delete��6'   $
��Bold"�68   $��26(�6J   $
��Left=�6X   $��140,182,0,0q�6s   $	��Top=�6�   $	��137��6�   $��43��6�   {�.  6�   �� 5   
   -   5        $ Back4Button��5      $
��Back��6&   $��Right=�65   $��0,200,297,0q�6Q   $	��Top=�6f   $��65��6~   $��25��6�   � 5   
   -   5         �Name$ grid1��5      $	��Top=�6   $��
80,100,0,0q�66   $
��Left=�6J    � RowDefinitions 5      �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��6/   $��
-24,3,0,-3q�6<   $
��Left=�6P   $��0��6k   $��Choose contract num:��6{   $��32��6�   $	��148��6�   �� 5      -   5         ��Name$ ContractNumComboBoxd��5      $	��120��65   $��Center=�6A   $��0��6�   $��	112,5,0,4q�6�   $��23��6�   $
��Left=�6�   $��2��6C   �� Text 6\   �� *ContractNum+ �� Mode$ TwoWay=�	 �� NotifyOnValidationError	 . 
 �� ValidatesOnExceptions
 . 6C  5      5      5      