# Aknakereső játék

2

​

3

A kialakult helyzet miatt jobb ha elölről kezdjük az aknakereső kivitelezését. Igyekszem lépésről-lépésre követhetően leírni a programot, magyarázatokkal. Érdemes lesz egy teljesen új projektet készíteni, mondjuk **Aknakereso** néven. A program FontAwesome elemeket fog használni ezért a megfelelő Nuget-et fel kell telepíteni.

4

​

5

Számos osztályból fog a program összeállni.

6

​

7

Először is készítsünk egy osztályt amiben a grafikus elemeket, és az azokkal kapcsolatos műveleteket kezeljük. Az osztály neve legyen **GameItem**. Ezekből a GameItem-ekből áll majd össze a játéktér. Minden GameItem-ben lesz két "réteg", ami **Label**-ekkel lesz megvalósítva. Induláskor a felső réteg látszódik majd a játéktérben. Ha bal gombbal kattintanak, akkor a felső réteg helyére az alsó kerül. Jobb gombbal való kattintáskor a felső réteg elemét zászlóra módosítjuk, ismételt kattintás esetén a zászlót eltüntetjük. A GameItem-ek egy 2 dimenziós tömböt alkotnak. Ezeknek a megfelelő rétegét egy **Grid**-be tesszük, amelynek dimenziója megegyezik a tömbével.

8

​

9

​

10

Hozzuk létre a **GameItem** osztályt:

11

```C#

12

public class GameItem

13

{

14

    

15

}

16

```

17

Az osztály mezői:

18

Az osztály mezőinek hozzáadása következik, amelyek a következők:

19

 - elemek tömb, ebben tároljuk a grafikus elemeket

20

 ```C#

21

 public FontAwesome.WPF.FontAwesome[] elemek;

22

 

23

 ```

24

 - A két réteg

25

 

26

 ```C#

27

 public Label UpLayer;

28

 public Label DownLayer;

29

 ```

30

 

31

 Egy logikai változó annak jelzésére, hogy az elem "fedett-e" azaz a felső rétege van-e megjelenítve, vagy már az alsó

32

 ```C#

33

 public bool Covered;

34

 ```

35

 Egy másik logikai változó, amely jelzi, ha zászlóval van megjelölve az elem.

36

 ```C#

37

 public bool Flagged;

38

 ```

39

Az osztály metódusai:

40

​

41

 - SetUpLayer a felső réteg beállítása. Jelen esetben nem a réteg **Text** tulajdonságába írunk, ugyanis a FontAwesome elemek ott nem használhatóak, hanem egy StackPanelt csinálunk, abba írunk, és ezt a StackPanelt adjuk hozzá a Label-hez. A szín megadás bedrótozása nem szép megoldás, később majd refaktorálni kell, de első verziónak elmegy. A bemenő paraméterben az elemek tömb elemének sorszámát adjuk meg, azaz hogy melyik elemet akarjuk használni.

42

 

43

 ```C#

44

  public void SetUpLayer(int elem)

45

  {

46

    StackPanel pn = new StackPanel();

47

            

48

    pn.Children.Add(elemek[elem]);

49

    UpLayer.MinHeight = 40;

50

    UpLayer.Margin = new Thickness(1);

