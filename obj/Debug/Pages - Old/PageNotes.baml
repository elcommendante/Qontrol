   M S B A M L   `   `   `  ����B  >Qontrol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QontrolQontrol  5          Qontrol.PageNotes   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Qontrol     5        N� Title$  	PageNotes��5	       N� 
Background �#5C80BC.��5      � -   5        .+�5   
   �� 
�������$��Center=�6'   $	��Top=�6D   $��30(�6\   Notes6q   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGridView��5         AutoGenerateColumns .  $
��Left=�6E   $	��179��6`   $��
307,60,0,0q�6m   $	��Top=�6�   $	��299��6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
 �����6B   �� 5       � ��$ SemiBold"�63   6F   �� 5       � ��$ 0,0,1,2q�68   6J   �� 5       � ��
 �   �6D   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Title��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *	NoteTitle+6`     5      $	 Message��6%   $
 * 66    6@   �� *NoteMessage+6b   5!      5"      5#      