   M S B A M L   `   `   `  ����B  >noteapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:noteappnoteapp  5   	       noteapp.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:noteapp     5   	     � Title$  
NotepadApp��5   	   $	��600��6   $	��950��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 dt1��5
   *   $��10,10,653,292q�6      AutoGenerateColumns$ False��67   $
��Auto��6S      GridLinesVisibility$
 None=�6`   $��0q�6{      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	File Name��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6<      CellTemplate 5      �� 5      .R�5      �� ��6(   �� 6;   5      5      5      �� 5   
   -   5         ��Name$	 tb1��5      $
��Left=�6   $��
318,10,0,0q�6:   	 �� TextWrapping$
	 Wrap=�6N   $	��Top=�6b   $	��498��6z   $	��622��6�   $��Creative Note��6�   �� 5   
   -   5        $
��Save��5      $
��Left=�61   $��
10,328,0,0q�6L   $	��Top=�6`   $��36��6x   $��98��6�   �� 5   
   -   5        $
��Open��5      $
��Left=�61   $��
11,472,0,0q�6L   $	��Top=�6`   $��36��6x   $��97��6�   �� 5   
   -   5        $��Delete��5      $
��Left=�65   $��199,328,0,0q�6P   $	��Top=�6e   $��36��6}   $��98��6�   �� 5   
   -   5        $	��New��5      $
��Left=�6/   $��200,472,0,0q�6J   $	��Top=�6_   $��36��6w   $��97��6�   �� 5   
   -   5        $ filename��5      $
��Left=�6$   $��629,513,0,0q�6?   $
	 Wrap=�6T   $	��Top=�6i   $	��311��6�   �� 5   
   $��Name:��6   $
��Left=�6    $��585,508,0,0q�6;   $	��Top=�6P   $��31��6h   
 J� RenderTransformOrigin$
 0.494,0.502&�6t   5      5      