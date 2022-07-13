using System;
using System.Collections.Generic;

namespace Delegate
{
    //public delegate bool CheckNums(int num);

    public delegate void ChangeString(string str);
    class Program
    {
       
        static void Main(string[] args)
        {
           
            int[] arr = { 1, 2, 3, 5, 6, 8, 10 };
            //Console.WriteLine(Sum(CheckOdd, arr));
            //Console.WriteLine(Sum(CehckEven, arr));
            //Console.WriteLine(Sum(ChecThanFive,arr));

            //List<int> numbers = new List<int>() { 2, 3, 5, 6, 8, 9, 11 };

            //var result = numbers.FindAll(m => m >6);

            //var result2 = numbers.FindAll(ChecThanFive);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            Test(StringToUpper, "Sadiq");
        }

        //public static void Car() => Console.WriteLine("Cars");

        public static void StringToUpper(string word)
        {
            Console.WriteLine(word.ToUpper());
        }

        public static void StringToLower(string word)
        {
            Console.WriteLine(word.ToLower());
        }

        public static void Test(ChangeString func, string word)
        {
            func(word);
        }
        //public static bool CheckOdd(int number)
        //{
        //    return number % 2 != 0;
        //}
        //public static bool CehckEven(int number)
        //{
        //    return number % 2 == 0;
        //}


        //public static bool ChecThanFive(int number)
        //{
        //    return number > 8;
        //}

        //public static int Sum(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
        //public static int SumEven(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}

        //public static int SumThanFive(int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }
        //    return sum;
        //}
    }
}
