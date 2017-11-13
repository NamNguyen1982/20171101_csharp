using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("test");
            //A1();

            int y = Test2();

            MinReturVærdi res = Test3();

            Hund[] res2 = Test4();

            int q = 5;
            Console.WriteLine(q);
            Test5(q);
            Console.WriteLine(q);


            int[] aa = { 5, 1, 5 };
            Console.WriteLine(aa[0]);
            Test6(aa);
            Console.WriteLine(aa[0]);

            int q1 = 5;
            Console.WriteLine(q1);
            Test5a(ref q1);
            Console.WriteLine(q1);


            Module06Class.Faktura.Person p = new Module06Class.Faktura.Person();
            



        }

        static int Test2() {
            return 3;
        }

        static MinReturVærdi Test3() {

            MinReturVærdi m;
            m.Success = true;
            m.Id = 1;
            return m;
        }

        static Hund[] Test4()
        {
            Hund[] hunde = new Hund[10];
            // kode....
            return hunde;

        }

        static void Test5(int a) {
            a++;
            a = a * 2;
            // kode.....

        }

        static void Test5a(ref int a)
        {
            a++;
            a = a * 2;
            // kode.....

        }

        static void Udskriv(string txt) { }
        static void Udskriv(int txt) { }
        static void Udskriv(bool txt) { }
        static void Udskriv(DateTime txt) { }

        static void Test6(int[] a)
        {
            a[0] = 1000;
        }


        static void Test()
        {
            Console.WriteLine("I test");
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                return;
            Console.WriteLine("Slut");
        }

        static void A1()
        {
            A2();
        }

        static void A2()
        {
            A3();
        }

        static void A3()
        {
            Console.WriteLine("I A3");
        }


    }

    struct MinReturVærdi {
        public bool Success;
        public int Id;
    }

    struct Hund { }
}
