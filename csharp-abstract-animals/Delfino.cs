using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Delfino : Animale
    {
        public override void faiVerso()
        {
            Console.WriteLine("IIIIIIIIH");
        }

        public override void mangia()
        {
           Console.WriteLine("Pesce");
        }
    }
}
