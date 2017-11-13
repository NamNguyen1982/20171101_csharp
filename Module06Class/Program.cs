using Module06Class.Faktura;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06Class
{


    class Program
    {

        private static System.Random rnd = new Random();

        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(1, 7)); 
            }
            return;

            // Skab en variabel der kan pege på en Person
            Person p;
            // Skab en ny person og bind ref til p            
            p = new Person();


            string t = p.ToString();
            Console.WriteLine(t);

            // fejl
            //p = null;
            //string t1 = p.ToString();
            //Console.WriteLine(t1);

            Bil b = new Bil();

            //p = b;
            //b = p;

            Person p2 = new Person();

            p2.name = "Mikkel";
            p2.age = 14;

            p = null;


            Person p3 = new Person("Mikkel");
            p3.SetStreetValue("Odense");
            Console.WriteLine(p3.GetStreetValue());
            //p3.hairColor = "lsdjlfj";
        }
    }



}
