using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Task 1");
            Console.WriteLine("...........\n");
            Console.WriteLine(PowerRanger(1, 1, 27));
            Console.WriteLine("\n...........");

            Console.WriteLine($"Task 2");
            Console.WriteLine("...........\n");
            Console.WriteLine(SockParis("BBBBBB"));
            Console.WriteLine("\n...........");

            Console.WriteLine($"Task 3");
            Console.WriteLine("...........\n");
            Console.WriteLine(LongestCommonEnding("Programming", "It is Programming"));
            Console.WriteLine("\n...........\n");

            Console.WriteLine($"Task 4");
            Console.WriteLine("...........\n");
            var ListOfint = new List<int>() { 5, 5 };
            var ListOfString = new List<string>() { "Car", "Programming", "Word", "Key" };
            var ListOfBools = new List<bool>() { true, false, true, false, true, false, false, };
            var ListOfDobule = new List<double>() { 5, 4, 6 };
            GenericMethod(ListOfint);
            GenericMethod(ListOfString);
            GenericMethod(ListOfBools);
            GenericMethod(ListOfDobule);
            Console.WriteLine("\n...........");

            Console.WriteLine($"Task 2");
            Console.WriteLine("...........\n");
            separateDigits(12345);
            Console.WriteLine("\n..........."); 
        }

        public static int PowerRanger(int power, int min, int max)
        {
            int counter = 0;
            for (int i = min; i <= max; i++)
            {
                if (Math.Pow(i, 1.0 / power) % 1 == 0) counter++;
            }
            return counter;
        }

        public static int SockParis(string socks)
        => socks.ToCharArray().GroupBy(c => c).Select(c => c.Count() / 2).Sum();
        //Because we have a one-line method, I used ( => )

        public static string LongestCommonEnding(string str1, string str2)
        {
            for (int i = 0; i < str1.Length; i += 1)
            {
                string subStr = str1.Substring(i);
                if (str2.EndsWith(subStr))
                {
                    return subStr;
                }
            }

            return "";
        }

        static void GenericMethod<T>(List<T> somelist)
        {
            int sum = 0;
            int listsize = somelist.Count;
            if (typeof(T) == typeof(string))
            {
                foreach (var item in somelist)
                {
                    Console.WriteLine(item.ToString().ToUpper());
                    // Because the code is generic, I converted it string
                }
            }
            else if (typeof(T) == typeof(int))
            {
                foreach (var item in somelist)
                {
                    sum = sum + Convert.ToInt32(item);
                }
                Console.WriteLine(sum);
            }
            else if (typeof(T) == typeof(bool))
            {
                Console.WriteLine($"First Element is {somelist[0]}");
                Console.WriteLine($"First Element is {somelist[--listsize]}");
                Console.WriteLine($"First Element is {somelist[listsize / 2]}");
            }
           else
            {
                Console.WriteLine("This Type Is Not Supported");
            }
        }

        static void separateDigits(int n)
        {
            if (n < 10)
            {
                Console.WriteLine($"{n}-");
                return;
            }
            separateDigits(n / 10);
            Console.WriteLine($"{n % 10}-");
        }
    }
   
}
