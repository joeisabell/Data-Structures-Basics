using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Basics
{
    class Program
    {
        public static Random random = new Random();

        public static string randomName()
        {
            string[] names = new string[8] { "Dan Morain", "Emily Bell", "Carol Roche", "Ann Rose", "John Miller", "Greg Anderson", "Arthur McKinney", "Joann Fisher" };
            int randomIndex = Convert.ToInt32(random.NextDouble() * 7);
            return names[randomIndex];
        }

        public static int randomNumberInRange()
        {
            return Convert.ToInt32(random.NextDouble() * 20);
        }


        static void Main(string[] args)
        {
            // Create data structures
            Queue<string> qLine = new Queue<string>();
            Dictionary<string, int> dCustomers = new Dictionary<string, int>();

            // Declare variables
            int iCount = 0;

            // Load qeue object with names to represent the line of people
            while (iCount < 100)
            {
                qLine.Enqueue(randomName());
                iCount++;
            }

            // Loop through qLine object 
             foreach (string sCustom in qLine)
            {

                // Search dictionary for customer name, if it doesn't already exist
                // then add it to the dictionary 
                if (!dCustomers.ContainsKey(sCustom))
                {
                    dCustomers.Add(sCustom, 0);
                }

                // Add the number of burgers ordered to existing count in the dictionary
                dCustomers[sCustom] += randomNumberInRange();
            }

            // Write to the console the name and number of burgers for each 
            // person in the dictionary
            foreach(KeyValuePair<string,int> customer in dCustomers)
            {
                Console.Write(customer.Key);
                Console.WriteLine("\t\t" + customer.Value.ToString());
            }

            // Pause the program to be able to view the output on the console
            Console.ReadLine();


        }


    }
    
}
