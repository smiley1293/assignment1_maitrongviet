   M S B A M L   `   `   `  ����>  :GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GUIGUI  5   	       GUI.WelcomeWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:GUI     5   	     � Title$  WelcomeWindow��5   	   $	��450��6   $	��800��6,    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	   .��5      �� ��5   
   �� 5       �� ImageSource$' !./hinh_anh/Welcome_Background.png��6    �� Opacity$ 1Q�6I   6W   ._�5   
   � .+�5      �� -   5         ��Name$ welcome_button��5      ���#123425$��Login��6C   $
��Left=�6S   $��486,350,0,0q�6n   $	��Top=�6�   $	��230��6�   $��44��6�   $��Helvetica Rounded)�6�   $��24(�6�    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value��%d   '��       �� 5      " ��6   .�5      �� 	 �@��CornerRadius$
 20��69   6F   5      5      ��5      �� 5      " ��6   .�5      �� 	 � ��
 �#efeade67   �� 5      	 � ��
 5       �� 5!   "    �� 
TargetType" ��62   .R�5"   &   �� #��z��6-   ._�5#   *   �� $��Center=�6;   $��Center=�6X   5$   '   5%   #   5'       �� Triggers 5(      P� 5)       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5*   "   �� 	 � ��
 �#FFC56E6?   �� 5+   "   	 �@J�Opacity$	
 0.8Q�6<   5-      5/      52      �� 54      -   5        ���#ff5347$	����54   *   $
��Left=�6=   $��
770,10,0,0q�6X   $	��Top=�6l   $��22��6�   $��22��6�   $��./assets/#FontAwesome)�6�   $��13(�6�    55      ��%d   '��       �� 56      " ��6   .�57      �� 	 �@��CornerRadius$
 50��69   6F   58      59      ��5:      �� 5;      " ��6   .�5<      �� 	 � ��
 5=      �� 5>   "   " ��62   .R�5?   &   �� #��z��6-   ._�5@   *   �� $��Center=�6;   $��Center=�6X   5A   '   5B   #   5D       5E      P� 5F       �@J�IsMouseOver$
 True��6=   . �5G   "   �� 	 �@J�Opacity$	
 0.8Q�6<   5H      5J      5L      5N      5O      5R      