   M S B A M L   `   `   `  ����L  HBinanceOptionsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:BinanceOptionsAppBinanceOptionsApp  5   	   "    BinanceOptionsApp.Socket_Wnd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:BinanceOptionsApp     5   	     � Title$  Connect Via WebSocket��5   	   $��287.69��6'   $��450.178��67    � WindowStartupLocation$ CenterScreen=�6G   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��90* �6   �� 5      $
��125* �6   �� 5      $	��24* �6   �� 5      $
��125* �6   �� 5      $	��90* �6    � RowDefinitions 5   
   �� 5      $	��30* �6   �� 5      $	��25* �6   �� 5      $	��25* �6   �� 5      $��5* �6   �� 5      $	��25* �6   �� 5      $��5* �6   �� 5      $	��25* �6   �� 5      $��5* �6   �� 5      $	��32* �6   �� 5      $	��30* �6   .+�5   
   �� -   5         ��Name$ 
Submit_Btn��5   (   $��Send Connect��6   $��Palatino Linotype)�6<   $��14(�6[   $��8��6i   $��1��6v   $��3��6�   6�   �� 5   
   -   5         ��Name$ Ip1_Tb��5      $��67.217.228.39��6"    �� TextWrapping$
 Wrap=�67   $��Palatino Linotype)�6K   $��18(�6j   $��2��6x   $��1��6�   �� 5   
   -   5        $ Ip2_Tb��5      $
 Wrap=�6"   $��Palatino Linotype)�66   $��16(�6U   $��4��6c   $��1��6p   �� 5    
   -   5        $ Ip3_Tb��5       $
 Wrap=�6"   $��Palatino Linotype)�66   $��16(�6U   $��6��6c   $��1��6p   �� 5!   
   -   5        $ Port1_Tb��5!      $
��8080��6$   $
 Wrap=�60   $��Palatino Linotype)�6D   $��18(�6c   $��2��6q   $��3��6~   �� 5"   
   -   5        $ Port2_Tb��5"      $
 Wrap=�6$   $��Palatino Linotype)�68   $��16(�6W   $��4��6e   $��3��6r   �� 5#   
   -   5        $ Port3_Tb��5#      $
 Wrap=�6$   $��Palatino Linotype)�68   $��16(�6W   $��6��6e   $��3��6r   �� 5$   
   $
��PORT��6   $��Center=�6   $��0,1,0,0q�6C   $��Palatino Linotype)�6T   $
��Bold"�6s   $��3��6�   $��1��6�   �� 5%   
   $��IP��6   $��Center=�6   $��0,1,0,2q�6A   $��Palatino Linotype)�6R   $
��Bold"�6q   $��1��6�   $��1��6�   �� 5&   
   -   5         ��Name$ Info_Lbl��5&      $�� ��6   $��Center=�6-   $��0,6,0,4q�6Q   $��Palatino Linotype)�6b   $
��Bold"�6�   $��1��6�   $��3��6�   ���	#FF0F9B086�   �� 5'   
   -	   5        $ 
Status_Lbl��5'      $�� ��6   $��Center=�6/   $��0,5,0,4q�6S   $��Palatino Linotype)�6d   $
��Bold"�6�   $��1��6�   $��3��6�   ���	#FF0F9B08$��9��6�   �� 5(   
   -
   5         ��Name$ IsClient_Chb��5(      $��IsClient��6)   $��0,10,0,0q�6<   6N   5*      5+      