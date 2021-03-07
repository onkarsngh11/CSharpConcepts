using System;

namespace Delegates
{
    public delegate int calculate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Calculator calculator = new Calculator();
            var calc = new calculate(calculator.add);
            a = calc.Invoke(a,b); //3
            calc += calculator.subtract;  //3-2
            Console.WriteLine(calc.Invoke(a,b)); //1
        }
    }
    class Calculator
    {
        public int add(int a, int b) => a + b;
        public int subtract(int a, int b) => a - b;
    }
}
