using System;

namespace problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            byte variableType;
            Console.WriteLine("Enter the type of variable (0=integer, 1=double, 2=string):");
            variableType = byte.Parse(Console.ReadLine());
            if (variableType == 0 || variableType == 1 || variableType == 2)
            {
                Console.WriteLine("Enter the value: ");
                switch (variableType)
                {
                    case 0:
                        int intValue;
                        int.TryParse(Console.ReadLine(), out intValue);
                        Console.WriteLine($"Integer value + 1: {++intValue}");
                        break;
                    case 1: 
                        double doubleValue;
                        double.TryParse(Console.ReadLine(), out doubleValue);
                        Console.WriteLine($"Double value + 1: {doubleValue + 1}");
                        break;
                    case 2: 
                        string stringValue = Console.ReadLine();
                        Console.WriteLine($"String value + 1: {stringValue}" + '*');
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error.");
            }
        }
    }
}
