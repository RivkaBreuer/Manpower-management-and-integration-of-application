   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	       PLWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��500��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��525* �6    � RowDefinitions 5   
   �� 5      $	��70* �6   �� 5      $
��356* �6   �� 5      $
��213* �6   .+�5   
   � $��Stretch=�6   $��1��6-   $
��auto��6:   $��0,0,0,49q�6G   $��2��6Y    5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6     5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ employerButton��5      $��35(�6-   $��Employer��6;   $��Stretch=�6N   $��10q�6l   $
��auto��6x      ButtonBackground#��[  6�   �� 5       -   5        $ employeeButton��5       $��35(�6-   $��Employee��6;   $��Stretch=�6N   $��10q�6l   $
��auto��6x   $��1��6�   #��[  6�   �� 5!      -   5        $ contractButton��5!      $��35(�6-   $��Contract��6;   $��Stretch=�6N   $��10q�6l   $
��auto��6x   $��1��6�   #��[  6�   �� 5"      -   5        $ specializationButton��5"      $��35(�63   $��Specialization��6A   $��Stretch=�6Z   $��10q�6x   $
��auto��6�   $��1��6�   $��1��6�   #��[  6�   �� 5#      -   5        $ 
linqButton��5#      $��35(�6)   $
��Linq��67   $��Stretch=�6F   $��10q�6d   $
��auto��6p   $��2��6}   #��[  6�   �� 5$      -   5        $ MoreFunc��5$      $��35(�6'   $��MoreFunc��65   $��Stretch=�6H   $��10q�6f   $
��auto��6r   $��1��6   $��2��6�   #��[  6�   5'      5*      5+      