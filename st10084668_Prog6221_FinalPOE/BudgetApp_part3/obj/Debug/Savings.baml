   M S B A M L   `   `   `  ����J  FBudgetApp_part3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BudgetApp_part3BudgetApp_part3  5   	       BudgetApp_part3.Savings   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BudgetApp_part3     5   	     � Title$  Savings��5   	   $	��600��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   
    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 10��6   ��5   
   �� 5       �� ImageSource$ /Images/peakpx.jpg��6   ._�5   
   � .+�5      �� ��. $��Visible=�63    �� Left$ 6��6Y   
 �� Top$ 55��6i   ���	#FFFFFDFD$��373,100,32,116q�6�   .��5      �� -   5        	 ��Name$	 
txtSavings��5      $
��Wrap=�61   
�������
���   �$	��392��6l   $	��866��6x   $ 96��6�   $ 68��6�   $��Baskerville Old Face)�6�   $��18(�6�   5      �� 5      $��Savings��6   $
��Left=�6&   $��
113,35,0,0q�6A   $	��Top=�6U   $��Baskerville Old Face)�6m   $��30(�6�   ���	#FFFEFEFE6�   �� 5      $��Budget Plan��6   $
��Left=�6*   $��
495,35,0,0q�6E   $	��Top=�6Y   ���	#FFFBF9F9$��Baskerville Old Face)�6�   $��30(�6�   �� 5      $��Savings Reason :��6   $
��Left=�6/   $��
31,123,0,0q�6J   $	��Top=�6^   ���	#FFFCFAFA$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 5      $��Amount to save :��6   $
��Left=�6/   $��
31,203,0,0q�6J   $	��Top=�6^   $��Baskerville Old Face)�6v   $��18(�6�   $
��Bold"�6�   
�������6�   �� 5      $��Interest Rate (%) :��6   $
��Left=�62   $��31,0,0,0q�6M   $��Center=�6_   
�������$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 5      $��Time Period (months) :��6   $
��Left=�65   $��
31,386,0,0q�6P   $	��Top=�6d   
�������$��Baskerville Old Face)�6�   $��18(�6�   $
��Bold"�6�   �� 5      -   5        
 ��Name$
 tbReason��5       �� TextAlignment$ Right=�6(   $
��Left=�6>   $��186,123,0,0q�6Y    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��150��6�   $��Baskerville Old Face)�6�   $��18(�6�   $��26��6�   �� 5       -   5        $
 tbAmt��5       $ Right=�6%   $
��Left=�6;   $��186,205,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 5!      -   5        $
 	tbIntRate��5!      $ Right=�6)   $
��Left=�6?   $��	186,0,0,0q�6Z   $
 Wrap=�6m   $��Center=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 5"      -   5        $
 tbMonths��5"      $ Right=�6(   $
��Left=�6>   $��218,391,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��150��6�   $��26��6�   $��Baskerville Old Face)�6�   $��18(�6�   �� 5#      -   5         ��Name$ btnExit��5#      $
��Exit��6&   $
��Left=�65   $��
746,10,0,0q�6P   $	��Top=�6d   $��Baskerville Old Face)�6|   $��44��6�   $��23��6�   
���   �
������� � 	Resources 5$       �� 
TargetType �� Property �� Value��%_   '��       �� 5%      " ��6   .�5&      ��  �@��CornerRadius$ 10��69   5'      5(      5)      �� 5*      -   5        $ btnGenerate��5*      $��Generate Budget Plan��6*   $
��Left=�6I   $��400,520,0,0q�6d   $	��Top=�6y   $��33��6�   $	��176��6�   
���   �
�������$��Baskerville Old Face)�6�   $��18(�6�    5+      ��%_   '��       �� 5,      " ��6   .�5-      ��  �@��CornerRadius$ 10��69   5.      5/      50      �� 51      -   5        $ 	btnSubmit��51      $��Submit��6(   $
��Left=�69   $��221,453,0,0q�6T   $	��Top=�6i   $��31��6�   $��72��6�   
���   �
�������$��Baskerville Old Face)�6�   $��18(�6�    52      ��%_   '��       �� 53      " ��6   .�54      ��  �@��CornerRadius$ 10��69   55      56      57      �� 58      -	   5        $ btnClear��58      $��Clear��6'   $
��Left=�67   $��
79,453,0,0q�6R   $	��Top=�6f   $��31��6~   $��72��6�   
���   �
�������$��Baskerville Old Face)�6�   $��18(�6�    59      ��%_   '��       �� 5:      " ��6   .�5;      ��  �@��CornerRadius$ 10��69   5<      5=      5>      �� 5?      -
   5        $ btnSave��5?      $��Save Budget Plan��6&   $
��Left=�6A   $��592,524,0,0q�6\   $	��Top=�6q   
���   �$��33��6�   $	��176��6�   $��Baskerville Old Face)�6�   $��18(�6�   
�������$��Normal"�6�    5@      ��%_   '��       �� 5A      " ��6   .�5B      ��  �@��CornerRadius$ 10��69   5C      5D      5E      5G      5H      5I      