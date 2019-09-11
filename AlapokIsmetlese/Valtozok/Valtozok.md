# C# nyelvi elemek ismétlése

## Változók, változó típusok
A változó a memória egy része, amihez egy nevet rendelünk, és ezen a néven tudunk hivatkozni a változóra.

## Érték típusok

### Egész számok

**egész számok 16,32,64 bitesek**
 -előjeles
```c#
   int a = 1;
```

 - előjel nélküli
```C#
uint b = 126;
```
```C#
 Int16 c = 445;
 short d = 442;
 long e = 224354656;
```

 - előjel nélküli, 64 bites
 ```c#
 UInt64 f = 55355666;
 ```
 **Minta az adott típus lehetséges értékeinek kiíratására**
 ```c#
 Console.WriteLine($"Min:{Int16.MinValue},Max:{Int16.MaxValue}");
 Console.WriteLine($"Min:{UInt16.MinValue},Max:{UInt16.MaxValue}");
 ```

 **deklarálás másképp**
```C#      
var szam = 516;
var szoveg = "Szöveges adat";
```
```c#
//lebegőpontos (nem egész) számok
//egyszeres pontosságú 32 bites
float l1 = 16.196366366632663344926492f;
//kétszeres pontosságú 64 bites
double l2 = 16.196366366632663344926492;
//decimális, 128 bites
decimal l3 = 16.196366366632663344926492m;
```
**Referencia típus**
- minden, ami nem érték típus (tömb,objektumok, listák stb)

