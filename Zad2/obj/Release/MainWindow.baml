   M S B A M L   `   `   `  ���� ?  ;Zad2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Zad2Zad2      Zad2.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:Zad2       � Title$  PizzeriaMammaMia��$	��450��$	��580��$	��450��$	��580��.��� $��0,0,2,0q�.+�� $��70��$��
10,10,10,0q�$	��Top=� � ShowGridLines . $��Disabled=�.+��� -    ��Name$ daneZam��$��23��$��145,10,80,0q� �� TextWrapping$
 Wrap=�$	��Top=��� -    ��Name$ 	czyscDane��$��	Wyczyść��$��Right=�$��0,10,0,0q�$	��Top=�$��75��$��23���� -   $ 
nazwaPizzy��$��23��$��145,39,80,0q�$
 Wrap=�$	��Top=��� -   $ 
czyscPizza��$��	Wyczyść��$��Right=�$��0,39,0,0q�$	��Top=�$��75��$��23���� $��Dane zamawiającego:��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��130��$��23��
���   �$��2q�$��0q��� $��Pizza:��$
��Left=�$��	10,39,0,0q�$	��Top=�$	��130��$��23��$��2q�
���   �� $	��142��$��0,67,0,-139q�$	��Top=�$��Center=�.+��� $��Wybierz spód��$	��114��$	��Top=�$��Stretch=�$��Stretch=�$��	0,0,330,0q�.��� $	��104��$	��Top=�$	��218��$��
0,0,-2,-12q� � ColumnDefinitions �� .+�	� -    	�Name$ rButton1��$��zwykły spód��$
��Left=�$��0,10,0,0q�$	��Top=� 	� 	GroupName$ 
wyborSpodu��	� -   $ rButton2��$��ultracienki spód��$
��Left=�$��0,30,0,0q�$	��Top=�$ 
wyborSpodu��	� -   $ rButton3��$��gruby spód��$
��Left=�$��0,50,0,0q�$	��Top=�$ 
wyborSpodu��	� -   $ rButton4��$&�� specjalny podwójnie gruby spód��$
��Left=�$��0,70,0,0q�$	��Top=�$ 
wyborSpodu���� $��Wybierz dodatki��$	��114��$	��Top=�$��Stretch=�$��Stretch=�$��	225,0,0,0q�.��� $��90��$��0,0,-2,0q�$	��Top=�.+��� -	    ��Name$ dodSer��$��Dodatkowy ser��$
��Left=�$��	10,10,0,0q�$	��Top=��� -
   $ dodSos��$	��Sos��$
��Left=�$��	10,38,0,0q�$	��Top=��� -   $ dodNap��$��Napoje chłodzące��$
��Left=�$��	10,66,0,0q�$	��Top=��� -   $ dodSer2��$��23��$��
132,8,10,0q�$
 Wrap=�$�� ��$	��Top=��� -   $ dodSos2��$��23��$��132,36,10,0q�$
 Wrap=�$�� ��$	��Top=��� -   $ dodNap2��$��23��$��132,64,10,0q�$
 Wrap=�$�� ��$	��Top=��� -   $ dodZam��$��Dodaj do zamówienia��$��Right=�$��	0,119,0,0q�$	��Top=�$	��135��$��23��� $��10,225,0,10q�.+��� -   $ poleZam��$��	0,0,10,38q�$
 Wrap=�$�� ��"	 �� VerticalScrollBarVisibility$
	 Auto=�$��Stretch=�$��Bottom=�
 �� AcceptsReturn
 .  �� 
IsReadOnly . �� -   $ usunZam��$��Anuluj��$��Right=�$��	0,0,10,10q�$��Bottom=�$��75��$��23���� -   $ wysZam��$��OK��$��Right=�$��	0,0,90,10q�$��Bottom=�$��60��$��23��