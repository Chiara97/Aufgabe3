using System;

namespace Aufgabe3c
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
                
                Program p = new Program();
                Console.WriteLine("Die Lösung ist:");
                Console.WriteLine(p.ConvertNumberFromSystemToSystem(number1, fromSystem1, toSystem1));
        }

            int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem)
            {
                int result = 0;
                int factor = 1;
                
                //int OtherToDecimal(number wird other, fromSystem wird system)
                while (number != 0)
                {
                    int digit = number % 10;
                    number /= 10;
                    result += factor * digit;
                    factor *= fromSystem;
                }
                
                int temp = 0;
                int temp1 = 1;
                //int DecimalToOther(result wird dec, toSystem wird system)
                while (result != 0)
                {
                    int digit = result % toSystem;
                    result /= toSystem;
                    temp += temp1 * digit;
                    temp1 *= 10;
                }
                
                return temp;                               
            }
        
    }
}
           