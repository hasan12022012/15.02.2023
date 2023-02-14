using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tek eded daxil edin:");
            string numStrOdd = Console.ReadLine();
            int numOdd = Convert.ToInt32(numStrOdd);

            Console.WriteLine(numOdd.IsOdd());




            Console.WriteLine("Cut eded daxil edin:");
            string numStrEven = Console.ReadLine();
            int numEven = Convert.ToInt32(numStrEven);

            Console.WriteLine(numEven.IsEven());




            Console.WriteLine("Yazi daxil edin:");
            string name = Console.ReadLine();

            Console.WriteLine(name.IsContainsDigit());




            Console.WriteLine("kicik herifle baslayan yazi daxil edin:");
            string str1 = Console.ReadLine();

            Console.WriteLine(str1.ToCapitalize());




        }
    }
}
