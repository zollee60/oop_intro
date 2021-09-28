using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Ember jani = new Ember("Jani", 20, 187);
            jani.Koszones();

            Console.WriteLine(jani);

            Ember peti = new Ember("Peti", 20, 187);
            peti.Koszones();
        }
    }
}
