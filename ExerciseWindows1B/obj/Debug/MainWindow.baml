   M S B A M L   `   `   `  ����L  HExerciseWindows1B, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ExerciseWindows1BExerciseWindows1B  5   	   "    ExerciseWindows1B.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ExerciseWindows1B     5   	     � Title$  Consultation Queues��5   	   $	��450��6%   $	��350��62   .��5	      � $
��20pxq�6   $��Center=�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��200px �6   .+�5   
   �� -   5        $��1��5      .��6:   %#Sign up for doctor’s consultation6]   �� 5   
   $��2��6   .��6   Patient Name:6,   �� 5   
   $��3��6    �� TextWrapping$
 Wrap=�6   ��63   ��  �� Path$ patient� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��4��6   .��6   
Concern:6'   �� 5   
   $��5��6   $
 Wrap=�6   ��63   �� $ concern�$ TwoWay=�$ PropertyChanged=��� 5   
   $��6��6   6   �� 5   
   -   5        $��7��5      .��66   
Enter room6B   �� 5    
   -   5        $��8��5       .��6>   Begin consultation6R   �� 5!   
   -   5        $��9��5!      .��68   Closing time6F   �� 5"   
   -   5        $��10��5"      .��6=   Exit6C   �� 5$   
   $��11��6   $��Center=�6   $��Center=�69   $��Center=�5%      $
��Bold"�5&      
�������$��100px��5'      $��250px��6   ��6-   �� $ labelContent�6U   5(      5)      