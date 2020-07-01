using System;

namespace TestNumber
{
    class Program
    {
        public static void Main()
        {

            Number number1 = new Number();
            Number number2 = new Number();
            Number number3 = new Number();

        }
    }

    public class Number
    {

        int count = 0;	// available to both method1 and method2 

        public void method1()
        {
            count = 1;
        }

        public void method2()
        {
            count = 2;
        }

    }
}
