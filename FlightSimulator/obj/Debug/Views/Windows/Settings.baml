   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:FlightSimulator.Views.WindowsFlightSimulator.Views.Windows  5   	   ,    &FlightSimulator.Views.Windows.Settings   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:FlightSimulator.Views.Windows     5   	     � Title$  Settings��5   	   $	��250��6   $	��450��6'   .��5	      � $��14(�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ��  �� Padding$ 3q�6   $��3q�6    Flight Server IP:5      �� 5   
   -   5         ��Name$ txtMazeName��5      $��1��6'   $��3q�67   $��	10,6,10,0q�6C   ��6V   �� *FlightServerIP+.��6x   5      �� 5   
   $��1��6   $ 3q�6!   $��3q�6-   Flight Info Port:5      �� 5   
   -   5        $ txtRows��5      $��1��6#   $��1��60   $��3q�6@   $��	10,6,10,0q�6L   ��6_   �� *FlightInfoPort+.��6�   5      �� 5   
   $��2��6   $ 3q�6!   $��3q�6-   Flight Command Port:5      �� 5   
   -   5        $ txtCols��5      $��2��6#   $��1��60   $��3q�6@   $
��10,3q�6L   ��6Z   �� *FlightCommandPort+.��6   5      �� 5    
   -   5         ��Name$ OK��5       $��3��6   $��Center=�6K   $��103,21,269,-11q�6h   $��5q�6�   $��70��6�    J� RenderTransformOrigin$ -0.016,0.567&�6�   $��2��6�   ��6*   �� *ClickCommand+.��6�   OK5!      �� 5"   
   -   5        $ Cancel��5"      $��3��6C   $��Center=�6P   $��64,21,161,-11q�6m   $��5q�6�   $��1��6�   $��70��6�   $��Cancel��6�   $ 0.016,0.502&�6�   ��6!   �� *CancelCommand+6�   5#      5$      