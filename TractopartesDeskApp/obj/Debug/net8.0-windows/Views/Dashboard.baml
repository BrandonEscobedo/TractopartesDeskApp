   M S B A M L   `   `   `  ����N  JTractopartesDeskApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TractopartesDeskApp.ViewsTractopartesDeskApp.Views  5   	   M+clr-namespace:TractopartesDeskApp.VIewModelTractopartesDeskApp.VIewModel  5   	   _4clr-namespace:TractopartesDeskApp.Views.UserControls&TractopartesDeskApp.Views.UserControls  5	   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5
   	   )    #TractopartesDeskApp.Views.Dashboard   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TractopartesDeskApp.Views     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   ;	viewModel+clr-namespace:TractopartesDeskApp.VIewModel  5   	   =uc4clr-namespace:TractopartesDeskApp.Views.UserControls  5	   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5
   	     � Title$  
MainWindow��5   	   $	��800��6   $
��1500��6)    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 20��6    �� Padding$ 20q�6   ���#f7f6f4._�5   
   �  � ColumnDefinitions 5      �� 5      $	��250 �6#   �� 5      $��* �6#   .+�5      �� $ 25��6   $��0��5      $��12q�5      ��5      �� 5       �� 
StartPoint$	 0,0&�6*    �� EndPoint$ 1,0.7&�6;   .��5       � 	 � Color$	 #fb7154��6'   
 � Offset$
 0Q�67   � 5!      $	 #fb6161��6'   $	
 0.8Q�67   5"      ._�5$      �� .+�5'      ��  �� Orientation$ 
Horizontal=�6!   $��Center=�5(      $��	0 30 0 10q�5)   !   .+�5*      � .+�5+      �� ���#ffffff$��60��6:   $��60��5,   %   $ 50��61    J� Effect 5.   "   3  -System.Windows.Media.Effects.DropShadowEffect  5/   &      
BlurRadius$ 10Q�67      Opacity$	 0.3Q�6G   ._�52   "   �� $��60��6(   $��60��63   $u��oC:\Users\jesus\OneDrive\Documentos\programas c#\TractopartesDeskApp\TractopartesDeskApp\Data\Imagenes\logo2.png��6?   53      55      �� 57      $��Center=�6$   $��Center=�6B   $��Tractopartes MVG��6]   ���#ffffff$��19(�6�   $��7 0 0  3q�58       59        5:   "   $ 10Q�63   $	 0.3Q�6C   5<      5=      	� 5?      -   5         	�Name$ ProveedoresPanel��5?   "      
menuButton#��[  6<    
 color1
 � Tag# [ 5@      .��5B      �� $ 
Horizontal=�6%   .+�5C      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=�6+     menuButtonIcon#��[ 67   �� 5D      $��	Dashboard��6(     menuButtonText#��[ 69   
�������6a   5E      5F      	� 5H      -   5        #��[  5H   "    
 color3# [ 5I      .��5K      �� $ 
Horizontal=�6%   .+�5L        $ Truck=�6+   #��[ 68   �� 5M      $��Provedor��6(   #��[ 68   
�������6`   5N      5O      	� 5Q      -   5        #��[  5Q   "    
 color4# [ 5R      .��5T      �� $ 
Horizontal=�6%   .+�5U        $	 Box=�6+   #��[ 66   �� 5V      $��Stock��6(   #��[ 65   
�������6]   5W      5X      	� 5Z      -   5        #��[  5Z   "    
 color6# [ 5[      .��5]      �� $ 
Horizontal=�6%   .+�5^        $ 
Registered=�6+   #��[ 6=   �� 5_      $��	 Clientes��6(   #��[ 69   
�������6a   5a      5b      	� 5d      -   5        $ rbproductos��5d   "   #��[  67    
 color9# [ 5e      .��5g      �� $ 
Horizontal=�6%   .+�5h        $ Building=�6+   #��[ 6;   �� 5i      $��	Productos��6(   #��[ 69   
�������6a   5j      5k      	� 5l      #��[  6"     color15# [ 5m      .��5o      �� $ 
Horizontal=�6%   .+�5p        $ Store=�6+   #��[ 68   �� 5q      $��Generar venta��6(   #��[ 6=   
�������6e   5r      5s      	� 5t      -   5        #��[  5t   "    	 color16# [	 5u      .��5w      �� $ 
Horizontal=�6%   .+�5x        $ Adjust=�6+   #��[ 69   �� 5y      $��
Categorias��6(   #��[ 6:   
�������6b   5z      5{      5~      5      �� 5�      ���#ffffff$ 12��6*   $��1��5�      ._�5�      �  � RowDefinitions 5�      �� 5�      $��40 �6(   �� 5�      $��35 �6(   �� 5�      $��* �6(   .+�5�      �� -   5         ��Name$ pnlControlBAR1��5�   "   $��0��5�      $ 
Horizontal=�5�      $��RightToLeft=�5�      
������ $��0 0 5 0q�5�      .+�5�      �� -   5         ��Name$ 	btnClose1��5�   !    
 controlButton#��[
 5�        color11# [ 5�      .��5�        $ Xmark=�6+     controlButtonIcon#��[ 68   5�      �� 5�      -	   5        $ btnMaximize1��5�   !   #��[
 5�        color12# [ 5�      .��5�        $ WindowMaximize=�6+   #��[ 6A   5�      �� 5�      -
   5        $ btnMinimize1��5�   !   #��[
 5�       
 color8# [ 5�      .��5�        $ WindowMinimize=�6+   $��12��6A   #��[ 6L   5�      5�      � 5�      $��1��6    5�      �� 5�      �� 5�      .+�5�      �� $��0��6%   $ 
Horizontal=�5�      $��Center=�5�      .+�5�        $
 Home=�6+   $��30��5�      $��30��5�        titleColor2   
Foreground# [ 5�      $��	35 0 10 0q�5�      �� 5�      -   5        $��txtitulo��5�   (   $��	Dashboard��5�   (   #��[ 5�      $��30(�5�      $��	Monserrat)�5�      $��Medium"�5�      $��Center=�5�      5�      5�      � 5�      -   5         �Name$ gridContainer��5�   (   $��2��6   .+�5�      �  5�      �� 5�   "   $��* �60   .+�5�      � $��0��6#    5�   "   �� 5�   &   $
��auto �67   �� 5�   &   $��* �67   �� 5�   &   $	��200 �67   .+�5�   "   �� $��2��6-   $��5 5 5 5q�6=   .+�5�   &   �� -   5         ��Name$ BtnContentContainer��5�   6   5�   #   � 5�   "   $��0��6'    5�   &   �� 5�   *   $	��600 �6;   .+�5�   &   � $��0��6+    5�   *   �� 5�   .   $	��200 �6<   �� 5�   .   $��* �6<   .+�5�   *   #  LiveCharts.Wpf.CartesianChart  $��
5 40  0 60q�6>   $��1��6R   &   LiveCharts.Wpf.Charts.Base.Chart   ScrollBarFill
 ���� $��0��5�   >      LegendLocation$
 None=�6N      DataTooltip 5�   .   #  LiveCharts.Wpf.DefaultTooltip  5�   2   
���  ��6E      AxisX 5�   2     LiveCharts.Wpf.Axis     
ShowLabels$
 True��6;      
Foreground �#90a3b25�   3      Series 5�   2     LiveCharts.Wpf.LineSeries  	  LiveCharts.Wpf.Series 	  Values;
  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 50,120,160,15,180
 6A     	  Stroke  5�   6   �� 5�   :   .��5�   >   � $	 #ffffff��6K   � 5�   >   $		 Red��6K   � 5�   >   $	 	AliceBlue��6K   5�   ;   5�   3     5�   2   $ 120,56,80,100,60
 6A     5�   6   �� 5�   :   .��5�   >   � $	 Purple��6K   � 5�   >   $	 Bisque��6K   � 5�   >   $	 DarkBlue��6K   5�   ;   5   3     5  2   $ 310,20,80,100,240
 6A     5  6   �� 5  :   .��5  >   � $		 Red��6K   � 5  >   $	 Green��6K   � 5  >   $		 Red��6K   5  ;   5	  3   5  +   5  '   5  #   5      � 5     -   5        !  �Name$! MainContainerPage��5  $   $��1��6?   "  � NavigationUIVisibility$" Hidden=�6L   5     5     5     5     5     5     5     