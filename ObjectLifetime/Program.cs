namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new();
            
            myCar.Make = "Toyota";
            myCar.Model = "Supra";
            myCar.Year = 2020;
            myCar.Color = "White";

            Car myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "Corolla"; // changes model of myCar cos they point to the same address

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;

            // Console.WriteLine("{0} {1} {2} {3}",
            //     myOtherCar.Make,
            //     myOtherCar.Model,
            //     myOtherCar.Year,
            //     myOtherCar.Color);

            myCar = null;

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}