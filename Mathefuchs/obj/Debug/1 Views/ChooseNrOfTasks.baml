   M S B A M L   `   `   `  ����E  AMathefuchs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Mathefuchs._1_ViewsMathefuchs._1_Views  5   	   )    #Mathefuchs._1_Views.ChooseNrOfTasks   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Mathefuchs._1_Views     5   	     N� Title$  ChooseNrOfTasks��5   	   $	��450��6!   $	��800��6.    N� 
Background 5
      �� 5   
    �� ImageSource$ /Images/Hintergrund.png��6   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� $��3��6   $��1q�5       �� CornerRadius$ 20��5      ���#3B3838���#3B3838$��Center=�5       $��Center=�5!      $	��600��5"      $��50��5#      ._�5%      �� $-��'Wie viele Aufgaben möchtest du lösen?��6   $��30(�5&       �� TextAlignment$ Center=�5'      $��Center=�5(      
�������5*      5+      �� 5-   
   -   5        $��
5 Aufgaben��5-   &   $��30(�6;   $��1��6I   $��0��6V   ��5/      �� 50       �� 
TargetType" ��6   .�51      ��  �� Property � ��	 �� Value	 �#E9C73763   �� 52       �@�Cursor$
	 Hand��6/   
 �� Triggers
 54      P� 55       P� Property �@J�IsMouseOver P� Value . . �56      ��  � ��	 �#F3E0916;   57      59      ��5<      �� 5=       �� 
TargetType" ��6"   .R�5>      �� $	��200��6   $��70��6)   $ 32��5?   %   #��z��5@   %   ._�5A      �� $��Center=�6+   $��Center=�5B   3   5C      5D      5E      5G      �� 5I   
   -   5        $��10 Aufgaben��5I   '   $��30(�6=   $��1��6K   $��1��6X   ��5K      �� 5L      " ��6   .�5M      ��  � ��	 �#E9591F63   �� 5N       �@�Cursor$
	 Hand��6/   
 5P      P� 5Q       �@J�IsMouseOver . . �5R      ��  � ��	 �#EF885F6;   5S      5U      ��5X      �� 5Y      " ��6"   .R�5Z      �� $	��200��6   $��70��6)   $ 32��5[   %   #��z��5\   %   ._�5]      �� $��Center=�6+   $��Center=�5^   3   5_      5`      5a      5c      �� 5e   
   -   5        $��20 Aufgaben��5e   '   $��30(�6=   $��1��6K   $��2��6X   ��5g      �� 5h      " ��6   .�5i      ��  � ��	 �#910D0D63   �� 5j       �@�Cursor$
	 Hand��6/   
 5l      P� 5m       �@J�IsMouseOver . . �5n      ��  � ��	 �#B410106;   5o      5q      ��5t      �� 5u      " ��6"   .R�5v      �� $	��200��6   $��70��6)   $ 32��5w   %   #��z��5x   %   ._�5y      �� $��Center=�6+   $��Center=�5z   3   5{      5|      5}      5      5�      5�      