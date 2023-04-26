using System;

namespace lappp_4444
{
    class Student
    {
       public string name;
       public int age;
        string password;
        string username;

        public Student()
        {
            username = name + age;
        }


        public string Name
        {
            set
            {
                if (value.Length > 5)
                {
                    name = value;
                }
            }

            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                if (value > 20)
                {
                    age = value;
                }
            }

            get
            {
                return age;
            }
        }

        public string Adress { get; set; }
        public int Grade { get; set; }

        public string Password
        {

            set
            {
                if (value.ToString().Length > 8)
                {
                    password = value;
                }
            }
            private get
            {
                return password;
            }


        }

        public string Username
        {
            set
            {
                username = name + age;
            }
            get
            {
                string ss = name + age;
                return ss;
            }
        }

        public void forgetpassword(string uname)
        {
            if (username == uname)
            {
                Console.WriteLine("enter your pass agin");
                password = Console.ReadLine();
            }

            else
            {

                throw new Exception("error .. you are not the real user ");
            }
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();

            Console.WriteLine(" please enter your name");
            stu.Name = Console.ReadLine();

            Console.WriteLine(" please enter your age");
            stu.Age = int.Parse(Console.ReadLine());

            Console.WriteLine(" please enter your adress");
            stu.Adress = Console.ReadLine();

            Console.WriteLine(" please enter your grade");
            stu.Grade = int.Parse(Console.ReadLine());

            Console.WriteLine(" please enter your password");
            stu.Password = Console.ReadLine();

            Console.WriteLine("forget password ?  yes or now ");
            string pp = Console.ReadLine();

            stu.Username = stu.Name + stu.Age;
            

            if (pp == "yes")
            {
                Console.WriteLine("plese enter your user name ");
                string uname = Console.ReadLine();




                try
                {
                    stu.forgetpassword(uname);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);


                }

            }
        }
    }
    }      
