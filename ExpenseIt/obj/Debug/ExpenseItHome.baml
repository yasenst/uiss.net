   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      D @ExpenseIt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ExpenseIt	ExpenseIt 5         ExpenseIt.ExpenseItHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      )localclr-namespace:ExpenseIt     5        N� Title$  ExpenseIt - Home��5
      .��5      � $��
10,0,10,10q�6    � 	Resources 5   
      ExpenseDataSource � XPath��%@  &	        � 5      $ Expenses��68   .��5      ��<Expenses xmlns="">
                        <Person Name="Mike" Department="Legal">
                            <Expense ExpenseType="Lunch" ExpenseAmount="50" />
                            <Expense ExpenseType="Transportation" ExpenseAmount="50" />

                        </Person>
                        <Person Name="Lisa" Department="Marketing">
                            <Expense ExpenseType="Document printing" ExpenseAmount="50" />
                            <Expense ExpenseType="Gift" ExpenseAmount="125" />
                        </Person>
                        <Person Name="John" Department="Engineering">
                            <Expense ExpenseType="Magazine subscription" ExpenseAmount="50" />
                            <Expense ExpenseType="New machine" ExpenseAmount="600" />
                            <Expense ExpenseType="Software" ExpenseAmount="500" />
                        </Person>
                        <Person Name="Mary" Department="Finance">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="Theo" Department="Marketing">
                            <Expense ExpenseType="Dinner" ExpenseAmount="100" />
                        </Person>
                        <Person Name="James" Department="Finance">
                            <Expense ExpenseType="Dinner" ExpenseAmount="400" />
                        </Person>
                        <Person Name="David" Department="Engineering">
                            <Expense ExpenseType="New hardware" ExpenseAmount="450" />
                            <Expense ExpenseType="Software" ExpenseAmount="250" />
                        </Person>
                    </Expenses>        50      51      ��52   
   �� 53       �� ImageSource$ watermark.png��6    � ColumnDefinitions 55   
   �� 56      �� 57      $	��230 �6    � RowDefinitions 59   
   �� 5:      $
��Auto �6   �� 5;      �� 5<      $
��Auto �6   �� 5=      .+�5?   
   �� $��0��6   $��3��6    ��6-   ��  �� Path$ LastChecked��� 5@   
   $��1��6   $��Center=�5A      $��Trebuchet MS)�5B      $
��Bold"�5C      $��22(�5D      ���#0066cc.��5E   &   View Expense Report5G      �� 5H   
   $��1��6   $��1��6!   $��35��6.    �� Padding$ 5q�6:   ���#4E87D4._�5I      �� $��Center=�6   
�������.��6B   Names6I   5J      �� 5K   
   -   5        $��peopleListBox��5K      $��1��6'   $��2��67   ��6D   ��  �� Source# [  	 �� XPath$	 Person����5M      �� 5N      .R�5O      �� ��6   �� $	 @Name��5P      5R      �� 5S   
   $��0��6   $��2��6"   ��6/   �� $ PersonsChecked�6]   �� 5T   
   -   5        $��0,10,0,0q�5T      $��1��6#   $��3��63   $	��125��6@   $��25��6L   $��Right=�6X   ��6�   �� 
 �� ElementName$
 peopleListBox��$# SelectedItem.Attributes[Name]�6�   �� 5U   
   -   5        $��0,10,0,0q�5U      $��1��6#   $��3��63   $	��125��6@   $��25��6L   $
��Left=�6X   .��6�   
Greeting6�   5V      5Y      