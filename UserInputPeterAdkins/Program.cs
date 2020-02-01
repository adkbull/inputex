using System;

namespace UserInputPeterAdkins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi this is Peter Adkins");
            Console.WriteLine("type whatever you like then press enter");
            string rmessage = Console.ReadLine();
            Console.WriteLine("message" + " " + rmessage + " " + "received!");

        }
    }
}
