   M S B A M L   `   `   `  ����D  @PESEL_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PESEL_App	PESEL_App  5   	       PESEL_App.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PESEL_App     5   	     � Title$  Generator numeru PESEL��5   	   $	��400��6(   $��466.8��64    � 
ResizeMode$ CanMinimize=�6C    � Icon$ person_white.png��6\   .��5
      � ���	#FF313131.+�5   
   �� -   5         ��Name$ txtPesel��5      $
��Left=�6$   $��37��6?   $��116,285,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��155��6�   $��24(�6�    �� 	MaxLength$ 11��6�   ��6�   Z� �� 5   
   $
��Left=�6   $��	87,29,0,0q�6/   $
��Wrap=�6B   $��Podaj datę urodzenia��6V   $	��Top=�6r   
�������$��24(�6�   �� 5   
   $
��Left=�6   $��127,128,0,0q�6/   $
��Wrap=�6D   $��Wybierz płeć��6X   $	��Top=�6l   
�������$��24(�6�   	� 5   
   -   5         	�Name$	 rbK��5      $��
67,175,0,0q�6#    � Cursor$
 Hand��67   
�������$��19��6X   $	��105��6d   $��16(�6p   $
��Left=�6~   $	��Top=�6�   $��Kobieta��6�   	� 5   
   -   5        $	 rbM��5      $��222,175,0,0q�6#   $
 Hand��68   
�������$��19��6Y   $	��102��6e   $��16(�6q   $
��Left=�6   $	��Top=�6�   $��Mężczyzna��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDateBirth��5      $
��Left=�6*   $��
144,76,0,0q�6E   $	��Top=�6Y   $��14(�6�   $
 Hand��6�   ��6q   Z� 6�   �� 5   
   -   5        	 ��Name$	 btnGenerate��5      $��Wygeneruj numer PESEL��6&   $
��Left=�6F   $��
65,217,0,0q�6a   $	��Top=�6u   $	��257��6�   $��22(�6�   
�������$��2q�5      
����������	#FF1D1D1D$
 Hand��6f   �� 5   
   -   5        $	 btnClear��5      $��	Wyczyść��6#   $
��Left=�65   $��
65,363,0,0q�6P   $	��Top=�6d   $	��257��6|   $��22(�6�   
�������$��2q�5      
����������	#FF1D1D1D$
 Hand��6c   5      5      