   M S B A M L   `   `   `  ����B  >Qontrol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:QontrolQontrol  5          Qontrol.PageNotesDatabase   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Qontrol     5        N� Title$  PageNotesDatabase��5	       N� 
Background �#5C80BC.��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         AutoGenerateColumns .  $
��Left=�6A   $	��179��6\   $��
277,60,0,0q�6i   $	��Top=�6}   $	��286��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6C      Header$ Title��6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	NoteTitle+6O     5      $	 100 6E   $ Message��6Q    6%   �� *NoteMessage+6Q   5      �� 5   
   $��Title��6   $
��Left=�6    $��2,59,0,0q�6;   $	��Top=�6M   $	��100��6e   �� 5   
   $��Message��6   $
��Left=�6"   $��2,94,0,0q�6=   $	��Top=�6O   �� 5   
   -   5         ��Name$ txtTitle��5      $
��Left=�6$   $��23��6?   $��	65,60,0,0q�6K   	 �� TextWrapping$
	 Wrap=�6^   $	��Top=�6r   $	��202��6�   �� 5   
   -   5        $ 
txtMessage��5      $
��Left=�6&   $	��144��6A   $��	65,95,0,0q�6N   $
	 Wrap=�6a   $	��Top=�6u   $	��202��6�   �� 5   
   -   5        
 ��Name$
 
btnNewNote��5      $	��New��6%   $
��Left=�63   $��
65,253,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5        $
 btnSaveNote��5      $
��Save��6&   $
��Left=�65   $��192,253,0,0q�6P   $	��Top=�6e   $��75��6}   6�   �� 5   
   -   5        $
 btnDeleteNote��5      $��Delete��6(   $
��Left=�69   $��488,253,0,0q�6T   $	��Top=�6i   $��75��6�    J� RenderTransformOrigin$ -1.771,1.024&�6�   6�   5      5      