/* Random dice = new Random();    // Random dice = new();
int roll = dice.Next(1, 7);    // upper bound is exclusive
Console.Write(roll); */


/* int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue); */

/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/


/* Challenge
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10) {
    Console.W
} */

/* Another string interpolation method
string firstName = "John";
string lastName = "Doe";
Console.WriteLine("Your name is {0} {1}", firstName, lastName); // in order
*/

//string.Format();
//string.Concat();


// Method overloading


// WORKING WITH STRINGS
// namespace WorkingWithStrings
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // escape sequence
//             // @"..."
//             // string.Format("{0:C}", 123.45)  currency
//             // string.Format("{0:N}", 123456890) = 123,456,890.00
//             // string.Format("{0:P}", 123)  percentage
//             // custom format
//             // Console.WriteLine(string.Format("{0:0##-###-####}", 548962145)); phone

//             // string methods
//             // StringBuilder
//         }
//     }
// }


//  DATES&TIMES
// namespace DatesAndTimes
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // DateTime myValue = DateTime.Now;
//             // Console.WriteLine(myValue); 28/09/2024 1:22 PM
//             // Console.WriteLine(myValue.ToShortDateString()); 28/09/2024
//             // Console.WriteLine(myValue.ToShortTimeString()); 1:22 PM
//             // Console.WriteLine(myValue.ToLongDateString()); Tuesday, 24 September 2024
//             // Console.WriteLine(myValue.ToLongTimeString()); 1:22:35 PM

//             // methods
//             // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
//             // Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
//             // Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

//             // Console.WriteLine(myValue.Month);

//             // past/future date-time
//             // DateTime myBirthday = new(2004, 03, 31);
//             // Console.WriteLine(myBirthday.ToShortDateString());

//             DateTime myBirthday = DateTime.Parse("31/03/2004");
//             TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
//             Console.WriteLine(myAge);
//             Console.WriteLine(myAge.TotalDays);

//             Console.ReadLine();
//         }
//     }
// }