   M S B A M L   `   `   `  ????C  ?Students, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StudentsStudents  5   	       Students.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Students     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      ?? 5      ?? 5      ?? 5       ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridStudents??5         AutoGenerateColumns . $??4??6D   $??2??6U   
?????????6?   ?? *
students+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя??6%      FontSize$ 12Q?6K      
Foreground
 ?   ?1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   ?? *Name+6Y     5      $ Фамилия??6%   $ 12Q?6R   
 ?   ?	 66   ?? *	Surname+6`     5      $ Отчество??6%   $ 12Q?6R   
 ?   ?	 67   ?? *Patron+6`     5       $ Возраст??6%   $ 12Q?6N   
 ?   ?	 66   ?? *Age+6\     5!      $ Рост??6%   $ 12Q?6N   
 ?   ?	 63   ?? *Height+6\     5"      $ Вес??6%   $ 12Q?6M   
 ?   ?	 62   ?? *Weight+6[   5$      ?? 5&   
   -   5        
 ??Name$
 lvStud??5&      $??4??6#   $??2??64   $??4??6H   
?????????5'      ?? 5(      .R?5)      A?  A? Columns$ 3??6"   60   5*      ??5-      ?? 5.      .R?5/      ?? $??8q?6!   .+?50      ?? $??50??6    $??Center=?6,   $??18(?6I   $	??Top=?6p   $??Center=?6?   $	??Top=?6?   ??6W   ?? *Name+6?   ?? 51      $??50??6    $??Center=?6,   $??18(?6I   $	??Top=?6s   $??Center=?6?   $	??Top=?6?   ??6W   ?? *	Surname+6?   ?? 52      $??50??6    $??Center=?6,   $??18(?6I   $	??Top=?6r   $??Center=?6?   $	??Top=?6?   ??6W   ?? *Patron+6?   ?? 53      $??50??6    $??Center=?6,   $??18(?6I   $	??Top=?6o   $??Center=?6?   $	??Top=?6?   ??6W   ?? *Age+6?   ?? 54      $??50??6    $??Center=?6,   $??18(?6I   $	??Top=?6r   $??Center=?6?   $	??Top=?6?   ??6W   ?? *Height+6?   ?? 55      $??50??6    $??Center=?6,   $??18(?6I   $	??Top=?6r   $??Center=?6?   $	??Top=?6?   ??6W   ?? *Weight+6?   56      57      5:      5<      5=      