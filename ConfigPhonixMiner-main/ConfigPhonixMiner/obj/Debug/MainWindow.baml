   M S B A M L   `   `   `  ����L  HConfigPhonixMiner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ConfigPhonixMinerConfigPhonixMiner  5   	   "    ConfigPhonixMiner.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ConfigPhonixMiner     5   	     � Title$  ConfigPhonixMiner��5   	   $	��300��6#   $	��370��60    � WindowStartupLocation$ CenterScreen=�6<    � 
ResizeMode$ NoResize=�6a   .��5	      � $	��Top=�6   $
��Left=�6#   .+�5
   
   �� .+�5      � $��15��6   �� 5      $
��Left=�6    �� Orientation$ 
Horizontal=�64   .+�5      �� $��Select App: ��6   �� 5      -   5        $��cmbo_App��5      $	��125��6+   5      � 5      $��15��6   �� 5      $
��Left=�6   $ 
Horizontal=�64   .+�5      �� $��Select Coin: ��6   �� 5      -   5        $��	cmbo_coin��5      $	��125��6,   68   5      � 5      $��15��6   �� 5      $ 
Horizontal=�6   .+�5      �� $��Wallet: ��6   �� 5      -   5        $��
txt_wallet��5      $	��300��6,   5      � 5      $��15��6   �� 5      $ 
Horizontal=�6   .+�5      �� $��Worker��6   �� 5      -   5        $��
txt_Worker��5      $	��300��6-   5      � 5      $��15��6   �� 5       $ 
Horizontal=�6   .+�5!      �� $��	Pool:    ��6   �� 5"      -   5        $��txt_Pool��5"      $	��300��6+   5#      � 5$      $��15��6   �� 5%      $��Center=�6   $ 
Horizontal=�66   .+�5&      �� -   5        $��btn_load��5&   5   $
��Load��6   $	��100��6(   6F   � 5'      $��10��6   �� 5(      -   5        $��	btn_Apply��5(   5   $��Apply��6   $	��100��6)   6F   � 5)      $��10��6   �� 5*      -   5        $	��Run��5*      $��50��6=   5+      5-      5.      5/      