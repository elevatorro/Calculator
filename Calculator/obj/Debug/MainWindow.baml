   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Calculator     5   	     � Title$  
MainWindow��5   	   $��361.731��6   $	��800��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��31* �6   �� 5      $	��57* �6   .+�5   
   �� -   5         ��Name$	 one��5      $��1��6   $��44(�6*   $
��Left=�68   $��56��6S   $��
10,104,0,0q�6_   $	��Top=�6s   $	��107��6�   6�   �� 5   
   -   5         ��Name$ result��5       �� 	MaxLength$ 12��6"    �� MaxLines$ 1��61    �� 
IsReadOnly . $��44(�6P   $
��Left=�6^   $��66��6y   $��	10,38,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��428��6�   $��2��6�   �� 5   
   -   5        $
 four��5      $��4��6   $��44(�6+   $
��Left=�69   $��56��6T   $��
10,160,0,0q�6`   $	��Top=�6t   $	��107��6�   6�   �� 5   
   -   5        $ seven��5      $��7��6    $��44(�6,   $
��Left=�6:   $��56��6U   $��
10,216,0,0q�6a   $	��Top=�6u   $	��107��6�   6�   �� 5   
   -   5        $	 two��5      $��2��6   $��44(�6*   $
��Left=�68   $��56��6S   $��117,104,0,0q�6_   $	��Top=�6t   $	��107��6�   6�   �� 5   
   -   5        $
 five��5      $��5��6   $��44(�6+   $
��Left=�69   $��56��6T   $��117,160,0,0q�6`   $	��Top=�6u   $	��107��6�   6�   �� 5   
   -   5        $ eight��5      $��8��6   $��44(�6,   $
��Left=�6:   $��56��6U   $��117,216,0,0q�6a   $	��Top=�6v   $	��107��6�   6�   �� 5   
   -   5        $ three��5      $��3��6   $��44(�6,   $
��Left=�6:   $��56��6U   $��224,104,0,0q�6a   $	��Top=�6v   $	��107��6�   $��2��6�   �� 5   
   -	   5        $	 six��5      $��6��6   $��44(�6*   $
��Left=�68   $��56��6S   $��224,160,0,0q�6_   $	��Top=�6t   $	��107��6�   $��2��6�   �� 5   
   -
   5        $
 nine��5      $��9��6   $��44(�6+   $
��Left=�69   $��56��6T   $��224,216,0,0q�6`   $	��Top=�6u   $	��107��6�   $��2��6�   �� 5   
   -   5        $
 zero��5      $��0��6   $��44(�6+   $
��Left=�69   $��56��6T   $��117,272,0,0q�6`   $	��Top=�6u   $	��107��6�   6�   �� 5   
   -   5        $ ravno��5      $��=��6   $��44(�6,   $
��Left=�6:   $��56��6U   $��52.442,104,0,0q�6a   $	��Top=�6y   $	��107��6�   $��1��6�   6�   �� 5   
   -   5        $
 plus��5      $��+��6   $��44(�6+   $
��Left=�69   $��56��6T   $��52.442,160,0,0q�6`   $	��Top=�6x   $	��107��6�   $��1��6�   6�   �� 5   
   -   5        $ minus��5      $��-��6   $��44(�6,   $
��Left=�6:   $��56��6U   $��52.442,216,0,0q�6a   $	��Top=�6y   $	��107��6�   $��1��6�   6�   �� 5   
   -   5        $ proizvedenie��5      $��*��6   $��44(�63   $
��Left=�6A   $��56��6\   $��52.442,272,0,0q�6h   $	��Top=�6�   $	��107��6�   $��1��6�   6�   �� 5   
   -   5        $ division��5      $��/��6   $��44(�6/   $
��Left=�6=   $��56��6X   $��224,272,0,0q�6d   $	��Top=�6y   $	��107��6�   $��2��6�   6�   �� 5   
   -   5        $ clear��5      $��C��6   $��44(�6,   $
��Left=�6:   $��56��6U   $��
10,272,0,0q�6a   $	��Top=�6u   $	��107��6�   6�   5       5!      