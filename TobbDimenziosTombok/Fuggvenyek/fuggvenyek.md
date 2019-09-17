# Függvények(metódusok)
Ismétlődő tevékenységek végrehajtatására, illetve értékek meghatározására és az eredmény visszaadására szolgáló programelemek. Szokás alprogramnak is hívni. Egyszer kell létrehozni, utána a program egy adott pontján meg lehet hívni.

A függvény végrehajthat valamilyen tevékenységeket (void) , vagy adhat valamilyen visszatérési értéket. Ebben az esetben meg kell adni a visszetérési érték típusát.
Egy függvénynévvel több függvényt is létre lehet hozni (**túlterhelés vagy overloading**), de a paraméterlistáinak különbözniük kell.

**Visszatérési érték nélküli függvények**

```C#
 private static void Kiir()
        {
            Console.WriteLine("_default");
        }

private static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

private static void Kiir(string s1,string s2)
        {
            Console.WriteLine(s1+" "+s2);
        }
```
**Visszatérési értékkel rendelkező függvények**

```C#
   private static int Osszead(int a,int b)
        {
            return a + b;
        }

   private static double Osszead(double a,double b)
        {
            return a + b;
        }
```

**Matematikai műveleteknél a Math osztály jó szolgálatot tehet**

Hatványozó függvény
```C#
public static double Hatvany(double szam,double kitevo)
        {
            return Math.Pow(szam, kitevo);
        }
```
A paraméterként kapott **szam**, ill. **kitevo** értékével meghívjuk a **Math.Pow()** függvényt.

Érték szerinti paraméter átadásnál  az átadott értékek lemásolódnak, az eredeti változók értéke nem fog megváltozni.
Van lehetőség cím (referencia) szerinti átadásra, ebben az esetben a változó memóriacímét adjuk át, és a változó értékét a függvényből meg tudjuk változtatni.



