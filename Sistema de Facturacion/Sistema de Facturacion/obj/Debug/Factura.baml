   M S B A M L   `   `   `  ����Q  MSistema de Facturacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Sistema_de_FacturacionSistema_de_Facturacion  5   	   $    Sistema_de_Facturacion.Factura   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Sistema_de_Facturacion     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$  Factura��5   	   $	��540��6   $	��600��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � WindowState$ Normal=�6m    � WindowStyle$
 None=�6�   .��5      � .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryDark=�6#   ���	#FF474E51.��5      �� $��Right=�6   .+�5      �� -   5        $��30��5      $��30��6$   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�60   $��0q�6a   ���	#FFB9AFCB���	#FF50495B.��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�6.   ���	#FF4F4A4A6A   5      5      5      �� 5   
   $
��Left=�6   $��10,3,0,0q�6/   $
��Wrap=�6A   $��Factura��6U   $	��Top=�6d   $��98��6|   $��24��6�   ���	#DDDEC9C9$��18(�6�   �� 5   
   -   5        $��ok��5      $��Ok��6   $
��Left=�6(   $��500,475,0,0q�6C   $	��Top=�6X   $��75��6p   $��24��6{    J� RenderTransformOrigin$ 	2.2,0.917&�6�   6�   �� 5   
   ���	#FFA29393$��1q�6)   $
��Left=�6=   $	��295��6X   $��
22,152,0,0q�6e   $	��Top=�6y   $	��542��6�   �� 5   
   $	��Nit��6   $
��Left=�6   $��	22,52,0,0q�69   $	��Top=�6L   �� 5   
   -   5        $	��nit��5      $
��Left=�6   $��23��6:   $��	65,47,0,0q�6F   $	��Top=�6Y   $	��186��6q   	 �� 	MaxLength$	 10��6}   
 �� TextWrapping$
 WrapWithOverflow=�6�    �� AcceptsReturn . 6�   �� 5   
   $��	Direccion��6   $
��Left=�6$   $��
22,111,0,0q�6?   $	��Top=�6S   �� 5    
   -   5        $��	direccion��5       $
��Left=�6#   $��23��6>   $��
97,107,0,0q�6J   $

 Wrap=�6^   $	��Top=�6r   $	��467��6�   {�.  6�   �� 5!   
   $��Detalle��6   $
��Left=�6"   $��
33,152,0,0q�6=   $	��Top=�6Q   $��29��6i   &   System.Windows.Controls.DataGrid  5"   
   -   5        $��MostrarDatos��5"      $
��Left=�6'   $	��255��6B   $��
32,181,0,0q�6O   $	��Top=�6c   $	��521��6{      SelectionMode$ Single=�6�   $ 0.5,0.5&�6�   z�5#      V� 5$      .~�5%      �� �� 5&      �� 5'       �� Angle$ -0.231Q�6&   T� 5(      5)      5-      �� 5.   
   -   5        $��	consultar��5.      $��	Consultar��6"   $
��Left=�66   $��
271,40,0,0q�6Q   $	��Top=�6e   $��93��6}   $��30��6�   6�   �� 5/   
   $��Nombre��6   $
��Left=�6!   $��	22,84,0,0q�6<   $	��Top=�6O   �� 50   
   -   5        $��nombre��50      $
��Left=�6    $��23��6;   $��	97,79,0,0q�6G   $

 Wrap=�6Z   $	��Top=�6n   $	��467��6�   {�.  6�   52      53      