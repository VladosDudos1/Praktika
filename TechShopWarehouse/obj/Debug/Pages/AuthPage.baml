   M S B A M L   `   `   `  ????L  HTechShopWarehouse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TechShopWarehouseTechShopWarehouse  5           TechShopWarehouse.AuthPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:TechShopWarehouse     5      .??5
      ?   ? RowDefinitions  5   
   ?? 5      ?? 5      ?? 5      ?? 5      ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      $
??1.2* ?6   ?? 5      $
??1.2* ?6   ?? 5      .+?5   
   ?? -   5         ??Name$ authText??5      $??Авторизация??6&   $??32(?69   $??Center=?6G   $??1??6b   $??0??6r   $??Center=?6   $??2??6?   ?? 5   
   -   5         ??Name$ LoginTB??5      $??1??6#   $??2??63   $??16q?6@   $??24(?6L   $??Center=?6Z   $??2??6}   .??6?    ? ToolTip 5      _? 5      .??6   
Логин5      .??5       5!      G? 5"   
   -   5         G?Name$ 
PasswordTB??5"      $??1??6*   $??3??6:   $??16, 0, 16, 32q?6G   $??24(?6^   $??Center=?6l   $??2??6?    5#      _? 5$      .??6   Пароль5&      5(      ?? 5*   
   -   5         ??Name$ enterBtn??5*      $??Вход??6#   $??24(?62   $??1??6@   $??4??6P   $??Center=?6]   $??Center=?6z   $??12q?6?   6?   ?? 5,   
   -   5        $ regBtn??5,      $??Регистрация??6!   $??24(?67   $??2??6E   $??4??6U   $??Center=?6b   $??Center=?6   $??12q?6?   6?   5-      5.      