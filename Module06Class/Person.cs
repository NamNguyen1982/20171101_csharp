namespace Module06Class.Faktura
{

    //public partial  class Person {
    //    public string city;
    //}

    public partial class Person {

        public string name;
        public int age;
        public string[] pets;
        public Person mother;
        private string street;
        public readonly string hairColor;


        // ....

        // Default constructor (ingen argumenter)
        public Person() {
            System.Console.WriteLine("Nu bliver jeg født....");
            // initialsering af felter
            this.name = "";            
            this.age = 0;
            this.pets = new string[2];
            this.pets[0] = "Dog";
            this.pets[1] = "Cat";
            this.mother = null;
        }

        public string GetStreetValue() {
            // log
            // sikkerhed

            return this.street;
        }

        public void SetStreetValue(string street) {
            if (street == "")
            {
                System.Console.WriteLine("Fejl");
                return;
            }
            if (street == null)
            {
                System.Console.WriteLine("Fejl");
                return;
            }

            // valideringer....
            // min logik
            this.street = street.Trim().ToUpper();
        }

        // custom constructor
        public Person(string name, int age, string street )
        {
            if (name == "")
                System.Console.WriteLine("Fejl");

            this.name = name;
            this.age = age;
            this.street = street;
        }

        // custom constructor
        public Person(string name) : this(name, 0, "")
        {
            //if(name =="")
            //    System.Console.WriteLine("Fejl");
            //this.name = name;            
        }



        // Destructor
        ~Person() {
            System.Console.WriteLine("Nu dør jeg....");
            // rydde op - lukke IO/DB
        }

    }



}
