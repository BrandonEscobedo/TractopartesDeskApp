   M S B A M L   `   `   `  ����N  JTractopartesDeskApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:TractopartesDeskApp.Views.UserControls&TractopartesDeskApp.Views.UserControls  5   	   M+clr-namespace:TractopartesDeskApp.VIewModelTractopartesDeskApp.VIewModel  5   	   /    )TractopartesDeskApp.Views.ProveedoresView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ccd4clr-namespace:TractopartesDeskApp.Views.UserControls     5   	   A	viewModel+clr-namespace:TractopartesDeskApp.VIewModel     5   	   $	��450��5   	   $	��700��6   $	��450��6"   $	��700��5   	     � WindowStyle$
  none=�6    � WindowStartupLocation$ CenterScreen=�6+    � AllowsTransparency$
 True��5   	   
������  � DataContext 5	      <  6TractopartesDeskApp.VIewModel.WindowProveedorViewModel  5
   
   5      '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 5q�6)   .��5      �� -   5         �� CornerRadius$ 5��5      
�������._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   	 � RowDefinitions	 5      �� 5      $��45 �6    �� 5      $
��226* �6    �� 5      $
��174* �6    �� 5      $��5* �6    .+�5       �� $��1��6   $��2��6"   $��
10,10,10,5q�64   ._�5"      � $��Center=�6   	 5#      �� 5$      $��* �6(   .+�5'      �� $ 0 0 0 5��6   ._�5(      � $��Center=�6   .+�5)      �� $ 7��6%   ���#ffffff
 J� Effect
 5*   "   3  -System.Windows.Media.Effects.DropShadowEffect  5+   &      
BlurRadius$ 30Q�67      ShadowDepth$ 5Q�6G      	Direction$
 -130Q�5,   /      Opacity$	 0.1Q�6@   ._�5.   "   � 	 5/   &   �� 50   *   $
��auto �68   �� 51   *   $
��auto �68   �� 52   *   $
��auto �68   �� 53   *   $
��auto �68   �� 54   *   $
��auto �68   �� 55   *   $
��auto �68    58   &   �� 59   *   $��* �6;   �� 5:   *   $��* �6;   .+�5<   &   ��  �� Orientation$ 
Horizontal=�61   $��	20 20 0 0q�6J   .+�5=   *   �� $ 50��61   $	��1.5q�6C   $��0 0 0 3q�6Y   ���#efefef._�5>   .   A� $��40��66   $��40��6A   ��5?   2   �� 5@   6    �� ImageSource$x rC:\Users\jesus\OneDrive\Documentos\programas c#\TractopartesDeskApp\TractopartesDeskApp\Data\Imagenes\supplier.png��6A   5B   /   5C   +   �� 5D   *   $��Agregar Cliente��64   $��18(�6K   $��15 0 0 3q�6Y   $��Center=�5E      5F   '   5   /TractopartesDeskApp.Views.UserControls.MyTexBox  5I   &   $��0��63   $��1��6C      Caption$ Nombre de la empresa��6Q      Hint$. (Ingresa el nombre completo de la empresa��6p      ValueDb 6�   �� *NombreEmpresa+ �� Mode$ TwoWay=�  5J   &   $��1��63   $��1��6C   $ Razón social��6P   $  ��6g    6o   �� *RazonSocial+$ TwoWay=�  5K   &   $��0��63   $��2��6C   $ 	Direccion��6P   $1 +Av mexico calle 31, No. #413, Guadalupe N.L��6d    6�   �� *	direccion+$ TwoWay=�  5L   &   $��1��63   $��2��6C   $ Correo��6P    6b   �� *Correo+$ TwoWay=�  5M   &   $��0��63   $��3��6C   $ 
Telefono 1��6P    6f   �� *
Telefono+$ TwoWay=��� 5N   &   $��3��6-   $��2��6:   $��80��6N   ���#f6f6f6$ 	0 0 10 10��5O   "   $��0,81,0,0q�5P      $��2��6   �� 5S   &   -   5        $��1��5S   -   $��3��6=   $��Guardar��6J   $��0,104,13,17q�6\   $��Right=�5T         
mainbutton#��[  6)   ��5U      �� *AddProveedorCommand+ �� UpdateSourceTrigger$ PropertyChanged=�
 5X   *     5Y   .   $ 10Q�6?   $ 5Q�6O      Color$ #4880ff��6_   $	 0.3Q�5Z      $
 -120Q�6-   5\   '   �� 5]   &   -   5        $��Salir��5]   -   $��3��6=   $
��Left=�6J   $��21,101,0,20q�6e   $	��150��6z     
SendButton#��[ 6�   6�   5^   #   5_      5`      5a      5c      5e      5f      5g      5h      