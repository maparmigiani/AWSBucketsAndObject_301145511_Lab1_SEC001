   M S B A M L   `   `   `  ????_  [301145511(ParmigianiDeAlmeida)_Lab01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]3clr-namespace:_301145511_ParmigianiDeAlmeida__Lab01%_301145511_ParmigianiDeAlmeida__Lab01  5   	   8    2_301145511_ParmigianiDeAlmeida__Lab01.UploadObject   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Elocal3clr-namespace:_301145511_ParmigianiDeAlmeida__Lab01     5   	     ? Title$'  !Upload Object to S3 Bucket Window??5   	   $	??450??63   $	??700??6@   .??5	      ? .+?5
   
   ?? $??Bucket??6   $
??Left=?6!   $??	21,29,0,0q?6<   $	??Top=?6O   ?? 5   
   -   5         ??Name$ 
CbxBuckets??5      $
??Left=?6'   $??	84,31,0,0q?6B   $	??Top=?6U   $	??378??6m   $??30??6y   6?   ?? 5   
   -   5         ??Name$ TxtBoxObject??5      $
??Left=?6(   $??	84,78,0,0q?6C    ?? TextWrapping$
 Wrap=?6V   $?? ??6j   $	??Top=?6r   $	??378??6?   $??34??6?   ?? 5   
   -   5         ??Name$ 	BtnBrowse??5      
????  ?
??? ???$
??Bold"?6J   $??Browse??6\   $
??Left=?6m   $??
524,36,0,0q?6?   $	??Top=?6?   $	??157??6?   6?   ?? 5   
   -   5        $ 	BtnUpload??5      
????  ?
??? ???$
??Bold"?6J   $??Upload??6\   $
??Left=?6m   $??
524,76,0,0q?6?   $	??Top=?6?   $	??157??6?   6?   ?? 5   
   -   5        $ BtnBackToMain??5      
????  ?
??? ???$
??Bold"?6N   $??Back to Main Window??6`   $
??Left=?6~   $??533,354,0,0q?6?   $	??Top=?6?   $	??148??6?   $??38??6?   6?   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DtGridObjects??5         AutoGenerateColumns$ False??6B   $??0,116,181,0q?6^   ??6*   ??    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Object Name??6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   ?? *Key+  5      $
 Size??6%   	 63   ?? *Size+5      ?? 5   
   $??Object??6   $
??Left=?6!   $??	21,78,0,0q?6<   $	??Top=?6O   5      5      