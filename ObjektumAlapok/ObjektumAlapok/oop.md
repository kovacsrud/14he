# Objektum-Orientált Programozás

Szoftver krízis: Az egyre bonyolultabb problémákat egyre nehezebb volt megoldani a hagyományos struktúrált programozással. Egy bonyolultsági fok felett más megközelítés szükséges, ez az OOP szemlélet.

Objektum: tartalmazhat adatokat, és tartalmazhat metódusokat(függvények).
Az objektum az adatokat és a metódusokat magába zárja(bezártság elve). Kívülről csak a programozó által láthatóvá tett dolgok (adatok ill. metódusok) lesznek láthatóak.

Pl. egy Ember osztály(class)
 Ember
+---------------------------------+
|Név                              |
|Születési év                     |
|Súly                             |
|Magasság                         |
|                                 |
|                                 |
+---------------------------------+
|                                 |
| Mozog()                         |
| Eszik()                         |
| Iszik()                         |
| Tanul()                         |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
|                                 |
+---------------------------------+

Az osztály az objektum "terve", a programban az osztály alapján példányokat lehet létrehozni.

A bezártság azt is jelenti, hogy a legtöbb esetben az osztály adatai csak metódusokon keresztül érhetőek el.

**Osztály definíció**
```C#
 class Ember
    {
        public string nev;
        public int szuletesiEv;
        public int suly;
        public int magassag;

    }
```
**Példányosítás**
```C#
 Ember ubul = new Ember();
```

**Az osztály bővítése metódusokkal**
```C#
 class Ember
    {
        private string nev;
        private int szuletesiEv;
        private int suly;
        private int magassag;

        public void setNev(string n)
        {
            nev = n;
        }
        public string getNev()
        {
            return nev;
        }

    }
```
**Konstruktor**
Az osztály konstruktora egy olyan speciális metódus, amellyel az objektum adatainak kezdeti értékeit lehet beállítani.
```C#
 //konstruktor ->inicializálás, kezdeti értékek megadása
        public Ember()
        {
            nev = "_default";
            szuletesiEv = 1999;
            suly = 10;
            magassag = 150;
        }
```

**Paraméteres konstruktor**
Paraméteres konstruktorral átadhatunk adatokat példányosításkor is, amelyekkel az objektum kezdeti értékei beállíthatóak.

```C#
 public Ember(string n,int szev,int s,int m)
        {
            nev = n;
            szuletesiEv = szev;
            suly = s;
            magassag = m;
        }
```
**Több konstruktora is lehet egy osztálynak, de a paramétereik listájának eltérőnek kell lennie**

**A property** 
A propery a C# nyelv egyik sajátossága, amely pl. Java-ban nem található meg.
A property egy adatmezőt és annak beállító valamint lekérdező metódusát egyesíti.
```C#

 public string Nev { get; set; }
        public int SzuletesiEv { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

```

**Öröklődés**

Az öröklődés során egy új osztályt leszármaztatunk egy meglévőből. Az utód osztály örökli az ős összes tulajdonságát(adatmezőit) és metódusát.
Az új osztályban azokat az új adatokat és metódusokat kell megadni, amelyekkel az adott osztályt kiegészítjük.
Egy leszármazott osztálynak csak egy őse lehet.

