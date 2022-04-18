using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program and ask the user to enter a few numbers 
            //    separated by a hyphen. Work out if the numbers are consecutive.
            //    For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //    display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //var list = new int[] { 1, 2, 3, 4, 5 };
            //var list2 = new int[] { 1, 3, 5, 7, 9 };
            //var list3 = new int[] { 12, 11, 10, 9, 8 };
            //Console.Write("Enter a few numbers, separated by a hyphen. ");
            //var input = Console.ReadLine();
            //var array = input.Split('-');
            //var numArray = Array.ConvertAll(array, int.Parse);
            //Console.WriteLine(Numbers.HasConsecutiveNums(numArray));
            //Console.WriteLine(ConsecutiveNumbers.HasConsecutiveNums(list));
            //Console.WriteLine(ConsecutiveNumbers.HasConsecutiveNums(list2));
            //Console.WriteLine(ConsecutiveNumbers.HasConsecutiveNums(list3));

            //2 - Write a program and ask the user to enter a few numbers separated 
            //    by a hyphen. If the user simply presses Enter, without supplying an 
            //    input, exit immediately; otherwise, check to see if there are duplicates. 
            //    If so, display "Duplicate" on the console.
            //Console.Write("Enter in a few numbers separated by a hyphen: ");
            //var userInput = Console.ReadLine();
            //if (!String.IsNullOrWhiteSpace(userInput))
            //{
            //    Console.WriteLine(Numbers.DuplicateNums(userInput));
            //}

            /* 
             3- Write a program and ask the user to enter a time value in the 24-hour 
            time format (e.g. 19:00). A valid time should be between 00:00 and 23:59. 
            If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
            If the user doesn't provide any values, consider it as invalid time.
            */

            var input = "25:00";
            var newInput = TimeSpan.Parse(input);
            var startTime = new TimeSpan(0, 0, 0);
            var endTime = new TimeSpan(23, 59, 0);
            var output = startTime <= newInput && endTime >= newInput;
            Console.WriteLine(output);

            /*
            4- Write a program and ask the user to enter a few words separated by a space. 
            Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
            So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
            */

            /*
            5- Write a program and ask the user to enter an English word. Count the number 
            of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", 
            the program should display 6 on the console.
            */
        }
    }
}
