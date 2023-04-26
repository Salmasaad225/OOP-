using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////   2 - For 1D array , Try Resize and Delete by Shifting
            int[] arr = new int[3];
            arr[0] = 0;
            arr[1] = 20;
            arr[2] = 30;

            int[] neew = new int[5];

            //for (int i = 0; i < 3; i++)
            //{
            //    if (arr[i] != 0)
            //    {
            //        neew[i] = arr[i];
            //    }
            //}



            for (int i = 0; i < 5; i++)
            {
                if (arr[i] == 0)
                {

                    arr[i + 1] = arr[i];
                    arr[i + 2] = arr[i + 1];

                }
                Console.WriteLine(arr[i]);
            } 







            //for (int i = 0; i < 3; i++)
            //{
            //    if (arr[i] != 0)
            //    {
            //        neew[i] = arr[i];
            //    }
            //}
            ////now = arr;

        }
    }
}
