   M S B A M L   `   `   `  ����N  JTractopartesDeskApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:TractopartesDeskApp.Views.UserControls&TractopartesDeskApp.Views.UserControls  5   	   M+clr-namespace:TractopartesDeskApp.VIewModelTractopartesDeskApp.VIewModel  5   	   ,    &TractopartesDeskApp.Views.UsuariosView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Ccd4clr-namespace:TractopartesDeskApp.Views.UserControls     5   	   A	viewModel+clr-namespace:TractopartesDeskApp.VIewModel     5   	   $	��850��5   	   $	��750��6   $	��850��6"   $	��650��5   	     � WindowStyle$
  none=�6    � WindowStartupLocation$ CenterScreen=�6+    � AllowsTransparency$
 True��5   	   
������ '  !System.Windows.Shell.WindowChrome   WindowChrome 5
        5   
      CaptionHeight$ 0Q�6      ResizeBorderThickness$ 5q�6)   .��5      �� -   5         �� CornerRadius$ 5��5      
�������._�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��45 �6    �� 5      $
��232* �6    �� 5      $��3* �6    .+�5      �� $��1��6   $��2��6"   ._�5      � $��Center=�6   $��10 10 10 10q�62    5      �� 5      $��* �6(   .+�5!      �� $ 0 0 0 5��6   ._�5"      � $��Center=�6    $��	22,0,17,0q�6;   $	��680��6N   .+�5#      �� $ 7��6%   ���#ffffff$��0,-54,0,-60q�6K   	 J� Effect	 5$   "   3  -System.Windows.Media.Effects.DropShadowEffect  5%   &   
   
BlurRadius$
 30Q�67      ShadowDepth$ 5Q�6G      	Direction$
 -130Q�5&   /      Opacity$	 0.1Q�6@   ._�5(   "   �  5)   &   �� 5*   *   $
��auto �68   �� 5+   *   $
��auto �68   �� 5,   *   $
��auto �68   �� 5-   *   $
��auto �68   �� 5.   *   $
��auto �68   �� 5/   *   $
��auto �68   �� 50   *   $
��auto �68   �� 51   *   $
��auto �68   �� 52   *   $
��auto �68    54   &   �� 55   *   $��* �6;   �� 56   *   $��* �6;   .+�58   &   ��  �� Orientation$ 
Horizontal=�61   $��	20 20 0 0q�6J   .+�59   *   �� $ 50��61   $	��1.5q�6C   $��0 0 0 3q�6Y   ���#efefef._�5:   .   A� $��40��66   $��40��6A   ��5;   2   �� 5<   6    �� ImageSource$v pC:\Users\jesus\OneDrive\Documentos\programas c#\TractopartesDeskApp\TractopartesDeskApp\Data\Imagenes\people.png��6A   5>   /   5?   +   �� 5@   *   $��Agregar Cliente��64   $��18(�6K   $��15 0 0 3q�6Y   $��Center=�5A      5B   '   5   /TractopartesDeskApp.Views.UserControls.MyTexBox  5E   &   -   5          Name$ 
txtnombres��5E   2   $��0��6F   $��1��6V      Caption$ Nombres��6d      Hint$ Ingresa  los nombres��6v      ValueDb 6�   �� *	P_nombres+ �� Mode$ TwoWay=�  5F   &   -   5        $ txtapellidoPaterno��5F   2   $��1��6N   $��1��6^   $ Apellido Paterno��6k   $ Apellido paterno��6�    6�   �� *P_apellidopaterno+$ TwoWay=�  5G   &   -   5        $ txtapellidoMaterno��5G   2   $��0��6N   $��2��6^   $ Apellido Materno��6k   $ Apellido materno��6�    6�   �� *P_apellidomaterno+$ TwoWay=�  5H   &   -   5        $ 	txtgenero��5H   2   $��1��6E   $��2��6U   $ Genero��6b    6t   �� *
P_genero+$ TwoWay=�  5I   &   -   5        $ txtelefono1��5I   2   $��0��6G   $��3��6W   $ 
Telefono 1��6d    6z   �� *	Telefono1+$ TwoWay=�  5J   &   -   5        $ txtelefono2��5J   2   $��1��6G   $��3��6W   $ 
Telefono 2��6d    6z   �� *	Telefono2+$ TwoWay=�  5K   &   -   5        $ email��5K   2   $��0��6A   $��4��6Q   $ Email��6^   $ user@example.com��6n    6�   �� *Email+$ TwoWay=�  5M   &   -	   5        $ textBoxCalle��5M   2   $��0��6I   $��5��6Y   $ Calle��6f     5N   &   -
   5        $ textBoxNumeroInterior��5N   2   $��1��6Q   $��5��6a   $ Número interior��6n     5O   &   -   5        $ textBoxNumeroExterior��5O   2   $��0��6Q   $��6��6a   $ Número exterior��6n     5P   &   -   5        $ textBoxColonia��5P   2   $��1��6J   $��6��6Z   $ Colonia��6g   $  ��6y     5Q   &   -   5        $ textBoxCodigoPostal��5Q   2   $��0��6O   $��7��6_   $ Codigo Postal��6l     5R   &   -   5        $ textBoxEstado��5R   2   $��1��6I   $��7��6Y   $ Estado��6f     5S   &   -   5        $ textBoxCiudad��5S   2   $��0��6I   $��8��6Y   $ Ciudad��6f   �� 5U   &   $��Ocoltar datos fiscales��6,   $��1��6M   $��4��6]   $
��Left=�6j   $��Bottom=�5V   ,   $��
148,0,0,80q�6G   $��2��6[   �� 5W   &   -   5         ��Name$
 cbox��5W   /   $��50 0 0 0q�6=   $��1��6P   $��4��6`   $��Right=�6m   $��Bottom=�5X   /   $��0,0,6,6q�6J   6[   �� 5Y   &   $��8��6-   $��2��6:   $��80��6N   ���#f6f6f6$ 	0 0 10 10��5Z   "   $��0,81,0,0q�5[      $��2��6   �� 5^   &   -   5        $��1��5^   -   $��9��6=   $��Guardar��6J   $��0,104,13,17q�6\   $��Right=�5_         
mainbutton#��[  6)   ��5`      �� *AddUserCommand+ �� UpdateSourceTrigger$ PropertyChanged=�	 5a   *     5b   .   $
 10Q�6?   $ 5Q�6O      Color$ #4880ff��6_   $	 0.3Q�5c      $
 -120Q�6-   5e   '   �� 5f   &   -   5        $��Salir��5f   -   $��9��6=   $
��Left=�6J   $��21,101,0,20q�6e   $	��150��6z     
SendButton#��[ 6�   6�   5g   #   5h      5i      5j      5l      5n      5o      5p      5q      