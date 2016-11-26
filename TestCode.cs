using UtilityMethods;
class TestCode
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Call methods from MathLibrary.DLL:");

        if (args.Length != 2)
        {
            System.Console.WriteLine("Usage: TestCode <num1> <num2>");
            return;
        }

        long num1 = long.Parse(args[0]);
        long num2 = long.Parse(args[1]);

        long sum = AddClass.Add(num1, num2);
        long product = MultiplyClass.Multiply(num1, num2);
        long difference = SubtractionClass.Subtract(num1, num2);
        long final = DivisionClass.Divide(num1, num2);

        System.Console.WriteLine("Addition: {0} + {1} = {2}", num1, num2, sum);

        System.Console.WriteLine("Multiplication: {0} * {1} = {2}", num1, num2, product);

        System.Console.WriteLine("Subtraction: {0} - {1} = {2}", num1, num2, difference);

        System.Console.WriteLine("Division: {0} / {1} = {2}", num1, num2, final);
    }
}