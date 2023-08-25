using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4.Assignments_ALL
{
    class Reverse_Sentence_10
    {
        static void Main(string[] args)
        {
            //2type can be done 
            
            Reversesentence1();
            Reversesentence2();
        }

        private static void Reversesentence2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter the Sentence to Reverse");
            string s = Console.ReadLine();
            string[] array = s.Split(' ');
            Array.Reverse(array);
            Console.WriteLine("Reverse string is :");
            foreach(var item in array)
            {
                Console.Write(item+" " +' ');
               // Console.WriteLine();
            }

           // Array.Reverse(s);

        }

        private static void Reversesentence1()
        {
            
        }
    }
}
//1.Exception handling 2.File IO 1. Events and Deligates -> 4 Garbage Collections.