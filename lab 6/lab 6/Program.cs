using System;

namespace lab_6
{

    class shape
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


        public double area()
        {
            return 0;
        }

    }

    class squere : shape
    {

        public double area()
        {
            double res = Math.Pow(dim, 2);
            return res;
        }
    }

    class rectangle : shape
    {
        public double dim2 { get; set; }



        public double area()
        {
            double res = dim * dim2;
            return res;
        }
    }

    class circle : shape
    {

        public double area()
        {
            double res = (22 / 7) * Math.Pow(dim, 2);
            return res;        //باي * نق اس 2
        }
    }





    class Program
     {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.pro_dim = 2;
            Console.WriteLine($"the area of circle is {c.area()}");

            rectangle r = new rectangle();
            r.pro_dim = 2;
            r.dim2 = 3;
            Console.WriteLine($"the area of rectangle is {r.area()}");

            squere s = new squere();
            s.pro_dim = 2;
            Console.WriteLine($"the area of squere is {s.area()}");























        }
    }
}

