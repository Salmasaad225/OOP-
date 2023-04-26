using System;

namespace lab_3
{
    class Program


    {
        static int[,] filldata()           /*-----------------111111111------------------*/
        {
            int[,] twodim = new int[3, 4];

            for (int c = 0; c < twodim.GetLength(1); c++)
            {
                for (int r = 0; r < twodim.GetLength(0); r++)
                {
                    Console.WriteLine($"please enter student {c + 1} of grade {r + 1}");
                    twodim[r, c] = int.Parse(Console.ReadLine());
                }
            }


            return twodim;


        }
        static void printdata(int[,]arr)      /* --------------------111111111111111111---------------*/
        {
            

            for (int c = 0; c <arr.GetLength(1); c++)
            {
                for (int r = 0; r < arr.GetLength(0); r++)
                {
                    Console.WriteLine(arr[r,c]);
                   
                }
            }



        }

        static void printsum()           /*-----------------2222222222222------------------*/
        {
            int[,] twodim = new int[3, 4];
            int[] sum = new int[4];

            for (int c = 0; c < twodim.GetLength(1); c++)
            {


                for (int r = 0; r < twodim.GetLength(0); r++)
                {
                    Console.WriteLine($"please enter student {c + 1} of grade {r + 1}");
                    twodim[r, c] = int.Parse(Console.ReadLine());


                }

                int ss = 0;
                for (int r = 0; r < twodim.GetLength(0); r++)
                {

                    sum[c] = twodim[r, c];
                    ss += sum[c];



                }
                Console.WriteLine(ss);
            }








        }






        static void Main(string[] args)
        {
            ////1.Fill and Print a 2D Array(Using Functions)



            int[,] arr = new int[3, 4];

            arr = filldata();

            printdata(arr);





            //2.Sum of every 'Column' in 2D Array(Using Functions)



            //printsum();



            //3.Simple Menu on Array(Refer to Problem 6 in Lab 2)(2D Array Bonus)(Using Functions)

            int[] array = new int[5];

            Console.WriteLine("please enter one of the words add , edit , delete , desplay or exite");
            string word = Console.WriteLine();


            if(word=="exite")
            {
                break;
            }



            while (word != "exite")
            {
                switch (word)
                {
                    case "add":
                        Console.WriteLine("please enter the value");
                        int Value = int.Parse(Console.ReadLine());
                        add();
                        break;
                    case "edit":
                       edit();
                        break;
                    case "delete":
                        delete();
                        break;
                    case "display":
                        display();
                        break;
                    default:
                        Console.WriteLine(" try again");
                        break;

                }  

            }


            static void add(int[] array, int value)
            {
                int c = 0;

                try
                {
                    array[c + 1] = value;
                    c++;
                    Console.WriteLine("succeed");
                }

                catch
                {
                    Console.WriteLine("the array falled try agin !!!");
                }
                
                
            }











            }


    }
}

