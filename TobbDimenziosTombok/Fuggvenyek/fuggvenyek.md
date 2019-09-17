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




