   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.pMain   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      $��RightToLeft=�5         MaterialDesignBody#���   5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignFont N� 
FontFamily# �  5       N� Title$ بتروتريد��5   	   .��5      � .+�5   
   � $	��Top=�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    .+�5      �� $��Center=�6   $	��100��61   $��Center=�6>   $	��100��6Y   $)��#pack://application:,,,/logo (1).png��5      $��Uniform=�6=   $��20,20,20,20q�6O   $��0��6e   $��0��6r   $��3��6�   �� 5!      -   5        $	��150��5!   +   $��60��6:   $��خروج >>��6J   $��Right=�6\   $��Center=�6x   $��20(�5"      ���	#FF0F0E0E$
��Bold"�6<   $��0��6e   $��3��6r   $��0,0,50,0q�6�   ��6   Z� ��6N   Z� 6�   #  MaterialDesignThemes.Wpf.Card  5$      $��16q�6"   $��100,50,100,16q�6/   $��1��6G   $��3��6T   .��5%      �  5&      �� 5'      $��* �6+   �� 5(      $��* �6+   �� 5)      $��* �6+   �� 5*      $��* �6+    5,      �� 5-      $��* �6(   �� 5.      $��* �6(   .+�50      �� $��اسم المشترك :��6    $��16(�66   $
��Bold"�6D   $��0��6V   $��0��6c   $��10q�6s   $
��Left=�6   $��Center=�6�   �� 51      -   5        $
��name��51       $"��مي مسعد إبراهيم��6,   $��16(�6C   $
��Bold"�6Q   $��0��6c   $��1��6p   $��10q�6�   $
��Left=�6�   $��Center=�6�   �� 53      $��المحافظه : ��6    $��16(�64   $
��Bold"�6B   $��1��6T   $��0��6a   $��10q�6q   $
��Left=�6}   $��Center=�6�   �� 54      -   5        $
��city��54       $��القاهره��6,   $��16(�6;   $
��Bold"�6I   $��1��6[   $��1��6h   $��10q�6x   $
��Left=�6�   $��Center=�6�   �� 56      $��المنطقه :��6    $��16(�62   $
��Bold"�6@   $��1��6R   $��2��6_   $��10q�6o   $
��Left=�6{   $��Center=�6�   �� 57      -   5        $
��area��57       $��المعادي��6,   $��16(�6;   $
��Bold"�6I   $��1��6[   $��4��6h   $��10q�6x   $
��Left=�6�   $��Center=�6�   �� 59      $��رقم المشترك :��6    $��16(�66   $
��Bold"�6D   $��0��6V   $��2��6c   $��10q�6s   $
��Left=�6   $��Center=�6�   �� 5:      -   5        $��	subNumber��5:       $��0123560145963258��61   $��16(�6I   $
��Bold"�6W   $��0��6i   $��4��6v   $��10q�6�   $
��Left=�6�   $��Center=�6�   5;      5<      5=      ]� 5>   
   .+�5?       � -   5        $��ParentFrame��5?        � NavigationUIVisibility$ Hidden=�6'    K� ZIndex$ 1��6G   $��	0,120,0,0q�6X   5@      5A      5B      