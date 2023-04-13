using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal abstract class Animale
    {
        public  void dormi()
        {
            Console.WriteLine("ZZZZZZZZ");
        }

        public abstract void faiVerso();

        public abstract void mangia();
    }
}
