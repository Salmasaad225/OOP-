using System;
using System.Linq;

namespace ass2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Print Multiples of num 4 from 0 to 100[for loop] مضاعفات الرقم 4



            //for (int x = 1; x<=100; x++ )
            //{
            //    if (x%4==0)
            //    {
            //        Console.WriteLine($" {x} devisble by 4");
            //    }
            //}





            // 2.Calculate multiplication of 10 numbers givin by user[for loop]. ضرب 10 اعداد هيدخلهم المستخدم
            //int mul=1;
            //for (int x = 1; x <= 10; x++)
            //{
            //    Console.WriteLine(" please enter 10 numers");
            //    int y = int.Parse(Console.ReadLine());
            //    //mul *= y;
            //    mul = mul * y;
            //}

            //Console.WriteLine(mul);






            //3.Print ASCII code for all char from 0 - 255[for loop]  هنطلع الحرف المقابل لل ascii للارقام من 0-255


            //for (int x = 0; x <= 255; x++)
            //{
            //    Console.WriteLine((char)x);
            //}





            //4.Get numbers from user until total reaches 100[while]  3  50 37 20


            //Console.WriteLine("please enter number");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;

            //while (num <100 )
            //{
            //    sum += num;

            //    if (sum >= 100)
            //        break;
            //    else
            //    {
            //        Console.WriteLine($"sum of numbers is {sum}");
            //        Console.WriteLine("please enter another number");
            //        num = int.Parse(Console.ReadLine());


            //    }
            //}





            // 5.Print ASCII code a char from user until user press x[do while] هناخد حروف من المستخدم ونحولها ل اسكى لحد مايدخل اكس ونوقف

            //char chaar;
            //do
            //{
            //    Console.WriteLine("enter  char");

            //    chaar = char.Parse(Console.ReadLine());

            //    if (chaar == 'x')
            //        break;
            //    else
            //    {
            //        int cc = chaar;
            //        Console.WriteLine(cc);
            //        Console.WriteLine("enter another  char");
            //        chaar = char.Parse(Console.ReadLine());

            //    }
            //} while (chaar != 'x');


















            // 6.Print simple menu again inside do while.
            //int num;

            //do
            //{
            //    Console.WriteLine("enter  number");
            //    num = int.Parse(Console.ReadLine());

            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("add");
            //            break;
            //        case 2:
            //            Console.WriteLine("edit");
            //            break;
            //        case 3:
            //            Console.WriteLine("display");
            //            break;
            //        case 4:
            //            Console.WriteLine("exite");
            //            break;

            //        default:
            //            Console.WriteLine("error");
            //            break;


            //    }
            //} while (num < 5 && num > 0);








            //Arrays:
            //   1 - Write a program to get sum of 1 student grades and get average and Greatest num then print message if "Success" or "Fail"

            //int sum = 0;
            //int avg = 0;
            //int size;
            //string ss;


            //Console.WriteLine("please inter number of grads");
            //size = int.Parse(Console.ReadLine());

            //int[] grade = new int[size];

            //for (int i = 0; i < grade.Length; i++)
            //{
            //    Console.WriteLine($"please inter {i + 1} grade");
            //    grade[i] = int.Parse(Console.ReadLine());

            //    ss = grade[i] > 50 ? " Success" : " faild";
            //    Console.WriteLine(ss);

            //    sum += grade[i];


            //}

            //avg = sum / size;

            //Console.WriteLine($"the avg is {avg}");
            //Console.WriteLine($"the sum  is {sum}");
            //Console.WriteLine(grade.Max());




            ////   2 - For 1D array , Try Resize and Delete by Shifting
            //int[] arr = new int[3];
            //arr[0] = 0;
            //arr[1] = 20;
            //arr[2] = 30;

            //int[] now = new int[5];


            //for (int i = 0; i < 3; i++)
            //{

            //        arr[i + 1] = arr[i];
            //}

            //Console.WriteLine(arr)


            int[] array = new int[3];
            array[0] = 7;
            array[1] = 55;


            Console.WriteLine(" please enter index of delete ");
            int index2 = int.Parse(Console.ReadLine());
            


            for (int i = index2; i < array.Length - 1; i++) // shifting
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = 0; //خليناها ب صفر  array  اخر قيمه في 

                Console.WriteLine(" deleted succeed");
            
        }



        














    }

       
    
}




