   M S B A M L   `   `   `  ����J  FBudgetApp_part3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BudgetApp_part3BudgetApp_part3  5   	       BudgetApp_part3.Vehicle   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BudgetApp_part3     5   	   $	��500��5   
   $	��500��6     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   ��5   
   �� 5       �� ImageSource$ /Images/peakpx.jpg��6   ._�5   
   � .+�5      �� $��Vehicle��6   $��Center=�6&   $��0,10,0,0q�6C   $	��Top=�6U   $��Baskerville Old Face)�6m   $��30(�6�   ���	#FFF9F8F86�   	� 5      -   5         	�Name$ rbNotBuying��5      $��
Not Buying��6/   $
��Left=�6D   $��	29,70,0,0q�6_   $	��Top=�6r   $��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   ���	#FFFCFCFC 	� 	GroupName$ 2��6�   6�   �� 5      $��1q�6   
�������$��5��6=   $	��465��6H    �� Left$ 39��6T   
	 �� Top$		 102��6e   
 J� RenderTransformOrigin$
 0.5,0.5&�6v   
�������$��25,108,10,387q�6�   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6)   �� 5      �� 5      T� 5      5      5       	� 5!      -   5        $ rbBuying��5!      $��Buying��6,   $
��Left=�6=   $��
29,134,0,0q�6X   $	��Top=�6l   ���	#FFFEFDFD$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   $ 2��6�   6�   �� 5"      -   5         ��Name$ btnExit��5"      $
��Exit��6&   $
��Left=�65   $��
447,10,0,0q�6P   $	��Top=�6d   $��43��6|   ���	#FFFEFEFE$��22��6�   ���	#FF050505 � 	Resources 5#       �� 
TargetType �� Property �� Value��%_   '��       �� 5$      " ��6   .�5%      ��  �@��CornerRadius$ 10��69   5&      5'      5(      �� 5)      -   5         ��Name$ lblMake��5)      $��Vehicle Make and Model :��6%   $y�Hidden=�6H   $
��Left=�6\   $��
29,172,0,0q�6w   $	��Top=�6�   ���	#FFFCFCFC$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 5*      -   5        $��Submit��5*      $
��Left=�6&   $��218,446,0,0q�6A   $	��Top=�6V   ���	#FF0B0A0A���	#FFFBFBFB$��Baskerville Old Face)�6�   $��18(�6�   $��31��6�   $��69��6�    5+      ��%_   '��       �� 5,      " ��6   .�5-      ��  �@��CornerRadius$ 10��69   5.      5/      50      �� 51      -   5        $ 	lblpPrice��51      $��Purchase Price :��6'   $y�Hidden=�6B   $
��Left=�6V   $��
29,219,0,0q�6q   $	��Top=�6�   ���	#FFFEFEFE$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 52      -   5        $ 
lblDeposit��52      $��	Deposit :��6(   $y�Hidden=�6<   $
��Left=�6P   $��
29,275,0,0q�6k   $	��Top=�6   ���	#FFFCFCFC$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 53      -   5        $ lblInterest��53      $��Interest Rate :��6)   $y�Hidden=�6C   $
��Left=�6W   $��
29,326,0,0q�6r   $	��Top=�6�   ���	#FFFBFBFB$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 54      -	   5        $ lblInsurance��54      $��Insurance Premium :��6*   $y�Hidden=�6H   $
��Left=�6\   $��
29,379,0,0q�6w   $	��Top=�6�   ���	#FFFEFEFE$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 55      -
   5         ��Name$ tbMakeModel��55      $y�Hidden=�6+    �� TextAlignment$ Right=�6?   $
��Left=�6U   $��258,172,0,0q�6p    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   
���   �$��Baskerville Old Face)�6�   $��18(�6�   �� 56      -   5        $ 
tbPurPrice��56      $y�Hidden=�6*   $ Right=�6>   $
��Left=�6T   $��258,224,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 57      -   5        $ 	tbDeposit��57      $y�Hidden=�6)   $ Right=�6=   $
��Left=�6S   $��258,275,0,0q�6n   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 58      -   5        $ 
tbInterest��58      $y�Hidden=�6*   $ Right=�6>   $
��Left=�6T   $��258,326,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 59      -   5        $ tbInsurance��59      $y�Hidden=�6+   $ Right=�6?   $
��Left=�6U   $��258,379,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   5;      5<      5=      