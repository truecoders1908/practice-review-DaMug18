using System;

namespace Practice_Review
{
    class Program
    {
        private const string V = "35";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Ryan Smith");

            int total;

            int a = 23;
            int b = 53;

            total = a + b;

            Console.WriteLine("The sum of integer a and integer b is " + total + ".");

            int answer;

            int c = 1000;
            int d = 842;

            answer = c - d;

            Console.WriteLine("The difference is " + answer + ".");

            int myInt = 8;
            myInt++;

            Console.WriteLine("1 more than 8 is " + myInt + ".");

            int myNum = 10;
            myNum--;

            Console.WriteLine("1 less than 10 is " + myNum + ".");

            string myName = "Ryan";

            int myValue = 19;

            char myCar = 'm';

            bool isTrue = true;

            double myDouble = 24.24;

            if (myValue > myDouble)
            {
                Console.WriteLine("Greater than.");

            }
            else if (myValue < myDouble)
            {
                Console.WriteLine("Less than.");

            }
            else
            {
                Console.WriteLine("Equal to.");
            }
            int count = 0;
            do
            {
                Console.WriteLine("I'm thirsty");
                count++;
            }
            while (count < 3);

            count = 1;
            while (count <= 10)
            {
                Console.Write(count + " ");
                count++;
            }
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n\t\tBoo");
            }

            int[] arr = new int[3];
            arr[0] = 10;
            arr[1] = 11;
            arr[2] = 12;
            foreach (int i in arr)
            {
                Console.Write("\n" + i);
            }
         

            

            
        }



            
         

        }
    }

