namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new();
            
            // myCar.Make = "Toyota";
            // myCar.Model = "Supra";
            // myCar.Year = 2020;
            // myCar.Color = "White";

            Car myOtherCar = myCar;
            Car myThirdCar = new("Ford", "Escape", 2005, "White");

            // Console.WriteLine("{0} {1} {2} {3}",
            //     myOtherCar.Make,
            //     myOtherCar.Model,
            //     myOtherCar.Year,
            //     myOtherCar.Color);

            // myOtherCar.Model = "Corolla"; // changes model of myCar cos they point to the same address

            // Console.WriteLine("{0} {1} {2} {3}",
            //     myCar.Make,
            //     myCar.Model,
            //     myCar.Year,
            //     myCar.Color);

            Car.MyMethod();

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        // Constructor - allows to execute code when a new instance of a class is created
        // typically used to initialise values(from a config file, db...) of an object

        // public Car()
        // {
        //     this.Make = "Nissan"; // 'this' is optional,("this" instance)
        // }

        // overloaded constructor
        // public Car(string make, string model, int year, string color)
        // {
        //     Make = make;
        //     Model = model;
        //     Year = year;
        //     Color = color;
        // }

        // 'static' means you do not need to instantiate a class before\
        // using the class' method/property
        public static void MyMethod()
        {
            Console.WriteLine("Called the static 'MyMethod'");
        }
    }
}