   M S B A M L   `   `   `  ����@  <PLWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLWPFPLWPF  5   	   = 9BE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BE;assembly=BEBE 5   	   #    PLWPF.addSpecializationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PLWPF     5   	   +BEclr-namespace:BE;assembly=BE     5   	     � Title$  addSpecializationWindow��5	   	   $	��450��6)   $	��400��66   .��5      �  � RowDefinitions 5   
   �� 5      $	��80* �6   �� 5      $
��255* �6   �� 5      $	��84* �6   .+�5   
   �� -   5         ��Name$ ContactTitle��5      $��Add Specialization��6&   $��Center=�6D   $��26(�6b   $��81,10,61,10q�6p   $	��250��6�   �� 5   
   -   5         ��Name$ 	AddButton��5      $	��Add��6$   $
��Bold"�62   $��26(�6D   $
��Left=�6R   $��
110,10,0,0q�6m   $��2��6�   $	��Top=�6�   $	��187��6�   $��53��6�   6�   �� 5   
   -   5        $ Back2Button��5      $
��Back��6&   $��Right=�65   $��
0,38,310,0q�6Q   $��2��6e   $	��Top=�6r   $��65��6�   $��25��6�   � 5   
   � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��	69,50,0,0q�69   $��1��6L   $	��Top=�6Y   $	��165��6q   $	��277��6~    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $	��137 �6#   �� 5      $��16 �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6    .+�5"      �� $��Specialization Name:��6   $��0��63   $
��Left=�6C   $��3q�6^   $��0��6i   $��Center=�6v   $��26��6�   $	��120��6�   �� 5#      -   5         ��Name$ expertiseNameTextBox��5#      $��1��64   $
��Left=�6D   $��24��6_   $��3q�6k   $��0��6v   $��Center=�6�   $	��120��6	  ��6�   �� *SpecializationName+ �� Mode$ TwoWay=� �� NotifyOnValidationError . 	 �� ValidatesOnExceptions	 . 6	  �� 5$      $��Field:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��1��6[   $��Center=�6h   $��26��6�   $��38��6�   �� 5%      -   5        
 ��Name$
 FieldComboBox��5%      $��1��6.   $
��Left=�6U   $��22��6p   $��3,5,0,0q�6|   $��1��6�   $	��Top=�6�   $	��120��6�    �� Text 6>   �� *Field+6�   �� 5&      $��Tariff Max:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��3��6`   $��Center=�6m   $��26��6�   $��64��6�   �� 5'      -   5        $ tariffMaxTextBox��5'      $��1��60   $
��Left=�6@   $��24��6[   $��3q�6g   $��3��6r   $��Center=�6�   $	��120��6�   ��6   �� *	TariffMax+$ TwoWay=� . 	 . 6�   �� 5(      $��Tariff Min:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��2��6`   $��Center=�6m   $��26��6�   $��62��6�   �� 5)      -   5        $ tariffMinTextBox��5)      $��1��60   $
��Left=�6@   $��24��6[   $��3q�6g   $��2��6r   $��Center=�6�   $	��120��6�   ��6   �� *	TariffMin+$ TwoWay=� . 	 . 6�   5*      5+      5,      