   M S B A M L   `   `   `  ����R  NTheMovies - Iteration 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TheMovies___Iteration_1TheMovies___Iteration_1  5   	   (    "TheMovies___Iteration_1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:TheMovies___Iteration_1     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   �� -   5         ��Name$ UpdateListBtn��5      $��Update list��6(   $
��Left=�6>   $��	67,87,0,0q�6Y   $	��Top=�6l   6�   �� 5   
   -   5         ��Name$ 	lstMovies��5      $��200,58,200,79q�6z   ��6%   �� *
moviesVM+ �� SelectedItem 6F   �� *SelectedMovie+ �� Mode$ TwoWay=���5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6    �� *
MovieTitle+�� 5      ��6    �� *
MovieGenre+�� 5      ��6    �� *MovieLength+5      5      5      �� 5   
   $��
Movie list��6   $
��Left=�6%   $��
200,27,0,0q�6@   $	��Top=�6T   $��72��6l   �� 5   
   -   5        $ LoadList��5      $��	Load List��6#   $
��Left=�67   $��
78,294,0,0q�6R   $	��Top=�6f   6~   �� 5   
   -   5         ��Name$ txtMovieTitle��5      $
��Left=�6)   $��152,370,0,0q�6D    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6�   $	��120��6�   ��6m   �� *SelectedMovie.MovieTitle+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ txtMovieGenre��5      $
��Left=�6)   $��299,370,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6�   $	��120��6�   ��6m   �� *SelectedMovie.MovieGenre+$ PropertyChanged=�6�   �� 5   
   -   5        $ txtMovieLength��5      $
��Left=�6*   $��442,370,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6�   $	��120��6�   	 J� RenderTransformOrigin$	 0.466,-0.56&�6�   ��6n   �� *SelectedMovie.MovieLength+$ PropertyChanged=�6�   �� 5   
   -   5        $ btnCreateMovie��5      $��	Add Movie��6)   $
��Left=�6=   $��
66,368,0,0q�6X   $	��Top=�6l   6�   5      5       