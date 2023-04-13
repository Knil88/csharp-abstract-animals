using csharp_abstract_animals;
using System.Security.Cryptography;

Animale a1, a2,a3,a4;

a1 = new Cane();

a2 = new Passerotto();

a3 = new Aquila();

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