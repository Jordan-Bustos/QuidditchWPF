   M S B A M L   `   `   `  ����  QuidditchWPF'    !QuidditchWPF.View.CtrlReservation   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � $
��Auto=�6   $
��Auto=�6=     � RowDefinitions  5	   
   �� 5
      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   6.   �� 5      $
��auto �6   6.   .+�5   
   �� $��0��6   $��0��6   $��Center=�6-   $��Center=�6J   $��Coupe��5      �� 5   
   $��1��6   $��0��6   $��Center=�6-   $��Center=�6J   $��Match��5      �� 5   
   $��2��6   $��0��6   $��Center=�6-   $��Center=�6J   $	��Nom��5      �� 5   
   $��3��6   $��0��6   $��Center=�6-   $��Center=�6J   $��Prénom��5      �� 5   
   $��4��6   $��0��6   $��Center=�6-   $��Center=�6J   $��Adresse��5      �� 5    
   $��5��6   $��0��6   $��Center=�6-   $��Center=�6J   $��Place��5!      �� 5"   
   $��6��6   $��0��6   $��Center=�6-   $��Center=�6J   $
��Prix��5#      �� 5%   
   -   5        $��cbCoupes��5%   0   $��0��6   $��1��6    $��Center=�6@   $	��150��5&      $
��Left=�5(   \    �� SelectedItem 5'      ��  �� Path$ Coupe� �� UpdateSourceTrigger$ PropertyChanged=���5(      �� $ Coupes�$ PropertyChanged=�6\   �� 5)   
   -   5        $��cbMatchs��5)   0   $��1��6   $��1��6    $
��Left=�6@   $��Center=�6[   $	��150��5*       5+      �� $ Match�$ PropertyChanged=���5,      �� $ Matchs�$ PropertyChanged=��� 5-   
   -   5        $��txbNom��5-   0   $��2��6   $��1��6    $
��Left=�6>   $��Center=�6Y   $	��150��5.      ��5/      �� $	 Nom�$ PropertyChanged=��� 50   
   -   5        $��	txbPrenom��50   0   $��3��6   $��1��6    $
��Left=�6A   $��Center=�6\   $	��150��51      ��52      �� $ Prenom�$ PropertyChanged=��� 53   
   -   5        $��
txbAdresse��53   0   $��4��6   $��1��6    $
��Left=�6B   $��Center=�6]   $	��150��54      ��55      �� $ Adresse�$ PropertyChanged=��� 56   
   -   5        $��	txbPlaces��56   0   $��5��6   $��1��6    $
��Left=�6A   $��Center=�6\   $��50��57      ��58      �� $ Place�$ PropertyChanged=��� 59   
   -   5        $��lbPrixCalcule��59   -   $��6��6   $��1��6   $��Center=�6B   $��Center=�6_   
���  �� �� Target 5:      ��  �� ElementName$
 Prix��5;      5<      