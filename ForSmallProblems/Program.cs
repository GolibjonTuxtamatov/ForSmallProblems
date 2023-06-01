using System;
using System.Resources;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Versioning;

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

            Console.WriteLine("Enter the two number and first number is smaller than second number!");
            Console.Write("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());


            int count = secondNumber%2 == 0 ? 4 : 5;
            
            do
            {
                if (secondNumber - count >= firstNumber)
                {
                    int step = 3;
                    while (step > 0)
                    {
                        int num = secondNumber - count;
                        Console.WriteLine(num);
                        if (count < secondNumber && count-2 >= 0)
                        {
                            count -= 2;
                        }
                        step--;
                        if (step == 0)
                        {
                            break;
                        }
                    }
                }
                count -= 2;
            } while (count >= 0);



            //if (secondNumber % 2 == 0 && secondNumber-4>firstNumber)
            //{
            //    int count = 4;
            //    while(count >=0)
            //    {
            //        Console.WriteLine(secondNumber-count);
            //        count-=2;
            //    }
            //}
            //else if (secondNumber % 2 == 1 && (secondNumber-5>firstNumber))
            //{
            //    int count = 5;
            //    while (count >= 0)
            //    {
            //        Console.WriteLine(secondNumber - count);
            //        count -= 2;
            //    }
            //}

        }
    }
}
