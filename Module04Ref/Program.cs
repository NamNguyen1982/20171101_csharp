using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

            // --------------------------------

            //string sti = "c:\\temp\\test.txt";
            string sti = @"c:\temp\test.txt";
            //string indholdAfFil = System.IO.File.ReadAllText(sti, System.Text.Encoding.Default);

            string n1 = "K";
            string n2 = "K";
            if (n1 == n2)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine("!=");
            }

            n1 = n1 + "*";

            Console.WriteLine("start");
            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();

            string tmp = "";
            for (int i = 0; i < 100000; i++)
            {
                tmp += "*";
            }
            tmp = tmp + "æjdædglkr" + " " + " lsdfgds ";
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);


            Console.WriteLine("start");
            System.Text.StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 1000000; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine("stop");

            string navn = "Mikkel Cronberg";
            Console.WriteLine(navn.Trim());
            string nyString = navn.ToUpper();
            Console.WriteLine(nyString);
            Console.WriteLine(navn.ToUpper());
            Console.WriteLine(navn.Substring(1, 2));
            var ar = navn.Split(' ');


            DayOfWeek wd = DayOfWeek.Saturday;
            switch (wd)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:


                    break;

                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                    continue;
                Console.WriteLine(i);
                if (i == 5)
                    break;
            }

            Console.WriteLine("Færdig");


            int[] testArray = { 1, 05, 51, 7, 1, 8, 3, 4, 1, 5 };
            Console.WriteLine(testArray);

            // Kommasep
            var ks = string.Join(", ", testArray);
            Console.WriteLine(ks);

            // Vis array som text (xml)
            XmlSerializer serializer = new XmlSerializer(testArray.GetType());
            System.Text.StringBuilder sbw = new StringBuilder();
            using (StringWriter writer = new StringWriter(sbw))
            {
                serializer.Serialize(writer, testArray);
            }
            Console.WriteLine(sbw.ToString());

            
            // vis array som text (json)
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(månedsløn, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);


            Hund[] hunde = new Hund[2];

            hunde[0] = new Hund();
            hunde[0].navn = "a";
            hunde[0].antalBen = 4;

            hunde[1] = new Hund();
            hunde[1].navn = "b";
            hunde[1].antalBen = 3;

            string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(hunde, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json2);




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
