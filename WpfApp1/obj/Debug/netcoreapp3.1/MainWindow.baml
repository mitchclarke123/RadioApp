   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Title$  
MainWindow��5   	   $	��439��6   $	��796��6)   .��5	      � ��5
   
   �� 5       �� ImageSource$ radio interface.jpeg��6    j� Stretch$
 Fill=�6<    � ColumnDefinitions 5   
   �� 5      $
��399* �6   �� 5      $
��397* �6   .+�5   
   �� -   5         ��Name$ Switch��5      $	��Off��6!   $
��Left=�6/   $��	234,0,0,0q�6J   $��Center=�6]   $��47��6x   $	��123��6�   ���	#FFFF0A0A$��1��6�   �� 5   
   -   5        $ On��5      $��On��6   $
��Left=�6*   $��39,0,0,0q�6E   $��Center=�6W   $��47��6r   $	��123��6~   ���	#FFFF0A0A6�   �� 5   
   -   5         ��Name$ radioStatus��5      $
��Left=�6'   $��
307,10,0,0q�6B   $��	Radio off��6V    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��183��6�   $	��163��6�   $��2��6�   $��30(�6�   �� 5   
   -   5        $ Channel1��5      $��	Channel 1��6#   $
��Left=�67   $��
86,317,0,0q�6R   $	��Top=�6f   $��40��6~   $��84��6�   ���	#FFFF0A0A6�   �� 5   
   -   5        $ channel2��5      $��	Channel 2��6#   $
��Left=�67   $��261,317,0,0q�6R   $	��Top=�6g   $��40��6   $��84��6�   ���	#FFFF0A0A6�   �� 5   
   -   5        $ channel3��5      $��	Channel 3��6#   $
��Left=�67   $��
49,317,0,0q�6R   $	��Top=�6f   $��40��6~   $��84��6�   $��1��6�   ���	#FFFF0A0A6�   �� 5   
   -   5        $ channel4��5      $��	Channel 4��6#   $
��Left=�67   $��221,317,0,0q�6R   $	��Top=�6g   $��40��6   $��84��6�   $��1��6�   ���	#FFFF0A0A6�   �� 5   
   -	   5        $ volumeStatus��5      $��0��6(   $
 Wrap=�61   $��199,25,108,344q�6E   $��30(�6]   6k   �� 5   
   -
   5        $ volumeUp��5      $��+Volume��6#   $��58,6,256,375q�65   6K   �� 5   
   -   5        $ 
volumeDown��5      $��-Volume��6%   $��58,59,256,321q�67   6N   r� 5   
   -   5        $��MusicPlayer��5   Q   $	��120��6   $��105,39,11,0q�6$    r� LoadedBehavior$ Manual=�69   $	��Top=�6d   $��1��6|   5      5      