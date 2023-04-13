using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Aquila : Animale , IVolante
    {
        public override void faiVerso()
        {
            Console.WriteLine("Raaaaa");
        }

        public override void mangia()
        {
            Console.WriteLine("Mammiferi");
        }

       
    }
}
