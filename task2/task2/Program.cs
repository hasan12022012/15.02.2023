using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            while(true)
            {
                Console.WriteLine("Fullname:");
                string fullname=Console.ReadLine();
                if (Student.CheckFullName(fullname))
                {
                    std.Fullname = fullname;
                    break;
                }
                Console.WriteLine("Yeniden daxil edin");
            }

            while (true)
            {
                Console.WriteLine("GroupNo;");
                string groupNo=Console.ReadLine();
                if (Student.CheckGroupNo(groupNo))
                {
                    std.GroupNo=groupNo;
                    break;
                }
                Console.WriteLine("Yeniden daxil edin")
            }

            while (true)
            {
                Console.WriteLine("Age:");
                int age;
                if(int.TryParse(Console.ReadLine(), out age))
                {
                    std.Age = age;
                    break;
                }
                Console.WriteLine("Yeniden daxil edin");
            }
            Console.WriteLine($"Student: {std.Fullname}, GroupNo:{std.GroupNo}, Age:{std.Age}");
        }
    }
}
