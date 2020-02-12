using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName;
            // Write out prompt to the console
            Console.WriteLine("Enter filename");
            // Read the filename from the console
            fileName = Console.ReadLine();

            // Test whether file exists

            // If the file exists
            if (File.Exists(fileName))
            {
                Console.WriteLine("File exists");
                // Ask the user to enter the temperature threshold
                Console.WriteLine("Enter threshold");
                string input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempCount = 0;

                // Open the file and create Stream Reader
                // Read a line into a string varible
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string line = sr.ReadLine();
                    int temp;
                    // While the line is not null
                    while (line != null)
                    {
                        // Convert(parse) into an integer variable
                        temp = int.Parse(line);
                        // Add the temperature to my summing variable
                        sumTemps += temp;

                        // Increment temp count
                        tempCount += 1;

                        // If the current temperature value >= threshold
                        if (temp >= threshold)
                        {
                            // Increment "above" counter by 1
                            numAbove += 1;
                        }
                        else
                        {
                            // Else (temperature is below)
                            // increment the "Below" counter by one
                            numBelow += 1;
                        }

                        line = sr.ReadLine();
                    }

                }
                //Print out temperature above the threshold 
                Console.WriteLine("Temperatures above =" + numAbove);

                // Print out temperature below the threshold
                Console.WriteLine("Temperatures above =" + numBelow);

                int average = sumTemps / tempCount;

                Console.WriteLine("Average temp =" + average);

            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
    }
}
