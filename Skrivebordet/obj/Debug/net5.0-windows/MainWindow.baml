   M S B A M L   `   `   `  ����G  CSkrivebordet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SkrivebordetSkrivebordet  5   	       Skrivebordet.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Skrivebordet     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��Upload��5      $
��Left=�6"   $��
678,59,0,0q�6=   $��1��6Q   $	��Top=�6^    J� RenderTransformOrigin$ 1.665,0.199&�6v   6�   �� 5   
   -   5        $��FilePath��5      $
��Left=�6"   $��	73,54,0,0q�6=   $��1��6P    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��508��6�   $��29��6�   �� 5   
   -   5         ��Name$ ListPictures��5      $��Visible=�6(   5      �� 5   
   -   5        $��ShuffleBackground��5      $
��Left=�6/   $��
101,10,0,0q�6J   $��1��6^   $	��Top=�6k   6�   �� 5   
   -   5        $��ShuffleBackgroundTimer��5      $
��Left=�60   $��	250,9,0,0q�6K   $��1��6^   $	��100��6k   $
 Wrap=�6v   $	��Top=�6�   $	��281��6�   5      5      