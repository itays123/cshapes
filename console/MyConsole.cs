using System;

namespace ConsoleUtils {
    static class MyConsole {

        public static T ReadLine<T>(string label, T defaultValue) where T : struct, Enum {

                Console.Write(label + ": ");
                string input = Console.ReadLine(); 
                T output;
                return Enum.TryParse<T>(input, true, out output) ? output : defaultValue;
           
        }

        public static T ReadLine<T>(string label) where T : IConvertible {
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