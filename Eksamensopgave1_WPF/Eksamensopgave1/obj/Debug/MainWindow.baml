   M S B A M L   `   `   `  ����J  FEksamensopgave1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Eksamensopgave1Eksamensopgave1  5   	        Eksamensopgave1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Eksamensopgave1     5   	     � Title$  Bistade Editor��5   	   $	��450��6    $	��800��60   $	��450��6?   $	��800��6L    � Icon$ images/favicon.ico��6Y    � 	Resources 5
         BtnStyle �� Property �� Value  	MainStyle��%�  &	        &	 .    �� 5   
   .�5      ��  � ��$
 12pt(�61   �� 5       � ��$ Calibri Light)�63   �� 5       � �� �#4d4d4d63   �� 5       � �� �#bfbfbf64   �� 5       � ��$ 1q�68   �� 5       � ��
 �����63   �� 5       � |� .  62   5      �� 5   
   .�5      ��  � �� �#33333363   �� 5       � ��
 �����63   5      5      .��5      � ���#333333 � ColumnDefinitions 5   
   �� 5      $��6* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5       $��22 �6   �� 5!      $��8* �6   �� 5"      $��1* �6   .+�5%   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridRecords��5%   3   
�������$��1��6&      AutoGenerateColumns .     CanUserAddRows .  ��6f   �� 	 �� Mode$	 OneWay=�
 �� NotifyOnTargetUpdated
 .    Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Bistade��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.5* 66   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *	Bistade+  5(      $
 Date��6%   $
 2.3* 63    6@   �� *Date+  5)      $ Count��6%   $ 1* 64    6?   �� *
Varrocount+  5*      $
 Note��6%   $ 6* 63    6>   �� *Note+5,      �� 5.   
   $��1��6   $��1��6%   .+�5/      �� -   5        $��BtnEnterRcd��5/   P   #��[  6   $��10,30,10,10q�6c   $��25��6x   .��6�   Enter Record6�   �� 50      -   5        $��BtnGetRecords��50   R   #��[  6   $��
10,0,10,10q�6g   $��25��6{   .��6�   Get All Records6�   �� 51      -   5        $��BtnGetRecordsByHive��51   Y   #��[  6   $��10,180,10,10q�6t   $��25��6�   .��6�   Get Records by hive6�   �� 52      -   5        $��
TxtBoxHive��52      $��25��6(   $��
10,0,10,10q�64   53      o� 54   
   $��0��6   $��2��6   #��[ 60   .@�55      m� $��_File��6   .@�56      m� -   5        $��_Save Records��56   .   
���   �6E   m� 57      -   5        $��_Clear Records��57   /   
���   �6G   �� 58      m� 59      -   5        $��
_Add seeds��59   /   
���   �6C   �� 5:      m� 5;      -	   5        $��_Exit��5;   +   
���   �6:   5<      5=      5>      5A      