using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaProvjeruZnanjaOO5._2
{
    /*
    Definirajte klasu GeometrijskiLik sa sljedećim članicama:
    • varijabla tipa int
        BrojStranica
    • niz tipa double veličine 10
        Stranice
    • metode
        UcitajStranice() koja će učitati od korisnika stranice geometrijskog lika
        Opseg() koja će vratiti opseg geometrijskog lika
    Definirajte klase Trokut i Cetverokut izvedene iz klase GeometrijskiLik
    te im definirajte konstruktore u kojima ćete varijabli 
    BrojStranica dodijeliti odgovarajuću vrijednost. 
    Definirajte dva objekta tipa Trokut i Cetverokut, 
    učitajte duljine stranica, te izračunajte opsege.
    */

    class GeometrijskiLik
    {
        protected byte BrojStranica;
        protected double[] Stranice = new double[10];
        public void UcitajStranice()
        {
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.WriteLine("Upišite duljinu {0}. stranice", i + 1);
                string s = Console.ReadLine();
                Stranice[i] = Convert.ToDouble(s);
            }
        }
        public double Opseg()
        {
            double opseg = 0;
            for (int i = 0; i < BrojStranica; i++)
                opseg += Stranice[i];
            return opseg;
        }
    }
    class Trokut : GeometrijskiLik
    {
        public Trokut()
        {
            BrojStranica = 3;
        }
    }
    class Cetverokut : GeometrijskiLik
    {
        public Cetverokut()
        {
            BrojStranica = 4;
        }
    }
    class Test
    {
        public static void Main()
        {
            Trokut t = new Trokut();
            t.UcitajStranice();
            Console.WriteLine("Opseg trokuta je {0}", t.Opseg());
            Cetverokut c = new Cetverokut();
            c.UcitajStranice();
            Console.WriteLine("Opseg četverokuta je {0}", c.Opseg());
        }
    }
}
