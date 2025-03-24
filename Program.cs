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

//********************** Indexer ****************

//namespace Indexers
//{

//    public class HttpCookie
//    {
//        private Dictionary<string, string> _dictionary = new Dictionary<string, string>;

//        public HttpCookie()
//        {
//            _dictionary = new Dictionary<string, string>();
//        }

//        public string this[string key]
//        {
//            get
//            {
//                return _dictionary[key];
//            }
//            set { _dictionary[key] = value; }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var cookie = new HttpCookie();
//            cookie["name"] = "Akshay";
//            Console.WriteLine(cookie["name"]);

//        }
//    }
//}

//Input: arr[] = [10, 3, 5, 6, 20]
//Output: 1200
//Explanation: Multiplication of 10, 6 and 20
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = new int[] { 10, 3, 5, 6, 20 };
//            int multiplication = 1;
//            //int currentMultiplication = 1;

//            for(int i = 0; i < array.Length; i++)
//            {
//                for(int j = i + 1; j < array.Length; j++)
//                {
//                    for(int k = j + 1; k < array.Length; k++)
//                    {
//                        if ((array[i]* array[j] * array[k]) > multiplication)
//                        {
//                            multiplication = (array[i] * array[j] * array[k]);
//                        }
//                    }
//                }
//            }

//            Console.WriteLine(multiplication);
//        }
//    }
//}


//1 - Write a program and ask the user to enter a number.
//    The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. 
//     Otherwise, display "Invalid". 
//    (This logic is used a lot in applications where values entered into input boxes need to be validated.)
//using System;
//using System.Collections.Specialized;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the valid number between 1 to 10");
//            var n = Convert.ToInt32(Console.ReadLine());
//            if(n >0 && n <= 10)
//            {
//                Console.WriteLine("Valid");
//            }
//            else
//            {
//                Console.WriteLine("Invalid");
//            }
//        }
//    }
//}

//2- Write a program which takes two numbers from the console and displays the maximum of the two.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int x, y;
//            Console.WriteLine("Enter the 1st Number : ");
//            x = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the 2nd Number : ");
//            y = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine(Math.Max(x, y));
//        }
//    }
//}

//4 - Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, 
//    sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
//    nce set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
//    program should display Ok on the console. If the value is above the speed limit,
//    the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 
//    1 demerit points should be incurred and displayed on the console.
//    If the number of demerit points is above 12, the program should display License Suspended.


//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the speed limit : ");
//            var speedLimit = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the current speed : ");
//            var currentSpeed = Convert.ToInt32(Console.ReadLine());


//            if(currentSpeed <= speedLimit)
//            {
//                Console.WriteLine("OK");
//            }
//            else
//            {
//                int demirits = currentSpeed - speedLimit;
//                if(demirits > 12)
//                {
//                    Console.WriteLine("Licence Canceled.");
//                }
//                else
//                {
//                    Console.WriteLine(demirits / 5);
//                }
//            }
//        }
//    }
//}

//1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
//    Display the count on the console.

//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int count = 0;
//            for(int i = 0; i <= 100; i++)
//            {
//                if (i % 3 == 0)
//                {
//                    count++;
//                }

//            }

//            Console.WriteLine(count);
//        }
//    }
//}

//2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
//    Calculate the sum of all the previously entered numbers and display it on the console.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            var list = new List<int>();
//            while (true)
//            {
//                Console.WriteLine("Enter a number or ok to exit");
//                var input = Console.ReadLine();
//                input = input.ToLower();

//                int n = 0;
//                if (input == "ok")
//                {

//                    foreach(var i in list)
//                    {
//                        n += i;
//                    }
//                    Console.WriteLine($"Sum : {n}");
//                    break;
//                }
//                else
//                {
//                    list.Add(Convert.ToInt32(input));
//                }

//            }
//        }
//    }
//}



//3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
//    For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the Factorial");
//            int n = Convert.ToInt32(Console.ReadLine());
//            int fact = 1;
//            for(int i = n; i > 0; i--)
//            {
//                fact *= i;
//            }
//            Console.WriteLine(fact);
//        }
//    }
//}