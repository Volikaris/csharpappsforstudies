   M S B A M L   `   `   `  ����  Zad4    Zad4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$   Zajęcia 5: Okna dialogowe��5      $	��300��6'   $	��500��64   .��5      � $��3q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5	      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��3q�6   $��3��6   .��6/   Lista użytkowników6C   �� 5   
   -   5         ��Name$
 exit��5      $��3q�6   $��3q�6*   $��2��66   $��3��6C   .��6g   	Zamknij6p   �� 5   
   $��3q�6   $��2��6    $��1��60   .+�5      �� -   5        $��3q�5      $
��10,3q�6    .��6>   
Dodaj...6H   �� 5      -   5        $ 	delButton��5      $��3q�6(   $
��10,3q�63   {�.  .��6b   Usuń6h   �� 5      -   5        $ 
editButton��5      $��3q�6)   $
��10,3q�64   {�.  .��6d   	Edytuj...6o   �� 5      -   5        $ 
viewButton��5      $��3q�6)   $
��10,3q�64   {�.  .��6e   Podgląd...6q   5      �� 5   
   -   5         ��Name$ 	usersList��5      $��3q�6%   $��1��60   6=   �� 5   
   $��1��6   $��1��6'   $��5��64    �� ResizeDirection$ Columns=�6>   $��Center=�6X   5      5      