using System;

namespace labb_55
{
    class operation
    {
        public int Num { get; set; }
        public int Dem { get; set; }

        public operation()
        {
            Num = 1;
            Dem = 2;
        }


        public operation(int N1, int N2)
        {
            Num = N1;
            Dem = N2;
        }

        public void print()
        {
            Console.WriteLine($"{Num} / {Dem}");
        }

        public static operation operator +(operation o1, operation o2)
        {
            operation res = new operation();

            if (o1.Dem == o2.Dem)
            {
                res.Num = o1.Num + o2.Num;
                res.Dem = o1.Dem;
                return res;
            }
            else
            {
                res.Num = o1.Num * o2.Dem + o2.Num * o1.Dem;
                res.Dem = o1.Dem * o2.Dem;
                return res;
            }

        }

        public static operation operator ++(operation o)
        {
            operation res = new operation();
            res.Num = o.Num * 1 + o.Dem * 1;
            res.Dem = o.Dem * 1;

            return res;

        }


        public static bool operator ==(operation o1, operation o2)
        {
            if (o1.Num == o2.Num && o1.Dem == o2.Dem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(operation o1, operation o2)
        {
            if (o1.Num == o2.Num && o1.Dem == o2.Dem)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public operation(operation o)  /*copy constructor*/
        {
            this.Num = o.Num;
            this.Dem = o.Dem;

        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            operation o1 = new operation(1, 3);
            operation o2 = new operation(1, 2);

            o1.print();
            o2.print();

            operation o3 = new operation();
            o3 = o1 + o2;
            o3.print();

            operation o4 = new operation();
            o4++;
            o4.print();

            bool result = o1 == o2;
            Console.WriteLine(result);

            operation copy = new operation(o1);
            copy.print();

        }
    }
}
