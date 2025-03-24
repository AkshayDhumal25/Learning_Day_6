//2.WAP for getting a square root of a given number.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the SquareRoot : ");
//            var n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"SquareRoot of {n} is " + Math.Sqrt(n));
//        }
//    }
//}

//13.WAP with 2 different logic, to find all duplicate numbers in an array.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the size of array : ");
//            var n = Convert.ToInt32(Console.ReadLine());
//            int[] array = new int[n];
//            Console.WriteLine("Enter the elements of array : ");
//            for (var i = 0; i < n; i++)
//            {
//                var temp = Convert.ToInt32(Console.ReadLine());
//                array[i] = temp;
//            }
//            var list = new List<int>();
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = i + 1; j < n; j++)
//                {
//                    if (array[i] == array[j] && !list.Contains(array[i]))
//                    {
//                        list.Add(array[i]);
//                    }
//                }
//            }
//            foreach (var i in list)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the size of array : ");
//            var n = Convert.ToInt32(Console.ReadLine());
//            int[] array = new int[n];
//            Console.WriteLine("Enter the elements of array : ");
//            for (var i = 0; i < n; i++)
//            {
//                var temp = Convert.ToInt32(Console.ReadLine());
//                array[i] = temp;
//            }
//            HashSet<int> duplicates = new HashSet<int>();
//            HashSet<int> seenNumbers = new HashSet<int>();

//            foreach(int i in array)
//            {
//                if (seenNumbers.Contains(i))
//                {
//                    duplicates.Add(i);
//                }
//                else
//                {
//                    seenNumbers.Add(i);
//                }
//            }

//            foreach(int i in duplicates)
//            {
//                Console.Write(i + " ");
//            }
//        }
//    }
//}



//14. [80, 60, 10, 50, 30, 100, 0, 50]
//Find pairs whose sum = 100;

//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = new int[] {80, 60, 10, 50, 30, 100, 0, 50 };
//            var list = new List<int>();
//            for(int i = 0; i < array.Length; i++)
//            {
//                for(int j=i+1;j<array.Length; j++)
//                {
//                    if (array[i] + array[j] == 100)
//                    {
//                        Console.WriteLine(array[i] + ", " + array[j]);
//                    }
//                }
//            }
//        }
//    }
//}


//19.count lowercase and uppercase
//input = &quot; Hello world!&quot;
//output = uppercase = 1, lowercase = 9

//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            var input = "Hello World";
//            var countUpperCase = 0;
//            var countLowerCase = 0;
//            foreach(char c in input)
//            {
//                if (char.IsUpper(c))
//                {
//                    countUpperCase++;
//                }else if (char.IsLower(c))
//                {
//                    countLowerCase++;
//                }
//            }

//            Console.WriteLine($"Upper Case Count = {countUpperCase} and Lower Case Count = {countLowerCase}.");
//        }
//    }
//}


// Classes and Objects
//using System;
//namespace oops
//{
//    public class Person
//    {
//        public string Name;
//        public int Age;

//        public void Introduction()
//        {
//            Console.WriteLine($"Name : {Name}, Age : {Age}");
//        }
//    }
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Person person = new Person();
//            person.Name = "Akshay";
//            person.Age = 20;

//            person.Introduction();
//        }
//    }

//}


//********** Constructors
//using System;
//namespace CSharpIntermediate
//{
//    public class Customer
//    {
//        public int Id;
//        public string Name;

//        public Customer()
//        {

//        }
//        public Customer(int id)
//        {
//            this.Id = id;
//        }

//        public Customer(int id, string name)
//        {
//            this.Id = id;
//            this.Name = name;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Customer customer = new Customer(1, "John");
//            Console.WriteLine(customer.Id);
//            Console.WriteLine(customer.Name);

//        }
//    }
//}
//

//************** Methods ******************
//using System;
//namespace Methods
//{
//    public class Point
//    {
//        public int X;
//        public int Y;

//        public Point(int x, int y)
//        {
//            this.X = x;
//            this.Y = y;
//        }

//        public void Move(int x, int y)
//        {
//            this.X = x;
//            this.Y = y;
//        }

//        public void Move(Point newLocation)
//        {
//            this.X = newLocation.X;
//            this.Y = newLocation.Y;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var point = new Point(10, 20);
//            point.Move(new Point(40, 60));
//            Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);

//            point.Move(100, 200);
//            Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
//        }
//    }
//}


//using System;
//using Learning_Day_6;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Calculator calculator = new Calculator();
//            calculator.Addnumbers(1, 2);
//            calculator.Addnumbers(1, 2, 3);

//        }
//    }
//}


//************************ Fields ************************
//using System;
//namespace Fields
//{
//    public class Customer
//    {
//        public int Id;
//        public string Name;
//        public readonly List<Order> Orders = new List<Order>();


//        //public Customer()
//        //{
//        //    Orders = new List<Order>();
//        //}
//        public Customer(int id)
//        {
//            this.Id   = id;
//        }

//        public Customer(int id, string name)
//            : this(id)
//        {
//            this.Name = name;

//        }

//        public void Promote()
//        {
//            Orders = new List<Order>();
//        }

//    }

//    public class Order
//    {

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var customer = new Customer(1);
//            customer.Orders.Add(new Order());
//            customer.Orders.Add(new Order());




//            Console.WriteLine(customer.Orders.Count);

//        }
//    }
//}


//**************************** Access Modifiers (Private) ***********
//using System;
//namespace AccessModifiers
//{
//    public class Person
//    {
//        private DateTime _birthday;

//        public void SetBirthdate(DateTime birthday)
//        {
//            _birthday = birthday;
//        }
//        public DateTime GetBirthDay()
//        {
//            return _birthday;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person = new Person();
//            person.SetBirthdate(new DateTime(1982, 1, 1));
//            Console.WriteLine(person.GetBirthDay());
//        }
//    }
//}


//********************** Properties ***************
//namespace Properties
//{
//    public class Person
//    {
//        public Person(DateTime birthdate)
//        {
//            Birthdate = birthdate;
//        }
//        public DateTime Birthdate { get; private set; }

//        public int Age
//        {
//            get 
//            { 
//                var timespan = DateTime.Today - Birthdate;
//                var years = timespan.Days/365;

//                return years;

//            }
//        }
//    }
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            var person = new Person(new DateTime(1982, 1, 1));
//            Console.WriteLine(person.Age);
//        }
//    }
//}


