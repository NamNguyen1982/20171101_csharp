using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            // int y = 1;
            string navn;
            var i = 1;


            int y = 1;
            int x = 10;
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int32.MaxValue);

            y = x;

            x = 100;


            Person p;
            p.navn = "Mikkel";
            p.alder = 14;

            Person q;
            q.navn = "Mathias";
            q.alder = 11;

            //q = p;

            q.alder = 9;

            // heltal
            System.Int32 h1;
            int h2;

            // decimal
            System.Decimal d1;
            decimal d2 = 56565.34M;
            Console.WriteLine(d2.ToString("N4"));
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            bool b = false;

            DateTime d = DateTime.Now;
            DateTime m = new DateTime(2017, 12, 24);

            TimeSpan t = m.Subtract(d);
            Console.WriteLine(t.TotalDays);


            //int u = 100;
            int u;
            u = 100;
            u = u + 1;

            string fornavn;
            int antalIProcent;

            int r = 10;
            Console.WriteLine(r.ToString());

            Console.WriteLine(m.ToString("dddd MMMM yyyy"));

            // konfigurationsfil ???
            const decimal momsPct = 0.25M;

            const int antalMånedPrÅr = 12;
            // antalMånedPrÅr = 11;

            i = 0;
            i++;
            i += 1;
            i = i + 1;

            int ms = DateTime.Now.Millisecond;
            //var ms = DateTime.Now.Millisecond;
            if (ms % 2 == 0 && DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Lige - onsdag");
            }
            else
            {
                Console.WriteLine("Ulige - onsdag");
            }

            // checked vil sørge for at smide en exception
            int yy = 50000000;
            //checked
            //{
            //    short uu = (short)yy;
            //}
            //short uu = Convert.ToInt16(yy);

            var navn2 = "Mikkel";


            // int kønPerson = 1;      // mand = 1, kvinde = 2

            Køn kønPerson = Køn.Kvinde;
            Console.WriteLine(kønPerson);
            Console.WriteLine(kønPerson.ToString());
            Console.WriteLine(Convert.ToInt32(kønPerson));


            Farve f = Farve.Hjerter;

            System.DayOfWeek w = DayOfWeek.Wednesday;
            switch (kønPerson)
            {
                case Køn.Mand:

                    break;
                case Køn.Kvinde:

                    break;

                default:

                    break;
            }

            string navn1 = "Mikkel";
            int alder1 = 14;

            Person a;
            a.navn = "a";
            a.alder = 11;
            a.adresse = "ædfgdfksjg";

            string c = "dgælfjgædkjgldksjg ælk gjælsdfkgj æsdlgfj sd";

            char tegn = 'e';




        }
    }

    enum Køn 
    {
        Mand,
        Kvinde
    }

    enum Farve {
        Spar,
        Klør,
        Hjerter,
        Ruder
    }

    // Værdibaseret klasse (struct - på stack)
    struct Person
    {
        public string navn;
        public int alder;
        public string adresse;
    }
}
