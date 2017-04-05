using System;
using System.Collections.Generic;
namespace ConsoleApplication;
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //Three Basic Arrays
           //Create an array to hold integer values 0 through 9
           int[] numArray = new int[10] {0,1,2,3,4,5,6,7,8,9};

           //Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
           string[] names = new string[] {"Tim", "Martin", "Nikki", "Sara"};

           //Create an array of length 10 that alternates between true and false values, starting with true
           bool[] boolArray = new bool[10];
           {
            for( int i = 0; i < boolArray.Length; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
             }
           }
           //Multiplication table
           int[,] mult = new int[10,10];
            for(int x = 0; x < 10; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    mult[x, y] = (x + 1) * (y + 1);
                }
            }
            Console.WriteLine("Multiplication table:");
            Console.WriteLine(mult);

           /**************List of Flavors***************/
           //Create a list of Ice Cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
           List<string> flavors = new List<string>();
           flavors.Add("Vanilla");
           flavors.Add("Chocolate");
           flavors.Add("Strowberry");
           flavors.Add("Caramel");
           flavors.Add("Cherry");
           //Output the length of this list after building it
           Console.WriteLine("The length of the list is: " + flavors.Count);
           //Output the third flavor in the list, then remove this value.
           Console.WriteLine("The third flavor in the list is: " + flavors[2]);
           flavors.RemoveAt(2);
           //Output the new length of the list (Note it should just be one less~)
           Console.WriteLine("The new length of the list is: " + flavors.Count);

           /*************User Info Dictionary*************/
           //Create a Dictionary that will store both string keys as well as string values
           Dictionary<string,string> userInfo = new Dictionary<string,string>();
           //For each name in the array of names you made previously, add it as a new key in this dictionary with value null
           Random rand = new Random();
           foreach(string name in names)
           {
               userInfo[name] = flavors[rand.Next(flavors.Count)];
           }

           //Loop through the Dictionary and print out each user's name and their associated ice cream flavor.
            Console.WriteLine("Users and their favor ice cream flavors:");
            foreach(KeyValuePair<string, string> info in userInfo)
            {
                Console.WriteLine(info.Key + " - " + info.Value);
            }
    
        }
    }
}
