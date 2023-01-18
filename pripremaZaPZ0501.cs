using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaProvjeruZnanjaOO5._1
{
        /*
        Definirajte klasu Fruit sa sljedećim članicama:
        • privatne varijable:
            Vrsta, Boja, JeLiSlatko
        • konstruktori:
            Fruit(string)
            Fruit(string, string, bool)
        Konstruktori trebaju definirati pripadajuće varijable članice 
        s vrijednostima proslijeđenih argumenata.
        Definirajte sljedeća tri objekta tipa Fruit: x, y i z koji će predstavljati sljedeće voće:
            • Jagoda
            • Limun
            • Avokado
        */
        public class Fruit
        {
            private string Vrsta;
            private string Boja;
            private bool JeLiSlatko;
            public Fruit(string s)
            {
                Vrsta = s;
            }
            public Fruit(string s1, string s2, bool b)
            {
                Vrsta = s1;
                Boja = s2;
                JeLiSlatko = b;
            }
        }
        public class Test
        {
            public static void Main()
            {
                Fruit x = new Fruit("Jagoda", "Crvena", true);
                Fruit y = new Fruit("Limun", "Žuta", false);
                Fruit z = new Fruit("Avokado");
            }
        }
    }

