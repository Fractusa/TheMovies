   M S B A M L   `   `   `  ����R  NTheMovies - Iteration 1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TheMovies___Iteration_1.ViewsTheMovies___Iteration_1.Views  5   	   W0clr-namespace:TheMovies___Iteration_1.ViewModels"TheMovies___Iteration_1.ViewModels  6C   4    .TheMovies___Iteration_1.Views.CinemaHallWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:TheMovies___Iteration_1.Views     5   	   G
viewmodels0clr-namespace:TheMovies___Iteration_1.ViewModels     6C   -   5          � Title$  CinemaHallWindow��5   	   $	��450��6"   $	��800��6/   .��5
      � .+�5   
   �� -   5         ��Name$ lstCinemaHalls��5      $
��Left=�6�   $	��333��6�   $��
136,54,0,0q�6�   $	��Top=�6�   $	��221��6�    J� RenderTransformOrigin$ 0.374,0.495&�6�   ��6*   �� *cinemaHallsVM+ �� SelectedItem 6P   �� *SelectedCinemaHall+ �� Mode$ TwoWay=���5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6    �� *CinemaHallNumber+�� 5      ��6    �� *
Playtime+�� 5      ��6    �� *	DateStart+�� 5      ��6    �� *	DateEnd+5      5      5      �� 5   
   -   5        $ lstMovieSchedule��5      $
��Left=�6�   $	��333��6�   $��
376,54,0,0q�6�   $	��Top=�6�   $	��231��6�   ��6,   �� *$"SelectedCinemaHall.scheduledMovies+ 6g   �� *SelectedMovie+$ TwoWay=���5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5      �� ��6    �� *%#SelectedCinemaHall.CinemaHallNumber+�� 5      ��6    �� *SelectedCinemaHall.Playtime+�� 5      ��6    �� *SelectedCinemaHall.DateStart+�� 5      ��6    �� *SelectedCinemaHall.DateEnd+5       5!      5#      �� 5$   
   -   5        $ lstMoviesToAdd��5$      $
��Left=�6   $	��253��6�   $��635,134,0,0q�6�   $	��Top=�6�   $	��137��6�   ��6*   �� *
moviesVM+ 6K   �� *SelectedMovie+$ TwoWay=���5%      �� 5&      .R�5'      �� $ 
Horizontal=�6!   .+�5(      �� ��6    �� *
MovieTitle+�� 5)      ��6    �� *
MovieGenre+�� 5*      ��6    �� *MovieLength+�� 5+      ��6    �� *MovieDirector+�� 5,      ��6    �� *PremiereDate+�� 5-      ��6    �� *
CinemaHall+5.      5/      51      �� 54   
   -   5         ��Name$ addCinemaHall��54      $��Add CinemaHall��6(   $
��Left=�6A   $��18��6\   $��	16,81,0,0q�6h   $	��Top=�6{   $	��106��6�   6�   �� 55   
   -   5        $ addMovieToSchedule��55      $��Add to schedule��6-   $
��Left=�6G   $��20��6b   $��
656,81,0,0q�6n   $	��Top=�6�   $��96��6�   $ 
1.103,1.78&�6�   6�   �� 56   
   -   5         ��Name$ playtime��56      $
��Left=�6$   $��22��6?   $��
70,144,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $��34��6�   $ 0.443,-0.188&�6�   �� 57   
   -   5        $ CinemaHallNumber��57      $
��Left=�6,   $��22��6G   $��
70,180,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $��34��6�   $ 0.443,-0.188&�6�   �� 58   
   -	   5        $ 
BackButton��58      $
��Back��6%   $
��Left=�64   $��20��6O   $��
35,367,0,0q�6[   $	��Top=�6o   $��69��6�   $ 
1.103,1.78&�6�   6�   �� 59   
   -
   5        	 ��Name$	 CinemaHallsLabel��59      $��CinemaHalls��6*   $
��Left=�6@   $��
136,23,0,0q�6[   $	��Top=�6o   $ -0.298,0.216&�6�   $��75��6�   �� 5:   
   -   5        $	 MovieScheduleLabel��5:      $��MovieSchedule��6,   $
��Left=�6D   $��
376,23,0,0q�6_   $	��Top=�6s   $ -0.298,0.216&�6�   $��94��6�   �� 5;   
   -   5        $	 PlaytimeLabel��5;      $��
Playtime: ��6'   $
��Left=�6<   $��	8,140,0,0q�6W   $	��Top=�6j   $ -0.298,0.216&�6�   $��76��6�   �� 5<   
   -   5        $	 CinemaHallNumberLabel��5<      $��Number: ��6/   $
��Left=�6B   $��	8,176,0,0q�6]   $	��Top=�6p   $ -0.298,0.216&�6�   $��76��6�   5>      5?      