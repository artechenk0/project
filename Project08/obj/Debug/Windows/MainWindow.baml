   M S B A M L   `   `   `  ????D  @Project08, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project08	Project08  5   	   "    Project08.Windows.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.58.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project08     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??450??6)   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      ?? 5      $
??0.5* ?6   ?? 5      $
??0.2* ?6   ?? 5      $
??0.5* ?6    ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      ?? 5      .+?5   
   ?? $A??;Введите пределы интегрирования:??6   $??16(?6;   $
??Wrap=?6I   $??Center=?6]   $??Right=?6x    ?? TextAlignment$ Right=?6?   $??0,0,15,0q?6?   ?? 5   
   $
??до??6   $??16(?6   $
??Wrap=?6,   $??Center=?6@   $??Center=?6[   $ Right=?6x   $??2??6?   ?? 5   
   $C??=Количество интервалов разбиения:??6   $??16(?6<   $
??Wrap=?6J   $??Center=?6^   $??Right=?6y   $ Right=?6?   $??1??6?   $??0,0,15,0q?6?   ?? 5   
   -   5         ??Name$ TextBoxLimitsMin??5      $??1??6,   $??15,42q?6<   ?? 5   
   -   5        $ TextBoxLimitsMax??5      $??3??6,   $??15,42q?6<   ?? 5   
   -   5        $ TextBoxCount??5      $??1??6(   $??1??68   $??15,42q?6E   $??3??6T   ?? 5   
   -   5         ??Name$ 
ButtonCalc??5      $??Рассчитать ??6%   $??3??6;   $??4??6H   6\   5       5!      