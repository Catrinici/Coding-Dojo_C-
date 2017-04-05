using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           List<string> bikes = new List<string>();
            //Use the Add function in a similar fashion to push
            bikes.Add("Kawasaki");
            bikes.Add("Triumph");
            bikes.Add("BMW");
            bikes.Add("Moto Guzzi");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            //Accessing a generic list value is the same as you would an array
            Console.WriteLine(bikes[2]); //Prints "BMW"
            Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);

        }
    }
}
