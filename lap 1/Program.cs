using System;

namespace lap_1
{
    class Program
    {
        static void Main(string[] args)
        {


            ////--1
            //Console.WriteLine("Hello World!");




            ////--2
            //Console.WriteLine("please enter r");
            //int r = int.Parse(Console.ReadLine());
            //float a = 22 / 7 * r * r;
            //Console.WriteLine($"  area of circle is {a}");




            ////3--
            //int a = 2;
            //int b = 7;

            //Console.WriteLine($"num 1 + num2 ={ a + b}");
            //Console.WriteLine($"num 1 - num2 ={ a - b}");
            //Console.WriteLine($"num 1 x num2 ={ a * b}");
            //Console.WriteLine($"num 1 / num2 ={ a / b}");










            ////--4
            //Console.WriteLine("enter  char");

            //char chaar = char.Parse(Console.ReadLine());

            //int cc = chaar;

            //Console.WriteLine(cc);






            ////--5

            //int a;

            //Console.WriteLine("enter  number");
            //a = int.Parse(Console.ReadLine());


            //if (a % 2 == 0)
            //{
            //    Console.WriteLine(" number is even");
            //}
            //else if (a % 2 != 0)
            //{
            //    Console.WriteLine(" number is odd");
            //}
            //else
            //{
            //    Console.WriteLine(" number = zero");

            //}


            ////--6
            //int grade;

            //Console.WriteLine("enter your grade");
            //grade = int.Parse(Console.ReadLine());

            //if (grade >= 90 && grade <= 100)
            //    Console.WriteLine("a");
            //else if (grade >= 80 && grade < 90)
            //    Console.WriteLine("b");
            //else if (grade >= 70 && grade < 80)
            //    Console.WriteLine("c");
            //else if (grade >= 60 && grade < 70)
            //    Console.WriteLine("d");
            //else if (grade < 60)
            //    Console.WriteLine("f");
            //else
            //    Console.WriteLine("error");

            ////--7
            //int num;
            //Console.WriteLine("enter  number");
            //num = int.Parse(Console.ReadLine());

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("add");
            //        break;
            //    case 2:
            //        Console.WriteLine("edit");
            //        break;
            //    case 3:
            //        Console.WriteLine("display");
            //        break;
            //    case 4:
            //        Console.WriteLine("exite");
            //        break;





            //}


            //--8
            int a;
            int b;
            string c;
            Console.WriteLine("enter first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sign + , - ,* ,/");
            c =Console.ReadLine();

            switch (c)
            {
                
                case "+":
                    Console.WriteLine($"num 1 + num2 ={ a + b}");
                    break;
                case "-":
                    Console.WriteLine($"num 1 - num2 ={ a - b}");
                    break;
                case "*":
                    Console.WriteLine($"num 1 x num2 ={ a * b}");
                    break;
                case  "/":
                    Console.WriteLine($"num 1 / num2 ={ a / b}");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }

           






        }
    }
}
