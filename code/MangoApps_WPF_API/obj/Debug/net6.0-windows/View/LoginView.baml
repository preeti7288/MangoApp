   M S B A M L   `   `   `  ????L  HMangoApps_WPF_API, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MangoApps_WPF_API.ViewMangoApps_WPF_API.View  5      C&clr-namespace:MangoApps_WPF_API.HelperMangoApps_WPF_API.Helper  5	      &     MangoApps_WPF_API.View.LoginView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:MangoApps_WPF_API.View     5      LmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     5      7ctrl&clr-namespace:MangoApps_WPF_API.Helper     5	      $??10q?5        ? 	Resources  5         TextWithLabel ?? 
TargetType ?? Property ?? Value  HyperlinkButton ?? 
TargetType  MahApps.Brushes.Accent ? Cursor??%   &	        '?? ?     'G? ?     &	     7  ?? 5   
   " ??6&   .?5      ??  ?@??Orientation$ Vertical=?6,   ?? 5       ? ??$
 10,5q?6'   5      ?? 5   
   " ??6   .?5      ??  ? ??$ 30??6'   5      ?? 5   
   " G?6   .?5      ??  ? ??$ 30??6'   5      ?? 5   
   " ??6   .?5      ??  ? ?? 5      ?? 5      " ??6&   .R?5      ?? 8??  #??z??5      $??	Underline{?5      $
 Hand??5      5      5       5!      5#      .??5$      ?  ? RowDefinitions 5%   
   ?? 5&      $??80 ?6   ?? 5'      $??* ?6   ?? 5(      $
??auto ?6   .+?5+   
   ??  ?? Orientation$ Vertical=?6   $??0??6,   .+?5-      ?? $	??200??6   $??80??6    $M??Gpack://application:,,,/MangoApps_WPF_API;component/Images/ms_header.png??6,   5/      ?? 51   
   $ Vertical=?6   $??1??6,   .+?52      ?? #??[  6   .+?53      ?? #??[ 6   .??6O   
Login ID6Y   ?? 54      ??6   ?? *	LoginId+ ?? Mode$ TwoWay=?	 ?? UpdateSourceTrigger$	 PropertyChanged=?
 ?? ValidatesOnDataErrors$

 True??55   W   56      ?? 57      #??[  6   .+?58      ?? #??[ 6   .??6O   
Password6Y   G? 59      -   'MangoApps_WPF_API.Helper.PasswordHelper   Attach$
 True??6      Password 5:      ?? *
Password+$ TwoWay=?$	 PropertyChanged=?$

 True??5<      ? 5=       ? ColumnDefinitions 5>      ?? 5?      $	??55* ?6'   ?? 5@      $	??10* ?6'   .+?5B      ?? $??Forgot???6   $??1??6,   #??[ 5C      5D      ?? 5F      #??[  6   .+?5G      ?? $ 
Horizontal=?6   .+?5H      ?? #??[ 6   .??6S   
Domain URL6_   ?? 5I      $??15??6   $??20??6'   $
??-3,0q?63   $H??Bpack://application:,,,/MangoApps_WPF_API;component/Images/info.png??5J      5K      ?? 5M      ??6   ?? *	DomainURL+$ TwoWay=?$	 PropertyChanged=?$

 True??5N   W   5O      ?? 5P      $ 
Horizontal=?6   $??10q?62   .+?5Q      ?? -   5         ??Name$ chkRememberMe??5Q      67   ?? 5R      #??[ 6   .??6O   Remember me6\   ?? 5S      $??15??6   $??20??6#   $
??-3,0q?6/   $H??Bpack://application:,,,/MangoApps_WPF_API;component/Images/info.png??5T      5U      ?? 5V      #??[  6   $??10,20q?6@   .+?5Y      ??  ( $MahApps.Styles.Button.Dialogs.Accent#??[ 6   #??[ 5Z      ??5[      ?? *RaiseSignINCommand+{?6<   ?? *
CanExecute+.??6^   	SIGN IN6g   5\      5^      ?? 5_   
   $??2??6   .+?5`      ?? #??[  6   $??10,20q?6@   .+?5a      ?? 
?????????5b      ?? 5c      $ 
Horizontal=?6%   .+?5d      ?? $??25??6$   $??25??6/   $S??Mpack://application:,,,/MangoApps_WPF_API;component/Images/loginButtonLock.png??5e   $   ?? 5f      .??6$   Sign in using other methods6A   5g      5i      5j      ? 5k       5l      ?? 5m      $	??20* ?6'   ?? 5n      $	??50* ?6'   .+?5p      ?? $??Sign Up for MangoApps??6   $??1??6:   #??[ 5q      5r      5s      5t      5u      