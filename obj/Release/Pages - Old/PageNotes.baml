   M S B A M L   `   `   `  ���� B  >Qontrol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QontrolQontrol      Qontrol.PageNotes   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Qontrol       N� Title$  	PageNotes�� N� 
Background �#5C80BC.��� -   .+��� 
�������$��Center=�$	��Top=�$��30(�Notes&   System.Windows.Controls.DataGrid  -     Name$ dataGridView��   AutoGenerateColumns .  $
��Left=�$	��179��$��
307,60,0,0q�$	��Top=�$	��299�� � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%~   '        �� "  .���  � ��
 �������  � ��$ SemiBold"���  � ��$ 0,0,1,2q���  � ��
 �   �   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$	 Title��
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	NoteTitle+  $	 Message��$
 *  �� *NoteMessage+