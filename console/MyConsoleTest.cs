using System;
namespace MyConsole {
    class MyConsoleTest {
        static void Main(string[] args) {
            Console.WriteLine(MyConsole.ReadLine<int>("enter an integer"));
            Console.WriteLine(MyConsole.ReadLine<int>("do not enter an integer"));
            Console.WriteLine(MyConsole.ReadLine<bool>("enter a boolean"));
            Console.WriteLine(MyConsole.ReadLine<bool>("do not enter a boolean"));
        }
    }
}