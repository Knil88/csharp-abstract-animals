﻿using csharp_abstract_animals;
using System.Security.Cryptography;

Animale a1, a2; // lately binding

a1 = new Cane();

a2 = new Passerotto();

Aquila a3; // early binding

a3 = new Aquila();


Delfino a4 ;

a4 = new Delfino();

List<Animale> elencoAnimali = new List<Animale>();
elencoAnimali.Add(a1);
elencoAnimali.Add(a2);
elencoAnimali.Add(a3);
elencoAnimali.Add(a4);

foreach(Animale a in elencoAnimali)
{
    a.dormi();
    a.faiVerso();
    a.mangia();

   
    


}
INuotante b;
b = new Delfino();

Console.Write($"Sono un delfino e ");

b.Nuota();

IVolante c = new Aquila();

Console.Write($"Sono un Aquila e ");

c.Vola();

IVolante p = new Passerotto();

Console.Write($"Sono un passerotto e ");

p.Vola();
