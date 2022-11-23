// Creating a calculator with addition, subtraction, multiplication, division

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine()); // ReadLine reads strings so we need to convert the string to a double
            Console.WriteLine("Enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            // Addition
            Console.WriteLine("Addition result: " + (firstNumber + secondNumber));

            // Subtraction
            Console.WriteLine("Subtraction result: " + (firstNumber - secondNumber));

            // Multiplication
            Console.WriteLine("Multiplication result: " + (firstNumber * secondNumber));

            // Division
            Console.WriteLine("Division result: " + (firstNumber / secondNumber));
        }

    }
}

