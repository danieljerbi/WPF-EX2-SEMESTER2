   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5      "    FlightSimulator.Views.Manual   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FlightSimulator.Views     5      .��5
      ]� .+�5   
   �� $
��Left=�6     �� Orientation$  
Horizontal=�6,   $��
0 40 10 40q�6E   .+�5      �� $��← throttle →��6   $��Center=�6:    � LayoutTransform 5      �� 5       �� Angle$ 90Q�6&   5      �� 5      -   5        $��throttleSlider��5       � Maximum$ 1Q�6+    � Minimum$ -1Q�67    �� Orientation$ Vertical=�6D    �� TickFrequency$
 0.05Q�6[    �� IsSnapToTickEnabled .  �� TickPlacement$ TopLeft=�6�   	 � Value	 5      �� *
Throttle+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=��� 5      ��6   ��  �� ElementName$ throttleSlider��$
 PropertyChanged=� �� Path$ Value� �� StringFormat$ {0:0.00}��5      �� 5   
   $��Bottom=�6   $��	0 10 40 0q�6-   .+�5      �� -   5        $��rudderValue��5      $��Right=�5   l   ��5   +   �� $ rudderSlider��$
 PropertyChanged=�$ Value�$ {0:0.00}��5   l   �� 5      -   5        $��rudderSlider��5      $ 1Q�6*   $ -1Q�66   $
 0.05Q�6C    . $ BottomRight=�6s   	 5      �� *Rudder+$
 PropertyChanged=�$ TwoWay=��� 5      $��← rudder →��6   $��Center=�68   5      �� 5#   
   $��Right=�6   $  
Horizontal=�6,   $��
10 40 0 40q�6E   .+�5$      �� -   5        $��E��5$      ��6!   �� *
Elevator+$
 PropertyChanged=�$ OneWayToSource=�$ {0:0.00}�� 5%      �� 5&      $ 90Q�6&   5(      �� 5)      $��Right=�6   $��← elevator →��6/   $��Center=�6Q    5*      �� 5+      $ 90Q�6&   5-      5.      �� 52   
   $	��top=�6   $��0 0 10 0q�6*   .+�53      �� $��← aileron →��6   $��Center=�69   �� 54      -   5        $��A��54      $��Right=�6t   ��6!   �� *	Aileron+$
 PropertyChanged=�$ OneWayToSource=�6t   55      (� 57   
   .��58      $   FlightSimulator.Views.Joystick     Aileron 6   �� $ A��$
 Text�$ OneWayToSource=�   Elevator 59      �� $ E��$
 Text�$ OneWayToSource=�5:      5<      5=      