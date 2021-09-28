using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_intro
{
    class Ember
    {
        /*
        // Attribútumok

        private string _nev;
        private int kor;
        private int magassag;

        // Propertyk
        public string Nev { get => _nev; set => _nev = value; }
        public int Kor { get => kor; set => kor = value; }
        public int Magassag { get => magassag; set => magassag = value; }
        */

        // Property + Attribútum
        public string Nev { get; set; }
        public int Kor { get; set; }
        public int Magassag { get; set; }

        // Konstruktor: Osztály -> Objektum (Az objektum az adott osztály példánya)
        public Ember(string nev, int kor, int magassag)
        {
            Nev = nev;
            Kor = kor;
            Magassag = magassag;
        }

        // Metódusok
        public void Koszones()
        {
            Console.WriteLine($"Szia {Nev}!");
        }

        // Nevezetes, fontos metódusok
        public override string ToString()
        {
            return $"Név: {Nev}, kor: {Kor}, magasság: {Magassag}cm";
        }

        

    }
}
