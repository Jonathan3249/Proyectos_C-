   M S B A M L   `   `   `  ����K  GAutomata de Pila, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Automata_de_PilaAutomata_de_Pila  5   	   !    Automata_de_Pila.MainWindow   5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Automata_de_Pila     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$  Automata de Pila��5   	   $	��470��6"   $	��720��6/    � 
ResizeMode$ NoResize=�6;    � WindowStyle$
 None=�6Q    � WindowStartupLocation$ CenterScreen=�6d   .��5      � -   5        .+�5   
   �� -   5        $��Generar��5      $
��Left=�6#   $��
585,76,0,0q�6>   $	��Top=�6R   $	��111��6j   $��22��6v   6�   �� 5   
   -   5        $��Restablecer��5      $
��Left=�6'   $��585,397,0,0q�6B   $	��Top=�6W   $	��111��6o   $��31��6{    J� RenderTransformOrigin$ 0.505,1.194&�6�   6�   �� 5   
   $��Entrada��6   $
��Left=�6"   $��	26,66,0,0q�6=   $	��Top=�6P   $	��102��6h   �� 5   
   $
��Pila��6   $
��Left=�6   $��
26,121,0,0q�6:   $	��Top=�6N   $ 1.114,2.259&�6f   $	��102��6�   �� 5   
   -   5         ��Name$ 
txtentrada��5      $
��Left=�6&   $��23��6A   $��
104,70,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��436��6�   �� 5   
   -   5        $ txtPila��5      $
��Left=�6#   $��23��6>   $��104,121,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��436��6�   {�.  6�   �� 5   
   -   5        $ txtResultado2��5      $
��Left=�6)   $	��246��6D   $��104,182,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��436��6�   �� 5   
   -   5         ��Name$ txtResultado��5      
���   �$��1q�6;   $
��Left=�6O   $	��247��6j   $��115,181,0,0q�6w   $	��Top=�6�   $	��436��6�   $ 0.5,0.5&�6�   {�.  6�   �� 5   
   -   5        $��Ejecutar��5      $
��Left=�6$   $��585,126,0,0q�6?   $	��Top=�6T   $	��111��6l   $��24��6x   6�   �� 5   
   -	   5        $��
statusBar1��5   O   $��27��6   $
��Left=�6    $��
26,433,0,0q�6;   $	��Top=�6a   $	��667��6y   
������ .@�5      �� -
   5         ��Name$ label3��5   S   $��Estado: listo��6   $��28��6,   $
��Left=�68   $	��Top=�6c   $��Roboto)�6{   $��14(�6�   $
��Bold"�6�   5      (  "MaterialDesignThemes.Wpf.ColorZone  5   
   	   Mode$	 PrimaryDark=�6#   
����� �.��5      �� $��Right=�6   .+�5      �� -   5        $��30��5      $��30��6$   +  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth3=�60   $��0q�6a   ���	#FFB9AFCB
����� �.��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=null]]   Kind$ WindowClose=�6.   
����� �6A   5       5!      5#      �� 5$   
   $
��Left=�6   $��	26,10,0,0q�6/   $
��Wrap=�6B   $��Autómata de Pila��6V   $	��Top=�6n   $	��223��6�   $��16(�6�   5'      5(      