using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04Ref
{
    class Program
    {
        static void Main(string[] args)
        {

            Kat k1;
            k1.navn = "a";
            k1.alder = 6;
            Kat k2;
            k2.navn = "b";
            k2.alder = 10;
            k1 = k2;    // værdier kopieres....
            k1.alder = 100;



            //Hund h1 = new Hund();
            Hund h1;
            h1 = new Hund();
            h1.navn = "x";
            h1.antalBen = 4;

            Hund h2 = new Hund();
            h2.navn = "y";
            h2.antalBen = 3;

            h1 = h2;        // KOPIER REF
            h1.antalBen = 8;
            // hvad er h2.antalben???

            
            // ---------------------------

            int mdr1 = 1000;
            int mdr2 = 3000;
            int mdr3 = 2000;
            int mdr4 = 6000;
            decimal gns = (mdr1 + mdr2 + mdr3 + mdr4) / 4;
            Console.WriteLine(gns.ToString("N2"));

            // int[] månedsløn;
            //månedsløn = new int[6];
            //månedsløn[0] = 1000;
            //månedsløn[1] = 3000;
            //månedsløn[2] = 2000;
            //månedsløn[3] = 6000;
            //månedsløn[4] = 4000;
            //månedsløn[5] = 8000;
            int[] månedsløn = { 1000, 3000, 2000, 6000, 4000, 8000, 2000, 2000 };

            //Console.WriteLine(månedsløn[7]); exception


            decimal gns2 = 0;
            for (int i = 0; i < månedsløn.Length; i++)
                gns2 += månedsløn[i];
            gns2 = gns2 / månedsløn.Length;
            Console.WriteLine(gns2.ToString("n2"));


            var gns3 = månedsløn.Average();
            
            // LINQ
            var res = månedsløn.Where(i => i > 3000).OrderBy(i => i);
            var res2 = månedsløn.OrderBy(i => i).GroupBy(i => i);

        }
    }

    struct Kat
    {

        public string navn;
        public int alder;
    }

    class Hund
    {

        public string navn;
        public int antalBen;

    }
}
