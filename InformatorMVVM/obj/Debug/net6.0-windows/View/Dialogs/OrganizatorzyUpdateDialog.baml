   M S B A M L   `   `   `  ����I  EInformatorMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:InformatorMVVM.View.DialogsInformatorMVVM.View.Dialogs  5   	   ;    5InformatorMVVM.View.Dialogs.OrganizatorzyUpdateDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:InformatorMVVM.View.Dialogs     5   	     � Title$  Edytowanie Organizatora��5   	   $	��450��6)   $	��800��66   .��5	      � $��10q�6    � 	Resources 5
   
    �� 
TargetType �� Property �� Value��%�  '��       '�� v     '�� �     '��     �� 5      " ��6   .�5      ��  � ��$ 0,3,5,5q�6+   �� 5       � ��$ 0,0,0,5q�6,   5      �� 5      " ��6   .�5      ��  � ��$ 0,0,0,5q�6+   5      �� 5      " ��6   .�5      ��  � ��$ 0,0,0,5q�6+   5      �� 5      " ��6   .�5      ��  � ��$ 70��6*   �� 5       � ��$ 25��6+   �� 5       � ��$ 5,0,0,0q�6+   5      5       � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5!   
   �� 5"      $��1* �6   �� 5#      $��1* �6   �� 5$      .+�5'   
   �� $��0��6   $��0��6    .��6-   Nazwa Organizatora:6B   �� 5(   
   -   5        $��organizatorNazwa��5(      $��1��6*   $��0��6:   �� 5*   
   $��0��6   $��1��6    .��6.   Uzytkownik:6;   �� 5+   
   -   5        $��organizatorUzytkownik��5+      $��1��60   $��1��6@    �� DisplayMemberPath$ email��6M    �� SelectedValue 6g   �� *id_konta.FKID+�� 5/   
   $��0��6   $��2��6%   $��2��69   	 �� Orientation$	 
Horizontal=�6F   $��Center=�6_   .+�50      �� -   5        $��okButton��50      .��6=   Edit6C   �� 51      -   5        $��cancelButton��51      
 �� IsCancel$

 True��6)   .��69   Cancel6A   52      53      54      