using System;
using System.Buffers;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;

namespace ForSmallProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //int sum = 0;
            //string[] arr = Console.ReadLine().Split();
            //Console.WriteLine(arr[1] + " " + arr[0]);
            //foreach (string s in arr)
            //{
            //    sum += Convert.ToInt32(s);
            //}
            //Console.WriteLine(sum);

            //======================================

            // Tub son

            //for(int i = 2; i < 100; i++)
            //{
            //    int count = 0;
            //    for (int j = 1; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 1)
            //    {
            //        Console.Write(i+" ");
            //    }
            //}

            //======================

            //for(int i = 100; i < 1000; i++)
            //{
            //    string j = i.ToString();
            //    if (j[0] == j[1] && j[0] != j[2]|| j[0] == j[2] && j[0] != j[1] || j[1] == j[2] && j[0] != j[1])
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            //========================================
            // this solve shows pair three numbers in between two number

            //Console.WriteLine("Enter the two number and first number is smaller than second number!");
            //Console.Write("Enter the first number:");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number:");
            //int secondNumber = int.Parse(Console.ReadLine());


            //int count = secondNumber%2 == 0 ? 4 : 5;

            //do
            //{
            //    if (secondNumber - count >= firstNumber)
            //    {
            //        int step = 3;
            //        while (step > 0)
            //        {
            //            int num = secondNumber - count;
            //            Console.WriteLine(num);
            //            if (count < secondNumber && count-2 >= 0)
            //            {
            //                count -= 2;
            //            }
            //            step--;
            //            if (step == 0)
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    count -= 2;
            //} while (count >= 0);


            //=========================

            //int[] number = { 1, 2, 3 };
            //int[] number2 = { 1, 2, 3 };
            //int[] number3 = new int[3];
            //for(int i = 0; i < 3; i++)
            //{
            //    number3[i] = number[i] + number2[i];
            //}
            //Array.ForEach(number3, Console.WriteLine);

            //int reverseNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //======================================

            //string num = Console.ReadLine();
            //char[] reverseNum = new char[num.Length];

            //for(int i = 0; i< num.Length; i++)
            //{
            //    reverseNum[i] = num[i];
            //}
            //Array.Reverse(reverseNum);
            //int gum = int.Parse(new string(reverseNum));
            //Console.WriteLine(gum);

            //==============================================

            //int[] ar = { 1, 2, 3, 5, 5 };
            //int[] num = TwoSum(ar, 5);
            //Array.ForEach(num,Console.WriteLine);

            //=============================
            // palindrome number

            //int number = int.Parse(Console.ReadLine());
            //int rem = 0;
            //int number2 = number;

            //while (number != 0)
            //{
            //    int num = number % 10;
            //    rem = rem * 10 + num;
            //    number = number / 10;
            //}

            //if(number2 == rem)
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);
            //====
            //string str = Console.ReadLine();

            //char[] strArr = new char[str.Length];

            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    strArr[i] = str[i];
            //}
            //Array.Reverse(strArr);
            //string str2 = new string(strArr);
            //if (str ==  str2)
            //    Console.WriteLine(true);
            //else
            //    Console.WriteLine(false);

            //I             1
            //V             5
            //X             10
            //L             50
            //C             100
            //D             500
            //M             1000
            // IV = 4 IX = 9 XL = 40 XC = 90 CD = 400 CM = 900 
            //string strnum = Console.ReadLine();

            //char[] str = new char[] { };
            //for(int i = 0; i < strnum.Length; i++)
            //{
            //    str[i] = strnum[i];
            //}

            //int i = 0;
            //StringBuilder justString = new StringBuilder();
            //int number=0;
            //while (i!=strnum.Length)
            //{

            //    switch (i)
            //    {
            //        case 'M':
            //            break;
            //    }
            //}




            Console.WriteLine("Hello World!");


        }
        //public static int[] TwoSum(int[] nums, int target)
        //{

        //    int[] output = new int[2];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = 0; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //            {
        //                output[0] = i;
        //                output[1] = j;
        //            }

        //        }
        //    }
        //    return output;

        //}
    }
}
