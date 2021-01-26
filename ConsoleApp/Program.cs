using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static Dictionary<string, string> collegeCityDict = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            ReadCollegeCity();

            Console.WriteLine("Welcome to the College City Lookup App");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            Console.WriteLine("Please enter a collge and I will return the city.");

            string userinput = Console.ReadLine().ToUpper();
            while (userinput != "X")
            {
                string city = "";
                if (SearchDict(userinput, ref city))
                {
                    Console.WriteLine($"{userinput} is located in {city}");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine();
                    Console.WriteLine("Search for another University or press \"X\" to exit");
                    userinput = Console.ReadLine().ToUpper();

                }
                else if (userinput == "RANDOM" || userinput == "R")
                {
                    GetRandomCollegeCity();
                    Console.WriteLine("Search for another University or press \"X\" to exit");
                    userinput = Console.ReadLine().ToUpper();

                }
                else
                {
                    Console.WriteLine("College not found. Please search another state or type \"x\" to exit.");
                    Console.WriteLine();
                    userinput = Console.ReadLine().ToUpper();
                }
            }
        }
        /// <summary>
        /// gets a random college and city using the Random class.
        /// </summary>
        private static void GetRandomCollegeCity()
        {
            Random rand = new Random();
            var randDictEntry = collegeCityDict.ElementAt(rand.Next(0, collegeCityDict.Count));
            Console.WriteLine($"Random college and city: {randDictEntry.Key},{randDictEntry.Value}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userinput"></param>
        /// <param name="city"></param>
        /// <returns></returns>
        private static bool SearchDict(string userinput, ref string city)
        {
            if (collegeCityDict.TryGetValue(userinput, out city))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// loads the file and copies its contents to a dictionary (defined above). These values will be what we search through later. 
        /// </summary>
        private static void ReadCollegeCity()
        {
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText(@"C:\Users\dalli\source\repos\CollegeSearch\collegecity.txt");
                string tempread = "";
                while (!inputfile.EndOfStream)
                {
                    tempread = inputfile.ReadLine();
                    string[] tempcollegecity = tempread.Split(',');
                    collegeCityDict.Add(tempcollegecity[0].ToUpper(), tempcollegecity[1].ToUpper());
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
