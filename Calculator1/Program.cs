namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation<int> operation1 = (a, b) => a + b;
            Operation<double> operation2 = (a, b) => a + b;
            Operation<string> operation3 = (a, b) => a + " " + b +".";
            var calculator1 = new Calculator<int>(4,6);
            var calculator2 = new Calculator<double>(3.3, 1.1);
            var calculator3 = new Calculator<string>("I am", "but a humble creature");

            Console.WriteLine(calculator1.PerformOperation(operation1));
            Console.WriteLine(calculator2.PerformOperation(operation2));
            Console.WriteLine(calculator3.PerformOperation(operation3));

        }
    }
}