   M S B A M L   `   `   `  ����[  WEngineersOffice_WpfDesktopClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:EngineersOffice_WpfDesktopClient.Windows(EngineersOffice_WpfDesktopClient.Windows  5   	   B    <EngineersOffice_WpfDesktopClient.Windows.AddSteelGradeWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:EngineersOffice_WpfDesktopClient.Windows     5   	     � Title$!  Добавить сталь��5   	   $	��300��6    $	��400��6-   $	��300��69   $	��400��6I    � WindowStartupLocation$ CenterScreen=�6X    � 	Resources 5	       �� 
TargetType   	textBlock �� Property �� Value  textBox��%�  &	        &	 �     �� 5
   
   " ��6   .�5      ��  � ��$ 0 10 0 0q�6'   �� 5       � ��$ 20��6'   �� 5       � ��$ 14(�6)   �� 5       �@��TextAlignment$ Right=�6.   5      �� 5   
   " ��6   .�5      ��  � ��$ 5 10 5 0q�6'   �� 5       � ��$ 20��6'   �� 5       � ��$ 14(�6)   �� 5       � ��$ 1q�60   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� $��0��6   $��0��6%   .+�5!      �� $��Марка стали:��6   #��[  6,   �� 5"      $/��)Предел текучести (МПа):��6   #��[  67   �� 5#      $/��)Предел прочности (МПа):��6   #��[  67   �� 5$      $8��2Относительное удлинение (%):��6   #��[  6<   �� 5%      $4��.Относительное сужение (%):��6   #��[  6:   �� 5&      $��Твердость(HB):��6   #��[  6.   5'      �� 5(   
   $��1��6   $��0��6%   .+�5)      �� -   5         ��Name$ tbSteelGrade��5)      #��[ 6,   �� 5*      -   5        $ tbYieldStress��5*      #��[ 6-   ��6N   �� 	 �� Path$	 YieldStress�
 �� ValidatesOnExceptions$

 true�� �� NotifyOnValidationError$
 true�� �� UpdateSourceTrigger$ PropertyChanged=��� 5+      -   5        $ tbTensileStrength��5+      #��[ 61   ��6R   �� $	 TensileStrength�$

 true��$
 true��$ PropertyChanged=��� 5,      -   5        $ tbElongation��5,      #��[ 6,   ��6M   �� $	 
Elongation�$

 true��$
 true��$ PropertyChanged=��� 5-      -   5        $ tbContraction��5-      #��[ 6-   ��6N   �� $	 Contraction�$

 true��$
 true��$ PropertyChanged=��� 5.      -   5        $
 tbHB��5.      #��[ 6$   ��6E   �� $	 HB�$

 true��$
 true��$ PropertyChanged=�5/      �� 50   
   -   5         ��Name$ btnAdd��50      $��Добавить��6!   $��2��64   $��1��6H     ButtonStyle#��[ 6U   $	��Top=�6z   51      52      