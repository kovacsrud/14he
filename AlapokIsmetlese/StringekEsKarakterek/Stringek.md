# Stringek
```C#
String szoveg = "Szöveges adat";
```

   

 ## stringekkel végzett műveletek

- hossz kiíratása
```C#    
Console.WriteLine(szoveg.Length);
```

 - kisbetűsre alakítás
```C#
   Console.WriteLine(szoveg.ToLower());
```
 - nagybetűsre alakítás
```C#
Console.WriteLine(szoveg.ToUpper());
```
 - kezdődik valami szöveggel?
```C#
Console.WriteLine(szoveg.StartsWith("Szö"));
```
 -betűk, szöveg felülírása
```C#
Console.WriteLine(szoveg.Replace('e','ö'));
Console.WriteLine(szoveg.Replace("adat", "érték"));
```


- Szövegrész kiemelése
```c#
Console.WriteLine(szoveg.Substring(2,3));
```
**A String típus értéke nem változtatható.**

**Karakter típus**

Egyetlen karaktert (betű,szám,írásjel,vezérlő karakter) tárol.
A karakter tömbök adott számú karaktert tudnak tárolni.

Karakterekkel a **Char** osztály használatával lehet műveleteket végezni.
pl. az adott karakter betű-e?
```C#
Char karakter = 'q';

if (Char.IsLetter(karakter))
   {
      Console.WriteLine("Ez betű");
   }
```
Karakter átalakítása nagybetűsre, ha kisbetűs
```c#
Char karakter='q';

if (Char.IsLower(karakter))
   {
        karakter = Char.ToUpper(karakter);
   }
