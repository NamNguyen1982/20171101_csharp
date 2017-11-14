using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07Prop
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            //p.SetName("A");
            //Console.WriteLine(p.GetName());
            p.Name = "A";
            p.Country = "sldfældfk";
            Console.WriteLine(p.Name);

            


        }
    }

    public class Person {


        // Automatisk egenskab
        public string Country { get; set; }

        // Fuld egenskab
        //private string country;

        //public string Country
        //{
        //    get { return country; }
        //    set {

        //        country = value; }
        //}


        private int age;
        public int Age
        {
            get {
                return age; }
            set {
                age = value; }
        }


        private string name;
        public string Name {
            get {
                //    // validering
                //    // log
                //    // sikkerhed
                return this.name;
            }
            set {
                //    // validering
                //    // log
                //    // sikkerhed
                if (value == null)
                    value = "";
                this.name = value;
            }
        }

        public Person(string name)
        {
            this.Name = name;
        }

        //public void SetName(string value) {
        //    // validering
        //    // log
        //    // sikkerhed
        //    this.Name = value;
        //}

        //public string GetName() {
        //    // validering
        //    // log
        //    // sikkerhed
        //    return this.Name;
        //}
    }

    public class Hund {

        

        public string Navn { get; set; }
        public int Alder { get; set; }
        //public int AntalBen { get; set; }
        private int antalBen;

        public int AntalBen
        {
            get {

                return antalBen; }
            set {

                antalBen = value; }
        }



    }
}
