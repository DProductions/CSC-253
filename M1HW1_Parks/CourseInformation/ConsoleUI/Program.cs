/**
* 10 SEP 2023Date
* CSC 253
* Daniel Parks
* Course Information / Dictionaries 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseInformation;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                CourseDictionary courseDictionary = new CourseDictionary();

                // Prompt 
                Console.WriteLine("Available Courses:");
                foreach (string course in courseDictionary.GetAvailableCourses())
                {
                    Console.WriteLine(course);
                }

                Console.Write("Enter a course number or type 'exit' to quit: ");
                string selectedCourse = Console.ReadLine();

                if (selectedCourse.ToUpper() == "EXIT")
                {
                    exit = true;
                }
                else
                {
                    // Check Response
                    if (courseDictionary.TryGetCourseInfo(selectedCourse.ToUpper(), out var info))
                    {
                        // Retrieve Course Information
                        Console.WriteLine($"Course: {selectedCourse}");
                        Console.WriteLine($"Room: {info.room}");
                        Console.WriteLine($"Instructor: {info.instructor}");
                        Console.WriteLine($"Time: {info.time}");
                    }
                    else
                    {
                        // Display Invalid Entry
                        Console.WriteLine("Invalid entry. Please enter valid response.");
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear(); // Clear the console to reload the menu
                }
            }
        }
    }
}