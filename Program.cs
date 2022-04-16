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

            var list = new int[] { 1, 2, 3, 4, 5 };
            var list2 = new int[] { 1, 3, 5, 7, 9 };
            var list3 = new int[] { 12, 11, 10, 9, 8 };
            Console.WriteLine(ConsecutiveNumbers.HasConsecutiveNums(list));
            Console.WriteLine(ConsecutiveNumbers.HasConsecutiveNums(list2));
            Console.WriteLine(ConsecutiveNumbers.HasConsecutiveNums(list3));

            //list3.Sort();
            //bool isConsecutive = true;
            //for (var i = 0; i < list3.Count(); i++)
            //{
            //    if (i == (list3.Count() - 1))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        if ((list3[i] + 1) != list3[i + 1])
            //        {
            //            Console.WriteLine("not consecutive");
            //            isConsecutive = false;
            //            break;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}
            //if (isConsecutive)
            //{
            //    Console.WriteLine("Consecutive");
            //}

        }
    }
}
