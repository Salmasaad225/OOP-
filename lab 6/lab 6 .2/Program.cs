using lab_6_._2;
using System;

 namespace lab_6_._2
{

    public class squere
    {
        public double x { set; get; }

        public squere(squere squere)   // copy constructor
        {
            this.x = squere.x;
        }

        public squere(double _x)    //constructor with pramiters
        {
           x = _x;
        }

        public squere()    //constructor without pramiters
        {
            x = 2;
        }
        public double area()
        {
            double res = Math.Pow(x, 2);
            return res;
        }


    }

    class rectangle
    {
        public double x { get; set; }
        public double y { get; set; }

        public double area()
        {
            double res = x * y;
            return res;
        }

    }

    class circle
    {
        public double c { get; set; }


        public double area()
        {
            double res =(22/7) * Math.Pow(c, 2);
            return res;
        }
    }



    class Picture
    {
        squere s;
        rectangle r;

        public squere pro_s                      // property   composition
        {
            set
            {
                s = new squere(value);
            }
            get
            {
                return new squere(s);
            }
        }


        //public rectangle pro_r { get; set; }     

        public rectangle pro_r      /* property  aggregation*/
        {
            set
            {
                r = value;
            }
            get
            {
                return r;
            }
        }




        public double gettotalarea()
        {
           
            return r.area() + s.area();
        }

        public void circlearea(circle c)
        {
            Console.WriteLine($"the circle area is {c.area()}");

        }
    }




}

class Program
{
    static void Main(string[] args)
    {


        squere ss = new squere(3);
        
        rectangle r = new rectangle();
        r.x = 2;
        r.y = 3;
        


        circle c = new circle();
        c.c = 5;



        Picture p = new Picture();
        p.pro_s = ss;
        p.pro_r = r;
        p.circlearea(c);
        Console.WriteLine($"total area of rectangle and sqare is {p.gettotalarea()}");






    } 
}
