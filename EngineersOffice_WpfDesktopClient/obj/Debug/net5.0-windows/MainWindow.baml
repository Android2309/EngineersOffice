   M S B A M L   `   `   `  ����[  WEngineersOffice_WpfDesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:EngineersOffice_WpfDesktopClient EngineersOffice_WpfDesktopClient  5   	   1    +EngineersOffice_WpfDesktopClient.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:EngineersOffice_WpfDesktopClient     5   	     � Title$  	EO_Client��5   	   $	��450��6   $	��800��6(    � WindowStartupLocation$ CenterScreen=�64    � 	Resources 5	       �� 
TargetType 
  button �� Property �� Value��%X   &	        �� 5
   
   " ��6   .�5      ��  � ��$ 0 10 0 0q�6'   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   $	��180��6)   �� 5      $
��Auto �6   �� 5      $��4* �6   $	��150��6*    � RowDefinitions 5   
   �� 5      $��25 �6   6*   �� 5      $��50��6   �� 5      $	��110 �6   6+   .+�5   
   �� $��1��6   $��3��6(    �� ShowsPreview$ False��69   $��3��6N   $��Center=�6X   o� 5   
   -   5        	 o�Name$
	 Menu��5      $��3��6   $��0��61   ���	#FF4E4C4C.@�5      m� $��Файл��6   $��25��6%   
�������.@�5      m� -   5        
 m�Name$
 menuExit��5      $��
Выход��6-   ���	#FF4E4C4C$��0q�6T   5       m� 5!      -   5        $
 menuHelp��5!      $��Справка��6)   
�������6:   5"      ]� 5%   
   $��0��6   $��1��6$   $��2��61   
�������.+�5&      �� $	��Top=�6   $��16(�6-   Базa данных:5(      R� 5)      -   5         R�Name$ treeView��5)      $	��Top=�6)   $��0q�6>   
�������.@�5*      Q� $��Библиотека��6   .@�5+      Q� -   5         Q�Name$ tvBeams��5+   #   $��Двутавры��64   Q� 5,      -   5        $ tvSteels��5,   #   $#��Марочник сталей��65   Q� 5-      -   5        $ tvBendingCoeffs��5-   #   $+��%Коэффициенты изгиба��6<   5.      5/      �� 50      $��Bottom=�6    �� Orientation$ Vertical=�61   $��Bottom=�6H   $	��110��6c   .+�51      �� -   5         ��Name$ btnAdd��51      $��Добавить��6*     ButtonStyle#��[ 6=   $��0 10 0 0q�6b   �� 52      -	   5        $ btnEdit��52      $��Изменить��6*   #��[ 6=   $��0 10 0 0q�6b   �� 53      -
   5        $ 	btnDelete��53      $��Удалить��6,   #��[ 6>   $��0 10 0 0q�6c   54      55      &   System.Windows.Controls.DataGrid  57   
   -   5          Name$ dataGrid��57      $��3��6%   $��1��66   
�������$��2��6Z   $��3,0,0,0q�6n   5:      5;      