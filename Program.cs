
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Creating a calculator with addition, subtraction, multiplication, division

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

            // Task 2: Using the bool data type with If statement and make a check with isTrue parameter.

            bool isTrue = true;

            if (!isTrue) // == is a logical opeation, = is the maths equal operation
            {
                Console.WriteLine("This is true!");
            }
            else 
            {
                Console.WriteLine("This is false!");
            }

            isTrue = false;

            if (!isTrue)
            {
                Console.WriteLine("This is true!");
            }
            else
            {
                Console.WriteLine("This is false!");
            }
        }

    }
}

