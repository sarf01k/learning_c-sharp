// CLASSES
namespace SimpleClasses
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

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set;}
    }
}