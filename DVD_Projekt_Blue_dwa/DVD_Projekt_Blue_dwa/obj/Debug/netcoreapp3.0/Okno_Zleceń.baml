   M S B A M L   `   `   `  ����O  KDVD_Projekt_Blue_dwa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:DVD_Projekt_Blue_dwaDVD_Projekt_Blue_dwa  5   	   '    !DVD_Projekt_Blue_dwa.Okno_Zleceń   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:DVD_Projekt_Blue_dwa     5   	     � Title$  Zlecenia��5   	   $	��445��6   $	��984��6'   .��5	      � $	��514��6   $
��Left=�6   $
��1074��63   .+�5
   
   �� $��Szczegóły��6   $��585,22,108,155q�6&   $��18(�6>   $
��Bold"�6L   �� 5   
   $��Zleceniodawca��6   $
��Left=�6(   $��	33,38,0,0q�6C   $	��Top=�6V   $��26��6n   $��96��6z   �� 5   
   -   5         ��Name$ nick_zleceniodawcy��5      $
��Left=�6.   $��
159,42,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��152��6�   $��21��6�   �� 5   
   $��Usługa��6   $
��Left=�6!   $��	33,84,0,0q�6<   $	��Top=�6O   $	��107��6g   �� 5   
   -   5         ��Name$ typ_usługi��5      $
��Left=�6'   $��
159,88,0,0q�6B   $	��Top=�6V   $	��152��6n   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6z   $��1,1,1,1q�6�   $��21��6�   .@�5      �� $��soloq��6   �� 5      $
��duoq��6   �� 5      $��coaching��6   5      �� 5   
   -   5         ��Name$ aktualna_dywizja��5      $��aktualna dywizja��6*   $
��Left=�6E   $��
611,55,0,0q�6`   $	��Top=�6t   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ godzinki��5      $��godziny��6%   $��810,67,177,342q�66   $y�Hidden=�6N   �� 5   
   -   5         ��Name$ I��5      $
��8-16��6   $
��Left=�6-   $��
819,91,0,0q�6H   $	��Top=�6\    J� RenderTransformOrigin$ 0.475,0.731&�6t   $y�Hidden=�6�   �� 5   
   -   5        $ II��5      $��16-24��6   $
��Left=�6/   $��819,108,0,0q�6J   $	��Top=�6_   $y�Hidden=�6�   �� 5   
   -   5        $	 III��5      $
��24-8��6    $
��Left=�6/   $��819,126,0,0q�6J   $	��Top=�6_   $y�Hidden=�6�   �� 5   
   -   5        $ dowolny_checkbox��5      $��dowolnie��6-   $
��Left=�6@   $��819,143,0,0q�6[   $	��Top=�6p   $ 3.021,0.698&�6�   $y�Hidden=�6�   �� 5   
   -	   5        $ dywizja_aktualna��5      $
��Left=�6-   $��
611,78,0,0q�6H   $	��Top=�6\   $	��120��6t   $y�Hidden=�6�   .@�5      �� $��Żelazo��6   $
��Bold"�6,   �� 5      $��Brąz��6   $
��Bold"�6*   �� 5      $��Srebro��6   $
��Bold"�6,   �� 5      $��Złoto��6   $
��Bold"�6+   �� 5      $��Platyna��6   $
��Bold"�6-   �� 5      $��Diament��6   $
��Bold"�6-   �� 5       $��Mistrz��6   $
��Bold"�6,   �� 5!      $��
Arcymistrz��6   $
��Bold"�60   �� 5"      $��
Pretendent��6   ${�False��60   $��Medium&�6B   5#      �� 5$   
   -
   5        $ dywizja_oczekiwana��5$      $
��Left=�6/   $��611,144,0,0q�6J   $	��Top=�6_   $	��120��6w   $y�Hidden=�6�   .@�5%      �� $��Żelazo��6   ${�False��6,   $��Medium&�6>   �� 5&      $��Brąz��6   $
��Bold"�6*   �� 5'      $��Srebro��6   $
��Bold"�6,   �� 5(      $��Złoto��6   $
��Bold"�6+   �� 5)      $��Platyna��6   $
��Bold"�6-   �� 5*      $��Diament��6   $
��Bold"�6-   �� 5+      $��Mistrz��6   $
��Bold"�6,   �� 5,      $��
Arcymistrz��6   $
��Bold"�60   �� 5-      $��
Pretendent��6   $
��Bold"�60   5.      �� 5/   
   -   5        $ oczekiwana_dywizja��5/      $��oczekiwana dywizja��6,   $
��Left=�6I   $��611,121,0,0q�6d   $	��Top=�6y   $y�Hidden=�6�   �� 50   
   -   5        $ mail_zleceniodawcy��50      $
��Left=�6.   $��159,133,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��152��6�   $��21��6�   �� 51   
   $��E-mail kontaktowy��6   $
��Left=�6,   $��
33,131,0,0q�6G   $	��Top=�6[   �� 52   
   -   5        $ przewidywana_cena��52      $
��Left=�6-   $��780,247,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��116��6�   $��32��6�   ${�False��6�   $y�Hidden=�6�   �� 53   
   -   5        $ przewidz_to_ha_ha_ha��53      $��Przewidywana cena��6.   $
��Left=�6J   $��759,211,0,0q�6e   $	��Top=�6z   $
��Bold"�6�   $��16(�6�   $y�Hidden=�6�   �� 54   
   -   5        	 ��Name$	 zamawiam��54      $��Zamawiam i płacę��6#   $
��Left=�6>   $��680,302,0,0q�6Y   $	��Top=�6n   $��42��6�   $	��183��6�   $��16(�6�   $y�Hidden=�6�   6�   �� 55   
   -   5        $	 wybierz_pracownika��55      $��Wybierz pracownika��6-   $
��Left=�6J   $��159,181,0,0q�6e   $	��Top=�6z   6�   �� 56   
   -   5        $	 data_zlecenia��56      $��Wybierz datę��6(   $
��Left=�6?   $��159,221,0,0q�6Z   $	��Top=�6o   6�   (  "System.Windows.Controls.DatePicker  57   
   -   5        
  Name$
 wybierz_date_zlecenia��57      $
��Left=�64   $��260,219,0,0q�6O   $	��Top=�6d   �� 58   
   -   5        $	 oblicz��58      $��Oblicz��6!   $
��Left=�62   $��691,250,0,0q�6M   $	��Top=�6b   $��26��6z   $��60��6�   $y�Hidden=�6�   �� 59   
   -   5        $	 potwierdzam_wybór��59      $��Potwierdzam wybór��6,   $
��Left=�6H   $��156,343,0,0q�6c   $	��Top=�6x   $��22��6�   $	��123��6�   6�   �� 5:   
   -   5        $ twoja_dywizja��5:      $��Twoja dywizja?��6'   $
��Left=�6@   $��
611,55,0,0q�6[   $	��Top=�6o   $y�Hidden=�6�   �� 5;   
   -   5        $	 wracaj_do_pokeballa_2��5;      $��Powrót��60   $
��Left=�6A   $��	23,13,0,0q�6\   $	��Top=�6o   6�   5=      5>      