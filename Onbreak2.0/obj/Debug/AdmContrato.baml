   M S B A M L   `   `   `  ����E  AOnbreak2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Onbreak2._0Onbreak2._0  5   	       Onbreak2._0.AdmContrato   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Onbreak2._0     5   	     � Title$  AdmContrato��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� $��Nro Contrato��6   $
��Left=�6'   $��	10,14,0,0q�6B   $	��Top=�6U   �� 5   
   $��	Creación��6   $
��Left=�6#   $��	10,57,0,0q�6>   $	��Top=�6Q    J� RenderTransformOrigin$ 0.158,0.615&�6i   �� 5   
   $��
Dirección��6   $
��Left=�6$   $��
11,136,0,0q�6?   $	��Top=�6S   �� 5   
   $��Vigencia��6   $
��Left=�6#   $��
11,173,0,0q�6>   $	��Top=�6R   �� 5   
   $��Observaviones��6   $
��Left=�6(   $��
11,264,0,0q�6C   $	��Top=�6W   �� 5   
   $��Termino��6   $
��Left=�6"   $��	11,96,0,0q�6=   $	��Top=�6P   �� 5   
   -   5         ��Name$ txtNroContrato��5      $
��Left=�6*   $��23��6E   $��
125,18,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $��TextBox��6y   $	��Top=�6�   $	��120��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
dpCreacion��5      $
��Left=�6)   $��
125,59,0,0q�6D   $	��Top=�6X      SelectedDateFormat$
 Long=�6p     5   
   -   5        $ 	dpTermino��5      $
��Left=�6(   $��
125,98,0,0q�6C   $	��Top=�6W   �� 5   
   -   5        $ txtDireccion��5      $
��Left=�6(   $��23��6C   $��125,139,0,0q�6O   $
 Wrap=�6d   $��TextBox��6x   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $ txtObsv��5      $
��Left=�6#   $��23��6>   $��125,267,0,0q�6J   $
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ 
btnAgregar��5      $��Agregar��6%   $
��Left=�67   $��
355,17,0,0q�6R   $	��Top=�6f   $��75��6~   6�   �� 5   
   -   5        $ btnEliminar��5      $��Eliminar��6&   $
��Left=�69   $��
451,18,0,0q�6T   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ btnModificar��5      $��	Modificar��6'   $
��Left=�6;   $��
546,17,0,0q�6V   $	��Top=�6j   $��75��6�   6�   �� 5   
   -	   5        $ 	btnBuscar��5      $��Buscar��6$   $
��Left=�65   $��
355,52,0,0q�6P   $	��Top=�6d   $��75��6|   6�   �� 5   
   -
   5        $ btnLista��5      $��Lista��6#   $
��Left=�63   $��
451,52,0,0q�6N   $	��Top=�6b   $��75��6z   6�   �� 5   
   -   5         ��Name$ 
cbVigencia��5      $��CheckBox��6'   $
��Left=�6:   $��125,187,0,0q�6U   $	��Top=�6j   �� 5   
   $�� ��6   $
��Left=�6   $��	661,0,0,0q�66   $	��Top=�6I   $��83��6a   $	��131��6m   ��5      �� 5       �� ImageSource$. (imagenes/logo_transparent_background.png��6   5      5!      5"      