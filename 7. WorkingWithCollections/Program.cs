// LINQ - Language Integrated Query
// collections - lists, dictionaries....
namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new();
            car1.Make = "Toyoyta";
            car1.Model = "Supra";
            car1.VIN = "A1";

            Car car2 = new();
            car2.Make = "Honda";
            car2.Model = "Civic";
            car2.VIN = "A2";

            Book book1 = new();
            book1.Author = "Bob Tabor";
            book1.Title = "MS .NET Services";
            book1.ISBN = "0-000-00000-0";

            // ** old style
                // ArrayLists - are dynamically sized,
                // cool features - sorting, remove items..
                // System.Collections.ArrayList myArrayList = new();
                // myArrayList.Add(car1);
                // myArrayList.Add(car2);
                // myArrayList.Add(book1);
                // myArrayList.Remove(book1);
                // // disadvantage - does not allow limits on what can be stored
                // // e.g. the above allowed to store smth other than cars
                // foreach (Car car in myArrayList)
                // {
                //     Console.WriteLine(car.Make);
                // }

            // ** new style
                // Generic list - allows to specify data type
                // List<Car> myList = new List<Car>();
                // myList.Add(car1);
                // myList.Add(car2);

                // foreach (Car car in myList)
                // {
                //     Console.WriteLine(car.Make);
                // }

                // Dictionary (Dictionary<TKey, TValue>)
                // Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
                // myDictionary.Add(car1.VIN, car1);
                // myDictionary.Add(car2.VIN, car2);

                // Console.WriteLine(myDictionary["A1"].Model);

            // ** initialise objects
            //  no need for constructor
            Car car3 = new() { Make = "BMW", Model = "M2", VIN = "V3" };

            // ** initialise collections
            List<Car> cars = new List<Car>() {
                new Car { Make = "Porsche", Model = "GT3", VIN = "H65" },
                new Car { Make = "Nissan", Model = "Skyline", VIN = "K90" }
            };

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}