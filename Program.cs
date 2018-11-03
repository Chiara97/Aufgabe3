using System;

namespace Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welche Zahl soll konvertiert werden?");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Auf welchem System basiert die Zahl?");
            int fromSystem1 = int.Parse(Console.ReadLine());
            Console.WriteLine("In welches System soll die Zahl umgewandelt werden?");
            int toSystem1 = int.Parse(Console.ReadLine());
            
            Program p = new Program ();
            Console.WriteLine("Die Lösung ist:");
            Console.WriteLine(p.ConvertNumberFromSystemToSystem(number1, fromSystem1, toSystem1));
        }

            int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem)
            {
                int result = 0;
                result = OtherToDecimal(number, fromSystem);
                result = DecimalToOther(result, toSystem);
                return result;
                
            }

            int DecimalToOther(int dec, int system)
            {
                int result = 0;
                int factor = 1;
                while (dec != 0)
                {
                    int digit = dec % system;
                    dec /= system;
                    result += factor * digit;
                    factor *= 10;
                }
                return result;
            }

            int OtherToDecimal(int other, int system)
            {
                int result = 0;
                int factor = 1;
                while (other != 0)
                {
                    int digit = other % 10;
                    other /= 10;
                    result += factor * digit;
                    factor *= system;
                }
                return result;
            }
            
        
    }
}
