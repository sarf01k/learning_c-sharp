namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car { VIN = "A1", Make = "Toyota", Model = "Supra", StickerPrice = 55000, Year = 2020 },
                new Car { VIN = "B2", Make = "Mazda", Model = "Q2", StickerPrice = 47000, Year = 2004 },
                new Car { VIN = "C3", Make = "Ford", Model = "Escape", StickerPrice = 30000, Year = 2012 },
                new Car { VIN = "E5", Make = "BMW", Model = "E16", StickerPrice = 26000, Year = 2009 },
                new Car { VIN = "D4", Make = "BMW", Model = "M3", StickerPrice = 50000, Year = 2017 },
            };

            // -- LINQ query syntax
                /*
                var bmws = from car in myCars
                            where car.Make == "BMW"
                            && car.Year ==  2017
                            select car;
                */

                // var orderedCars = from car in myCars
                //                     orderby car.Year descending
                //                     select car;

            // -- LINQ method syntax
                var bmws = myCars.Where(car => car.Make == "BMW" && car.Year == 2017);

                var orderedCars = myCars.OrderByDescending(car => car.Year);

                // first BMW
                /*
                var firstBMW = myCars.First(car => car.Make == "BMW");
                var firstBMW = myCars.OrderByDescending(car => car.Year).First(car => car.Make == "BMW");
                Console.WriteLine(firstBMW.Year);
                */

                // "true for all"
                // Console.WriteLine(myCars.TrueForAll(car => car.Year > 2002));

            // myCars.ForEach(car => Console.WriteLine("{0} {1:C}", car.Model, car.StickerPrice));

            // some car exists
            // Console.WriteLine(myCars.Exists(car => car.Model == "Supra"));

            // Console.WriteLine(myCars.Sum(car => car.StickerPrice));

            // get data type
            // myCars.GetTpye();

            // foreach (var car in orderedCars)
            // {
            //     Console.WriteLine("{0} {1}", car.Year, car.Model , car.VIN);
            // }

            // anonymous type
            var newCars = from car in myCars
                            where car.Make == "BMW"
                            && car.Year ==  2017
                            select new { car.Make, car.Model };
            
            Console.WriteLine(newCars);


            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int StickerPrice { get; set; }
    }
}