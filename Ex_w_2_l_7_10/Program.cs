namespace W_2_l_7_10;
using System.Net;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Budujemy trójkąt");

            Console.WriteLine("Podaj pierwszy bok");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugi bok");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzeci bok");
            int c = int.Parse(Console.ReadLine());

            if (a >= b+c || b >= a+c || c >= a+b )
            {
                Console.WriteLine("Z tych boków nie zbudujesz trójkąta");
            }
            else { Console.WriteLine("Można zbudować trójkąt"); };

        }
    }

