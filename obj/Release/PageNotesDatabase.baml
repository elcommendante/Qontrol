   M S B A M L   `   `   `  ���� B  >Qontrol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QontrolQontrol      Qontrol.PageNotesDatabase   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Qontrol       N� Title$  PageNotesDatabase�� N� 
Background �#5C80BC.��� .+�&   System.Windows.Controls.DataGrid  -     Name$ dataGrid��   AutoGenerateColumns .  $
��Left=�$	��179��$��
277,60,0,0q�$	��Top=�$	��286��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100    Header$ Title��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	NoteTitle+  $	 100 $ Message�� �� *NoteMessage+�� $��Title��$
��Left=�$��2,59,0,0q�$	��Top=�$	��100���� $��Message��$
��Left=�$��2,94,0,0q�$	��Top=��� -    ��Name$ txtTitle��$
��Left=�$��23��$��	65,60,0,0q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��202���� -   $ 
txtMessage��$
��Left=�$	��144��$��	65,95,0,0q�$
	 Wrap=�$	��Top=�$	��202���� -   
 ��Name$
 
btnNewNote��$	��New��$
��Left=�$��
65,253,0,0q�$	��Top=�$��75���� -   $
 btnSaveNote��$
��Save��$
��Left=�$��192,253,0,0q�$	��Top=�$��75���� -   $
 btnDeleteNote��$��Delete��$
��Left=�$��488,253,0,0q�$	��Top=�$��75�� J� RenderTransformOrigin$ -1.771,1.024&�