   M S B A M L   `   `   `  ����I  EInformatorMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:InformatorMVVM.View.DialogsInformatorMVVM.View.Dialogs  5   	   7    1InformatorMVVM.View.Dialogs.KategoriaUpdateDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:InformatorMVVM.View.Dialogs     5   	     � Title$  Edytowanie Kategorii��5   	   $	��200��6&   $	��800��63    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%�  '��       '��     '�� K    �� 5   
   " ��6   .�5      ��  � ��$ 0,3,5,5q�6'   �� 5       � ��$ 0,0,0,5q�6(   �� 5       � �� �#3333336+   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$ 14(�6)   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6   .�5      ��  � ��$ 0,0,0,5q�6'   �� 5       � �� �#3333336+   �� 5       � ��$ Segoe UI)�6+   �� 5       � ��$ 12(�6)   �� 5       � �� �#CBCCFF6,   �� 5       � ��$ 2q�60   �� 5       � ��$ 5q�6(   5      �� 5   
   " ��6   .�5      ��  � ��$ 90��6&   �� 5        � ��$ 30��6'   �� 5!       � ��$ 5,0,0,0q�6'   �� 5"       � �� �#FFFFFF6+   �� 5#       � ��$ Segoe UI)�6+   �� 5$       � ��$ 14(�6)   �� 5%       � �� �#007ACC6+   �� 5&       � �� �#007ACC6,   �� 5'       � ��$ 1q�60   �� 5(       � ��$ 5q�6(   �� 5)       � �� 5*      �� 5+      " ��6&   .R�5,      �� #��z��6!   #��z��6K   #��z��6w   $ 4��6�   ._�5-      �� $��Center=�6/   $��Center=�6L   5.      5/      51      52      54      .��56      � $��10q�6    � ColumnDefinitions 57   
   �� 58      $
��Auto �6   �� 59       � RowDefinitions 5<   
   �� 5=      $��1* �6   �� 5>      .+�5A   
   �� $��0��6   $��0��6    .��6-   Nazwa Kategorii:6?   �� 5B   
   -   5        $��kategoriaNazwa��5B      $��1��6(   $��0��68   �� 5E   
   $��0��6   $��2��6%   $��1��69   	 �� Orientation$	 
Horizontal=�6F   $��Center=�6_   .+�5F      �� -   5        $��okButton��5F      $��Edytuj��6;   �� 5G      -   5        $��cancelButton��5G   2   
������
 �� IsCancel$

 True��6F   $��Cofnij��6V   5H      5I      5J      