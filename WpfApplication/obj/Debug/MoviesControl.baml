   M S B A M L   `   `   `  ����I  EWpfApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApplicationWpfApplication  5      A =DotNet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:DotNet;assembly=DotNetDotNet 5      "    WpfApplication.MoviesControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfApplication     5      7DotNet$clr-namespace:DotNet;assembly=DotNet     5      -   5          � 	Resources  5
         movieViewSource  movieActorsViewSource �� Source �� Source��%W   &	        &	      7   �� 5   
   6   �� 5   
    6=   �� *Actors+8   5      .��5      �  � DataContext# [  6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ movieDataGrid��5         RowDetailsVisibilityMode$ VisibleWhenSelected=�6*   $��	10,10,0,0q�6Y      EnableRowVirtualization .    AutoGenerateColumns .  $
��Left=�6�   $	��Top=�6�   $	��171��6�   $	��284��6�   ��6l   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        movieIdColumn��,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 5   <   
   Header$
 Movie Id��6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6c   �� *	MovieId+  5      -   5        titleColumn��$	 SizeToHeader 5   :   $
 Title��6O    6^   �� *Title+  5      -   5        durationColumn��$	 SizeToHeader 5   =   $
 Duration��6R    6d   �� *
Duration+  5      -   5        genreColumn��$	 SizeToHeader 5   :   $
 Genre��6O    6^   �� *Genre+  5      -   5        ageRestrictionColumn��$	 SizeToHeader 5   C   $
 Age Restriction��6X    6q   �� *AgeRestriction+5        5   
   -   5        $ actorsDataGrid��5       .   . $��10,186,0,10q�6�   $ VisibleWhenSelected=�6�   $
��Left=�6�   $	��284��6  ��6f   �� # [  5        5      -	   5        actorIdColumn��$
 Actor Id��5   X   $	 SizeToHeader 6j    6<   �� *	ActorId+6j     5      -
   5        firstNameColumn��$
 
First Name��5   \   $	 SizeToHeader 6p    6>   �� *	FirstName+6p     5      -   5        lastNameColumn��$
 	Last Name��5   Z   $	 SizeToHeader 6m    6=   �� *
LastName+6m   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        birthDateColumn��$
 
Birth Date��5   B   $	 SizeToHeader 6V      CellTemplate 5      �� 5       .R�5!      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *	BirthDate+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5"      5$      5&      �� 5'   
   $	��Id:��6   $
��Left=�6   $��
354,26,0,0q�69   $	��Top=�6M   �� 5(   
   $��Title:��6   $
��Left=�6!   $��
354,57,0,0q�6<   $	��Top=�6P   �� 5)   
   $��	Duration:��6   $
��Left=�6$   $��
354,88,0,0q�6?   $	��Top=�6S   �� 5*   
   $��Genre:��6   $
��Left=�6!   $��354,119,0,0q�6<   $	��Top=�6Q   �� 5+   
   $��Age restriction:��6   $
��Left=�6+   $��354,150,0,0q�6F   $	��Top=�6[   �� 5,   
   -   5         ��Name$ MovieId��5,      $
��Left=�6#   $��23��6>   $��
455,30,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5-   
   -   5        $ Title��5-      $
��Left=�6!   $��23��6<   $��
455,61,0,0q�6H   $
 Wrap=�6\   $	��Top=�6q   $	��120��6�   �� 5.   
   -   5        $ Duration��5.      $
��Left=�6$   $��23��6?   $��
455,92,0,0q�6K   $
 Wrap=�6_   $	��Top=�6t   $	��120��6�   �� 5/   
   -   5        $ Genre��5/      $
��Left=�6!   $��23��6<   $��455,123,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 50   
   -   5        $ AgeRestr��50      $
��Left=�6$   $��23��6?   $��455,154,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 51   
   -   5         ��Name$ Create��51      $��Create��6!   $
��Left=�62   $��315,189,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 52   
   -   5        $ Update��52      $��Update��6!   $
��Left=�62   $��416,189,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 53   
   -   5        $ Delete��53      $��Delete��6!   $
��Left=�62   $��513,189,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 54   
   -   5         ��Name$ Message��54      $
��Left=�6"   $��325,280,0,0q�6=   $	��Top=�6R   $	��273��6j   �� 55   
   $��	Id actor:��6   $
��Left=�6$   $��360,221,0,0q�6?   $	��Top=�6T   �� 56   
   -   5        $ ActorId��56      $
��Left=�6#   $��23��6>   $��455,224,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 57   
   -   5        $ AddActor��57      $��	Add actor��6#   $
��Left=�67   $��354,255,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 58   
   -   5        $ RemoveActor��58      $��Remove actor��6&   $
��Left=�6=   $��455,255,0,0q�6X   $	��Top=�6m   $��75��6�   6�   59      5:      