   M S B A M L   `   `   `  ����E  AMathefuchs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Mathefuchs._2_ViewmodelsMathefuchs._2_Viewmodels  5      '    !Mathefuchs._1_Views.EndOfTraining   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Mathefuchs._2_Viewmodels     5        N� Title$  EndOfTraining��5	       � DataContext 5      3   -Mathefuchs._2_Viewmodels.ViewModelDataContext  5   
    N� 
Background 5      �� 5   
    �� ImageSource$ /Images/Hintergrund.png��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��320 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $'��!/Images/Fritz Standardhaltung.png��6   $��0��6;   $��0��6K   $��2��6X   $
��Left=�6i   $��10q�6�   �� 5"   
   $��1��6   $��0��6!   $��1q�5#       �� CornerRadius$ 20��5$      ���#3B3838���#3B3838$��Center=�5'      $��Center=�5(      $	��400��5)      $��50��5*      ._�5,      �� $+��%Klasse, du hast deine Übung beendet!��6   $��20(�5-       �� TextAlignment$ Center=�5.      $��Center=�5/      
�������51      52      �� 55   
   -   5        $��1��55      $��1��6!   $��Medium"�57      $��Center=�58      $��	0,0,20,20q�59      .��5;      ]� $	��340��6   .+�5<      �� $��Weiter zum Minispiel��6   $��30(�68   $��Center=�6F   �� 5=      $��/Images/Icons/Pfeil.png��6   $��Right=�69   $��40��6U   5>      ��5@      �� 5A       �� 
TargetType" ��6   .�5B      �� 	 �� Property	 � ��
 �� Value
 �#E9591F63   �� 5C      	 �@�Cursor$

 Hand��6/    �� Triggers 5E      P� 5F       P� Property �@J�IsMouseOver P� Value . . �5G      �� 	 � ��
 �#EF885F6;   5H      5J      ��5M      �� 5N       �� 
TargetType" ��6"   .R�5O      �� $	��370��6   $��70��6)   $ 32��5P   %   #��z��5Q   %   ._�5R      �� $��Center=�6+   $��Center=�5S   3   5T      5U      5V      5X      5Y      5Z      