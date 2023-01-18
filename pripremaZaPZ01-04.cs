using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanjaPrvoPolugodiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Napišite program u kojem ćete deklarirati 
            varijable a, b, c, i d tipa double
            te im dodijelite proizvoljne vrijednosti. 
            Deklarirajte varijablu x tipa double kojoj dodijelite
            vrijednost sljedećeg matematičkog izraza:

            a2 + b2 + c2 + d2
            __________________
            (a + b)2 + (c + d)2 
            */
            Console.WriteLine("\n1.1");
            double a = 1, b = 2, c = 3, d = 4;
            double x = (a * a + b * b + c * c + d * d) /
            ((a + b) * (a + b) + (c + d) * (c + d));
            Console.WriteLine(x);

            /*
            Napišite program u kojem ćete definirati 
            sljedeće dvije varijable tipa string:
                • s1 sa sadržajem "Hrvatska ima more"
                • s2 sa sadržajem "Italija je prvak svijeta"
            Definirajte i ispišite string s3 čiji će sadržaj biti 
            prvih 8 znakova stringa s1 plus svi znakovi 
            od sedmog do kraja niza s2.
            */
            Console.WriteLine("\n1.2");
            string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";
            string s3 = s1.Substring(0, 8) + s2.Substring(7);
            Console.WriteLine(s3);

            /*
            Napišite program koji će zatražiti od korisnika da unese 
            neku rečenicu te će ispisati prvu i zadnju riječ te rečenice.
            */
            Console.WriteLine("\n1.3");
            Console.WriteLine("Unesite neku rečenicu:");
            string s = Console.ReadLine();
            int pos = s.IndexOf(' ');
            Console.WriteLine(s.Substring(0, pos));
            pos = s.LastIndexOf(' ');
            Console.WriteLine(s.Substring(pos + 1));

            /*
            Napišite program u kojem ćete zatražiti od korisnika 
            da unese jedan cijeli i jedan decimalni broj odvojene razmakom. 
            Dvostruke vrijednosti unešenih brojeva spremite u odgovarajuće 
            varijable x i y, te ih ispišite.
            */
            Console.WriteLine("\n1.4");
            Console.WriteLine("Unesite cijeli i decimalni broj odvojene razmakom: ");
            string sX = Console.ReadLine();
            int posX = sX.IndexOf(' ');
            string s1X = sX.Substring(0, posX);
            int xX = Convert.ToInt32(s1X) * 2;
            double yX = Convert.ToDouble(sX.Substring(posX + 1)) * 2;
            Console.WriteLine("{0} {1}", xX, yX);

            /*
            Napišite program koji će od korisnika uzeti string
            te definirajte i ispišite novi string koji će sadržavati 
            sve znakove unešenog stringa osim prva dva i zadnja dva znaka. 
            Ako je niz dužine manje od 5 znakova treba ispisati cijeli niz.
            */
            Console.WriteLine("\n2.1");
            string sA = Console.ReadLine();
            if (sA.Length < 5)
                Console.WriteLine(sA);
            else
            {
                string sB = sA.Substring(2, sA.Length - 4);
                Console.WriteLine(sB);
            }

            /*
            Napišite program koji će provjeriti jesu li vrijednosti sadržane 
            u int varijablama x, y i z stranice pravokutnog trokuta. 
            U program uključite i provjeru da vrijednosti varijabli 
            za ovakav primjer imaju smislene vrijednosti 
            (iznosi moraju biti veći od 0).
            */
            Console.WriteLine("\n2.2");
            int x1 = 6, y = 8, z = 10;
            if ((x1 * x1 + y * y == z * z 
                || x1 * x1 + z * z == y * y 
                || y * y + z * z == x1 * x1) 
                && x1 > 0 && y > 0 && z > 0)
                Console.WriteLine("Trokut je pravokutan");
            else
                Console.WriteLine("Trokut nije pravokutan");

            /*
            Napišite program koji će zatražiti od korisnika da unese broj 
            te će u ovisnosti o unešenom broju ispisati jednu od sljedeće 4 poruke:
                • Broj je djeljiv s 4
                • Broj je djeljiv s 6
                • Broj je djeljiv sa 4 i sa 6
                • Broj nije djeljiv sa 4 ni sa 6
            Ako je broj djeljiv i sa 4 i sa 6 mora se ispisati poruka 
            “Broj je djeljiv sa 4 i sa 6”.
            */
            Console.WriteLine("\n2.3");
            Console.WriteLine("Unesite broj:");
            string str = Console.ReadLine();
            int br = Convert.ToInt32(str);
            if (br % 4 == 0 && br % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            else if (br % 4 == 0)
                Console.WriteLine("Broj je djeljiv sa 4");
            else if (br % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 6");
            else
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");

            /*
            Napišite program koji će izračunati vrijednost PDV-a 
            na osnovu od korisnika unešenih cijena bez PDV-a i s PDV-om.
            */
            Console.WriteLine("\n2.4");
            Console.WriteLine("Unesite cijenu bez PDV-a:");
            string sD = Console.ReadLine();
            double bezPDV = Convert.ToDouble(sD);
            Console.WriteLine("Unesite cijenu s PDV-om:");
            sD = Console.ReadLine();
            double sPDV = Convert.ToDouble(sD);
            if (sPDV < bezPDV)
                Console.WriteLine("Cijene nisu ispravno unešene");
            else
                Console.WriteLine("PDV iznosi {0} %",
                (sPDV - bezPDV) / bezPDV * 100);

            /*
            Napišite program koji će ispisati sve prijestupne godine 
            u razdoblju od (uključujući) 1900. do (uključujući) 2100. 
            Prijestupne godine su one koje su djeljive sa 400 
            plus one koje su djeljive sa 4, ali ne i sa 100.
            */
            Console.WriteLine("\n3.1");
            for (int i = 1900; i <= 2100; i++)
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                    Console.WriteLine(i);

            /*
            Napišite program koji će za unešeni niz znakova pronaći 
            znak koji se pojavljuje najviše puta te će i izračunati 
            taj broj (npr. VODOVOD -> O, 3 puta).
            */
            Console.WriteLine("\n3.2");
            char cH = ' ';
            int xH, maxH = 0;
            Console.WriteLine("Unesite riječ:");
            string sH = Console.ReadLine();
            for (int i = 0; i < sH.Length; i++)
            {
                xH = 0;
                for (int j = 0; j < sH.Length; j++)
                    if (sH[i] == sH[j])
                        xH++;
                if (xH > maxH)
                {
                    cH = sH[i];
                    maxH = xH;
                }
            }
            Console.WriteLine("Znak {0} {1} puta", cH, maxH);

            /*
            Napišite program koji će zatražiti od korisnika da unese dva broja
            te će izračunati najveći broj s kojim su oba broja djeljiva.
            */
            Console.WriteLine("\n3.3");
            int x11, y11, z11, max = 1;
            Console.WriteLine("Upišite prvi broj:");
            string s11 = Console.ReadLine();
            x11 = Convert.ToInt32(s11);
            Console.WriteLine("Upišite drugi broj:");
            s11 = Console.ReadLine();
            y11 = Convert.ToInt32(s11);
            z11 = x11 < y11 ? x11 : y11;
            for (int i = z11; i >= 1; i--)
                if (x11 % i == 0 && y11 % i == 0)
                {
                    max = i;
                    break;
                }
            Console.WriteLine(max);

            /*
            Napišite program koji će zatražiti od korisnika da unese 
            neki pozitivni broj, te će ispisati sve brojeve manje od 
            tog broja na sljedeći način: npr. za unešeni broj 5 treba ispisati:
                1
                12
                123
                1234
            */
            Console.WriteLine("\n3.4");
            Console.WriteLine("Upišite neki pozitivni broj:");
            string s34 = Console.ReadLine();
            int x34 = Convert.ToInt32(s34);
            for (int i = 1; i < x34; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }

            /*
            Napišite program koji će deklarirati dva niza tipa int 
            veličine 10 članova, te će zatražiti od korisnika da unosi brojeve. 
            Ako korisnik unese neparni broj spremite ga u prvi niz, 
            a ako unese parni spremite ga u drugi niz. 
            Program treba prestati s radom ako korisnik unese 0 
            ili kad ukupan broj članova dodijeljenih pojedinom nizu premaši 10. 
            Na kraju ispišite sve članove nizova.
            */
            Console.WriteLine("\n4.1");
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            string s41;
            int x41, n1 = 0, n2 = 0;
            do
            {
                Console.WriteLine("Upišite broj:");
                s41 = Console.ReadLine();
                x41 = Convert.ToInt32(s41);
                if (x41 % 2 != 0)
                    arr1[n1++] = x41;
                else
                    arr2[n2++] = x41;
            } while (x41 != 0 && n1 < 10 && n2 < 10);
            Console.WriteLine();
            for (int i = 0; i < n1; i++)
                Console.WriteLine(arr1[i]);
            Console.WriteLine();
            for (int i = 0; i < n2; i++)
                Console.WriteLine(arr2[i]);

            /*
            Napišite program koji će definirati 2 niza tipa int
            te će izračunati broj članova koji se nalaze na istom indeksu 
            i imaju istu vrijednost. Program mora raditi ispravno za 
            proizvoljni broj članova niza.
            */
            Console.WriteLine("\n4.2");
            int[] arr142 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] arr242 = { 3, 2, 8, 5, 5, 7 };
            int x42, count = 0;
            if (arr142.Length < arr242.Length)
                x42 = arr142.Length;
            else
                x42 = arr242.Length;
            for (int i = 0; i < x42; i++)
                if (arr142[i] == arr242[i])
                    count++;
            Console.WriteLine("Broj zajedničkih članova je {0}", count);

            Console.ReadKey();
        }
    
    }
}
