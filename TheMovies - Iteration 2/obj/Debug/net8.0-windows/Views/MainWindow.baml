   M S B A M L   `   `   `  ����R  NTheMovies - Iteration 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TheMovies___Iteration_1TheMovies___Iteration_1  5   	   W0clr-namespace:TheMovies___Iteration_1.ViewModels"TheMovies___Iteration_1.ViewModels  6=   (    "TheMovies___Iteration_1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:TheMovies___Iteration_1     5   	   G
viewmodels0clr-namespace:TheMovies___Iteration_1.ViewModels     6=   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   �� -   5         ��Name$ UpdateListBtn��5      $��Update list��6(   $
��Left=�6>   $��226,380,0,0q�6Y   $	��Top=�6n   6�   �� 5   
   -   5         ��Name$ 	lstMovies��5      $��200,58,37,79q�6z   ��6%   �� *
moviesVM+ �� SelectedItem 6F   �� *SelectedMovie+ �� Mode$ TwoWay=���5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6    �� *
MovieTitle+�� 5      ��6    �� *
MovieGenre+�� 5      ��6    �� *MovieLength+�� 5      ��6    �� *MovieDirector+�� 5      ��6    �� *PremiereDate+�� 5      ��6    �� *
CinemaHall+5      5      5      �� 5   
   $��
Movie list��6   $
��Left=�6%   $��
200,27,0,0q�6@   $	��Top=�6T   $��72��6l   �� 5   
   -   5        $ LoadList��5      $��	Load List��6#   $
��Left=�67   $��313,380,0,0q�6R   $	��Top=�6g   6   �� 5   
   -   5         ��Name$ txtMovieTitle��5      $
��Left=�6)   $��	27,84,0,0q�6D    �� TextWrapping$
 Wrap=�6W   $	��Top=�6�   $	��120��6�    J� RenderTransformOrigin$ 0.517,-2.002&�6�   ��6k   �� *SelectedMovie.MovieTitle+	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   �� 5   
   -   5        $ txtMovieGenre��5      $
��Left=�6)   $��
28,133,0,0q�6D   $
 Wrap=�6X   $	��Top=�6�   $	��120��6�   ��6l   �� *SelectedMovie.MovieGenre+$	 PropertyChanged=�6�   �� 5    
   -   5        $ txtMovieLength��5       $
��Left=�6*   $��
27,182,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6�   $	��120��6�   $ 0.466,-0.56&�6�   ��6m   �� *SelectedMovie.MovieLength+$	 PropertyChanged=�6�   �� 5!   
   -   5        $ btnCreateMovie��5!      $��	Add Movie��6)   $
��Left=�6=   $��
27,380,0,0q�6X   $	��Top=�6l   $ -2.213,-0.048&�6�   �� 5"   
   -	   5        
 ��Name$
 lblMovieTitle��5"      $��Movie Title��6'   $
��Left=�6=   $��	25,58,0,0q�6X   $	��Top=�6k   $ 0.278,0.464&�6�   �� 5#   
   -
   5        $
 lblMovieGenre��5#      $��Movie Genre��6'   $
��Left=�6=   $��
28,107,0,0q�6X   $	��Top=�6l   �� 5$   
   -   5        $
 lblMovieLength��5$      $��MovieLength��6(   $
��Left=�6>   $��
27,156,0,0q�6Y   $	��Top=�6m   �� 5%   
   -   5        $
 lblMovieDirector��5%      $��Movie Director��6*   $
��Left=�6C   $��25,0,0,0q�6^   $��Center=�6p   �� 5&   
   -   5        $ txtMovieDirector��5&      $
��Left=�6,   $��
27,230,0,0q�6G   $
 Wrap=�6[   $	��Top=�6�   $	��120��6�   ��6o   �� *SelectedMovie.MovieDirector+$	 PropertyChanged=�6�   �� 5'   
   -   5        $
 lblMoviePremiere��5'      $��Movie Premiere��6*   $
��Left=�6C   $��
25,264,0,0q�6^   $	��Top=�6r   �� 5(   
   -   5        $ txtMoviePremiere��5(      $
��Left=�6,   $��
25,290,0,0q�6G   $
 Wrap=�6[   $	��Top=�6�   $	��120��6�   ��6o   �� *SelectedMovie.PremiereDate+$	 PropertyChanged=�6�   �� 5)   
   -   5        $
 lblCinemaHall��5)      $��Cinema Hall��6'   $
��Left=�6=   $��
27,313,0,0q�6X   $	��Top=�6l   �� 5*   
   -   5        $ txtCinemaHall��5*      $
��Left=�6)   $��
25,337,0,0q�6D   $
 Wrap=�6X   $	��Top=�6�   $	��120��6�   ��6l   �� *SelectedMovie.CinemaHall+$	 PropertyChanged=�6�   �� 5+   
   -   5        $ btnDeleteMovie��5+      $��Delete Movie��6)   $
��Left=�6@   $��109,380,0,0q�6[   $	��Top=�6p   6�   �� 5,   
   -   5        $ btnCinemaProgram��5,      $��Open Cinema Program��6+   $
��Left=�6I   $��638,380,0,0q�6d   $	��Top=�6y   6�   5.      5/      