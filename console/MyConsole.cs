using System;

namespace MyConsole {
    static class MyConsole {
        public static T ReadLine<T>(string label) where T : struct {
            try
            {
                Console.Write(label + ": ");
                string input = Console.ReadLine();
                T output = (T) Convert.ChangeType(input, typeof(T));
                return output;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid value.");
                return ReadLine<T>(label);
            }
        }
    }
}