   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	   &     PLWPF.updateSpecializationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$   updateSpecializationWindow��5	   	   $	��450��6,   $	��400��69   .��5      �  � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $
��282* �6   �� 5      $	��72* �6   .+�5   
   �� -   5         ��Name$ SpacialTitle��5      $��Update Spacialization��6&   $��Center=�6G   $��26(�6e   $��	77,5,47,5q�6s   $	��268��6�   �� 5   
   -   5         ��Name$ updateButton��5      $��Update��6'   $
��Bold"�68   $��26(�6J   $
��Left=�6X   $��	98,10,0,0q�6s   $��2��6�   $	��Top=�6�   $	��187��6�   $��53��6�   {�.  6�   �� 5   
   -   5        $ Back5Button��5      $
��Back��6&   $��Right=�65   $��
0,38,310,0q�6Q   $��2��6e   $	��Top=�6r   $��65��6�   $��25��6�   � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��	70,60,0,0q�69   $��1��6L   $	��Top=�6Y    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5#      �� $��Field:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��2��6[   $��Center=�6h   �� 5$      -   5         ��Name$ skillComboBox��5$      $��1��6.   $
��Left=�6j   $
��Auto��6�   $��3q�6�   $��2��6�   $��Center=�6�   $	��120��6�    �� SelectedItem 6>   �� *Field+ �� Mode$ TwoWay=�5%      �� 5&      $��Specialization Name:��6   $��0��63   $
��Left=�6C   $��3q�6^   $��1��6i   $��Center=�6v   �� 5'      -   5        	 ��Name$	 specializationNameTextBox��5'      $��1��69   $
��Left=�6I   $��23��6d   $��3q�6p   $��1��6{   $��Center=�6�   $	��120��6  {�.  ��6�   �� *SpecializationName+$ TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6  �� 5(      $��Special Num:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 5)      -   5        $ specialNumComboBox��5)      $��1��63    �� DisplayMemberPath$ 
SpecialNum��6C   $
��Left=�6b   $
��Auto��6}   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�    6�   �� *
SpecialNum+5+      �� 5,      $��Tariff Max:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��4��6`   $��Center=�6m   �� 5-      -   5        $	 tariffMaxTextBox��5-      $��1��60   $
��Left=�6@   $��23��6[   $��3q�6g   $��4��6r   $��Center=�6�   $	��120��6�   {�.  ��6   �� *	TariffMax+$ TwoWay=�
 .  . 6	  �� 5.      $��Tariff Min:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��3��6`   $��Center=�6m   �� 5/      -	   5        $	 tariffMinTextBox��5/      $��1��60   $
��Left=�6@   $��24��6[   $��3,0,0,4q�6g   $��3��6x   $��Bottom=�6�   $	��120��6  {�.  ��6�   �� *	TariffMin+$ TwoWay=�
 .  . 6  50      52      53      