   M S B A M L   `   `   `  ����J  FBudgetApp_part3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BudgetApp_part3BudgetApp_part3  5   	   #    BudgetApp_part3.Accommodation   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BudgetApp_part3     5   	   $	��450��5   
   $	��700��6     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   ��5   
   �� 5       �� ImageSource$ /Images/peakpx.jpg��6   ._�5   
   � .+�5      �� $��Accommodation��6   $��Center=�6,   $��0,10,0,0q�6I   $	��Top=�6[   $��Baskerville Old Face)�6s   $��30(�6�   ���	#FFF8F7F76�   �� 5      $��1q�6   
�������$��5��6=    �� Left$ 39��6H   
 �� Top$	 102��6Y    J� RenderTransformOrigin$ 0.5,0.5&�6j   
�������$��157,189,267,256q�6�   z�5      V� 5      .~�5      �� 	 �� ScaleY$	 -1Q�6)   �� 5      �� 5      
 �� Angle$
 89.666Q�6*   T� 5      5      5       	� 5!      -   5         	�Name$ rbBuying��5!      $��Buying A Property��6,   $
��Left=�6H   $��
349,59,0,0q�6c   $	��Top=�6w   ���	#FFFAFAFA$��Baskerville Old Face)�6�   $��18(�6�   ���	#FFFAF9F9 	� 	GroupName$ 1��6�   $
��Bold"�6�   6  	� 5"      -   5        $ 	rbRenting��5"      $��Renting��6-    d� 	IsChecked$ FalseY�6?   $
��Left=�6Q   $��	37,69,0,0q�6l   $	��Top=�6   ���	#FFFAFAFA$ 1��6�   $��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   6�   �� 5#      -   5         ��Name$ lblRent��5#      $��Monthly Rent :��6%   $y�Hidden=�6>   $
��Left=�6R   $��
10,116,0,0q�6m   $	��Top=�6�   ���	#FFFAFAFA$��18(�6�   $��Baskerville Old Face)�6�   $
��Bold"�6�   �� 5$      -   5         ��Name$ 	tbRentAmt��5$      $
��Left=�6)   $y�Hidden=�6D    �� TextAlignment$ Right=�6X   $��128,116,0,0q�6n    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 5%      -   5        $ lblPropPrice��5%      $��Property Price :��6*   $y�Hidden=�6F   $
��Left=�6Z   $��316,111,0,0q�6u   $	��Top=�6�   ���	#FFFAFAFA$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 5&      -   5        $ tbPPrice��5&      $y�Hidden=�6(   $ Right=�6<   $
��Left=�6R   $��518,111,0,0q�6m   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 5'      -   5        $ 
lblDeposit��5'      $y�Hidden=�6(   $��	Deposit :��6<   $
��Left=�6P   $��316,162,0,0q�6k   $	��Top=�6�   ���	#FFFAFAFA$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 5(      -   5        $ lblInterest��5(      $y�Hidden=�6)   $��Interest Rate :��6=   $
��Left=�6W   $��	322,0,0,0q�6r   $��Center=�6�   ���	#FFFAFAFA$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   $ 0.308,0.622&�6�   �� 5)      -	   5        $ lblTime��5)      $y�Hidden=�6%   $��Time period(months) :��69   $
��Left=�6Y   $��322,265,0,0q�6t   $	��Top=�6�   ���	#FFFAFAFA$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 5*      -
   5        $ 	tbDeposit��5*      $y�Hidden=�6)   $ Right=�6=   $
��Left=�6S   $��518,162,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 5+      -   5        $ 
tbInterest��5+      $y�Hidden=�6*   $ Right=�6>   $
��Left=�6T   $��518,210,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 5-      -   5        $��Submit��5-      $
��Left=�6&   $��273,373,0,0q�6A   $	��Top=�6V   $��41��6n   $��82��6z   ���	#FF040404���	#FFFEFEFE$��Baskerville Old Face)�6�   $��18(�6�   $��Normal"�6�    � 	Resources 5.       �� 
TargetType �� Property �� Value��%_   '��       �� 5/      " ��6   .�50      ��  �@��CornerRadius$ 10��69   51      52      54      �� 55      -   5         ��Name$ btnExit��55      $
��Exit��6&   $
��Left=�65   $��
647,10,0,0q�6P   $	��Top=�6d   $��43��6|   $��22��6�   $��Baskerville Old Face)�6�   ���	#FF0C0C0C���	#FFFEFDFD 56      ��%_   '��       �� 57      " ��6   .�58      ��  �@��CornerRadius$ 10��69   59      5:      5;      	� 5<      -   5        $ rbtime1��5<      $	��240��6+   $y�Hidden=�69   $
��Left=�6M   $��518,273,0,0q�6h   $	��Top=�6}   $��24��6�   $	��150��6�   ���	#FFFEFEFE$ 3��6�   $��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6  	� 5=      -   5        $ rbtime2��5=      $	��360��6+   $y�Hidden=�69   $
��Left=�6M   $��518,302,0,0q�6h   $	��Top=�6}   ���	#FFFEFEFE$	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   $ 3��6  5?      5@      5A      