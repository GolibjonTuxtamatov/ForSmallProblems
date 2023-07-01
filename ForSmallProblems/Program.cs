using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ForSmallProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // finding the shortest word in string word

            //string word = "Salom men Toxamatov ne Golibjon";
            //string[] words = word.Split(' ');
            //string word2 = words[0];

            //for (int i = 0; i <= words.Length - 2; i++)
            //{
            //    if (word2.Length > words[i].ToString().Length)
            //    {
            //        word2 = words[i];
            //    }

            //}
            //Console.WriteLine(word2);

            // month name
            //int num = 1;
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("Yanvar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevral");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Aprel");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    default:
            //        Console.WriteLine("bunday raqamada oy yoq tushundingmi");
            //        break;

            // find normal number between three numbers

            //try
            //{
            //    while (true)
            //    {
            //        Console.Write("Enter the three number: ");
            //        int a = int.Parse(Console.ReadLine());
            //        int b = int.Parse(Console.ReadLine());
            //        int c = int.Parse(Console.ReadLine());
            //        if (a < b && a > c || a > b && a < c)
            //        {
            //            Console.WriteLine(a);
            //        }
            //        else if (b > a && b < c || b < a && b > c)
            //        {
            //            Console.WriteLine(b);
            //        }
            //        else if (c > a && c < b || c < a && c > b)
            //        {
            //            Console.WriteLine(c);
            //        }

            //    }
            //}
            //catch 
            //{
            //    Console.WriteLine();
            //}


            // to show stars

            // int num =5;
            //for(int i  = 0; i < num; i++)
            // {
            //     for(int k =5-i; k > 0; k--)
            //     {
            //         Console.Write(" ");
            //     }
            //     for(int j = 0; j < num; j++)
            //     {
            //         if(i == j || i > j)
            //         {
            //             Console.Write("* ");
            //         }
            //         else
            //         {
            //             Console.Write("  ");
            //         }
            //     }
            //     Console.WriteLine();


            //List<int> list = new List<int>();
            //int number  = int.Parse(Console.ReadLine());
            //int count = 0;
            //for (int i = 1; i < number; i++)
            //{
            //    if (number %i==0)
            //    {
            //        list.Add(i);
            //        count++;
            //    }
            //}
            //list.Add(number);

            //string result = count == 1 ? "Tub" : "Tub emas";
            //list.ForEach(Console.WriteLine);
            //Console.WriteLine(result);

            // Ekub

            //Console.WriteLine("Enter two number!!!");
            //int number1 = int.Parse(Console.ReadLine());
            //int number2 = int.Parse(Console.ReadLine());
            //int Ekub = 0;
            //for(int i = 1; i <= number1; i++)
            //{
            //    if(number1 % i == 0 && number2 % i == 0)
            //    {
            //        Ekub = i;
            //
            //}
            //Console.WriteLine(Ekub);


            //====================================

            //int number = int.Parse(Console.ReadLine());
            //int factorial = 1;

            //for(int i = 2; i<= number; i++)
            //{
            //    int count = 0;

            //    for (int j = 1; j< i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if(count == 1)
            //    {
            //        factorial *= i;
            //        Console.Write(factorial+" ");
            //    }
            //}

            //int numberZero = 0;
            //while (factorial % 10 == 0)
            //{
            //    factorial /= 10;
            //    numberZero++;
            //}
            //Console.WriteLine(numberZero);



            // Perfect Number 

            //int number = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i < number; i++)
            //{
            //    if(number % i == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //string m = number == sum ?"Perfect" : "Not Perfect";
            //Console.WriteLine(m);

            // Armstrong
            //int num = int.Parse(Console.ReadLine());

            //for(int i = 0; i < num; i++)
            //{
            //    checkArmstrong(i);

            //}
            checkZeroOne("11111");

        }
        
        static void checkZeroOne(string num)
        {
           
            bool check =  true;
            for(int i = 0;i < num.Length; i++)
            {
                if(num[i]=='1')
                {   
                    if(check == false)
                    {
                        check = true; break;
                    }
                    check = true;
                }
                else if (num[i]=='0')
                {
                    
                    check = false;
                }

            }
            string result = check ? "NO" : "YES";
            Console.WriteLine(result);
        }
        static void checkArmstrong(int number)
        {
            int n = number;
            int lengthNum = number.ToString().Length;
            int num1 = 0;
            while (number != 0)
            {
                int num2 = 1;
                int num3 = number % 10;
                for(int i = 0; i < lengthNum; i++)
                {
                    num2 *= num3;
                }
                num1 += num2;
                number /= 10;

            }

            if (n == num1)
            {
                Console.WriteLine(n);
            }
        }

    }

    
}
