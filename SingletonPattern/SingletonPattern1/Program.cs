using System;

namespace SingletonPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Launch("Windows 7");
            Console.WriteLine(computer.Os.Name);

            computer.Os = Os.GetInstance("Windows 10");
            Console.WriteLine(computer.Os.Name);

            Console.ReadLine();
            
        }
    }
}
