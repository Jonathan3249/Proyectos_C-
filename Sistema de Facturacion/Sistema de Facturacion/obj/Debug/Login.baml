   M S B A M L   `   `   `  ����Q  MSistema de Facturacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Sistema_de_FacturacionSistema_de_Facturacion  5   	   '    !Sistema_de_Facturacion.MainWindow   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Sistema_de_Facturacion     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$  
MainWindow��5   	   $	��350��6    � AllowsTransparency . $	��400��6C    � WindowStartupLocation$ CenterScreen=�6O    � WindowStyle$
 None=�6t    � 
ResizeMode$ NoResize=�6�   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
������ ._�5      � .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryDark=�6+   ���	#FF474E51.��5      �� $��Right=�6!   .+�5      �� -   5        $��30��5   !   $��30��6,   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�68   $��0q�6i   ���	#FFB9AFCB���	#FF50495B.��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�66   ���	#FF4F4A4A6I   5      5      5       5"      5#      � 5$   
   $��1��6   	 � ColumnDefinitions	 5%      �� 5&      $	��11* �6#   �� 5'      $��5* �6#   .+�5)        $ 
PrimaryMid=�6'   ���	#FF556362$��2��6P   $��63��6d   .��5*      �� $��Sistema de Facturacion��6   $��19(�6:   $
��Left=�6H   $��Bottom=�6c   $��	26,0,0,20q�6~   5,      5.      � 5/   
   $��1��6   $��	0,61,0,39q�6   $��2��6/   .+�50      �� 
 �� Orientation$
 Vertical=�6   $��40,20,0,-38q�60   .+�51      �� $
 
Horizontal=�6   .+�52        $ Account=�6.   $��Bottom=�6~   $	��0 4q�6�   ��6=   ��  �� ElementName$ txt_usuario�� �� Path$ BorderBrush�6�   �� 53      -   5         ��Name$ txt_usuario��53      $	��300��63   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuario��6?      
IsFloating . 6h   55      �� 56      $
 
Horizontal=�6   $
��0 30q�66   .+�57        $	 key=�6.   $��Bottom=�6z   $	��0 4q�6�   ��69   �� $ txt_usuario��$ BorderBrush�6�   G� 58      -   5         G�Name$ txt_contrasena��58   "   $	��300��6:   $ Password��6F    . 6p   5:      �� 5;      $��Recordar Password��6   $��	0 30 0 0 q�67   5<      �� 5=      -   5         ��Name$ 
btnIniciar��5=        MaterialDesignRaisedButton#���  6)   $��Ingresar��6_   $
��Left=�6r   $��264,197,0,-14q�6�   $��96��6�   ���	#FF6A6C6A J� RenderTransformOrigin$ 0.26,-0.534&�6�   $
��Auto��6�   6�   5>      5C      5D      