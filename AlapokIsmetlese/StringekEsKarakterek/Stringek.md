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