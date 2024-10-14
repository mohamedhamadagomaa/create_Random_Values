using System;
using System.Text;

namespace testing
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an options ");
                Console.WriteLine("[1] Generate random number\tGenerate random string");
                var selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                {
                    GenerateNumberRandom();
                }
                else if (selectedOption == "2")
                {
                    GenerateStringRandom();
                }

            }
        }

        //************************************************************************

        static void GenerateNumberRandom()
        {
            var rnd = new Random();
            var value = rnd.Next(1000, 9999);
            Console.WriteLine($"random Number :  {value}");
        }
        private const string Buffer = "ABCDEFGHIJKLMNOPQRCTUVWXYZabcdefghijklmnopqrstuvwxyz12345604656$%%^$&^%**^%&%Z";

        private static void GenerateStringRandom()
        {
            var sb = new StringBuilder();
            var rnd = new Random();
            while (sb.Length < 16)
            {
                var indexRandom = rnd.Next(0, Buffer.Length - 1);
                sb.Append(Buffer[indexRandom]);
            }
            Console.WriteLine($"Random string : {sb}");
        }
    }




}
