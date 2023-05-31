using System;
using System.Resources;
using System.Runtime.Intrinsics.Arm;

namespace ForSmallProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] arr = Console.ReadLine().Split();
            Console.WriteLine(arr[1] + " " + arr[0]);
            foreach (string s in arr)
            {
                sum += Convert.ToInt32(s);
            }
            Console.WriteLine(sum);



        }
    }
}
