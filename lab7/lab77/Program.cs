using System;

namespace lab77
{
   abstract class shape
    {
        protected double dim;        //public with child    private with main

        public double pro_dim
        {
            set
            {
                dim = value;
            }

            get
            {
                return dim;
            }
        }


        abstract public double area();
        

    }

    class squere : shape
    {

       override public double area()
        {
            double res = Math.Pow(dim, 2);
            return res;
        }
    }

    class rectangle : shape
    {
        public double dim2 { get; set; }



       override public double area()
        {
            double res = dim * dim2;
            return res;
        }
    }

    class circle : shape
    {

       override public double area()
        {
            double res = (22 / 7) * Math.Pow(dim, 2);
            return res;        //باي * نق اس 2
        }
    }



     class Picture
    {
        public shape[] sh { get; set; }

        public double Calcarea()
        {
            double sum = 0;

            for (int i = 0; i <sh.Length; i++)
            {
                sum += sh[i].area();
            }
            return sum;

        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {

            circle c = new circle();
            c.pro_dim = 2;
            

            rectangle r = new rectangle();
            r.pro_dim = 2;
            r.dim2 = 3;
            

            squere s = new squere();
            s.pro_dim = 2;

            Picture p = new Picture();

            shape[] sh = new shape[3];
            sh[0] = c;
            sh[1] = r;
            sh[2] = s;

            p.sh = sh;
            Console.WriteLine($"total area is {p.Calcarea()}");
        }
    }
}
