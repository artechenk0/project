   M S B A M L   `   `   `  ????D  @Project02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Project02	Project02  5   	   "    Project02.Windows.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Project02     5   	     ? Title$.  (Личные дела студентов??5   	   $	??450??6'   $
??1100??64   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??0.5* ?6   ?? 5       ? RowDefinitions 5   
   ?? 5      $??2* ?6   ?? 5      ?? 5      ?? 5      .+?5   
   ?? -   5         ??Name$ ButtonAddStudent??5      $??1??6+   $'??!Добавить студента??68   $??30,15q?6T   6c   ?? 5   
   -   5        $ ButtonChangeStudent??5      $??2??6.   $*??$Сведения о студенте??6;   $??30,15q?6Y   6h   ?? 5   
   -   5        $ ButtonRemoveStudent??5      $??3??6.   $%??Удалить студента??6;   $??30,15q?6V   6e   ?? 5   
   $Y??SПрограмма для получения сведений о студентах??6   $
??Wrap=?6H   $??Center=?6\   $??Center=?6y   ?? 5   
   -   5         ??Name$ ListStudent??5      $??1??6(   $??4??68   $??20,80,20,20q?6I    ?? View 5      ?? 5      .P?5      ?? $??ФИО??6%    ?? DisplayMemberBinding 62   ?? *
FullName+?? 5       $??Курс??6%    63   ?? *Course+?? 5!      $ ??Специальность??6%    6<   ?? *
Speciality+?? 5"      $#??Начало обучения??6%    6>   ?? *	StartDate+?? 5#      $!??Конец обучения??6%    6=   ?? *	EndDate+?? 5$      $??Тип??6%    62   ?? *Type+?? 5%      $??Вид??6%    62   ?? *View+5&      5(      5)      5*      