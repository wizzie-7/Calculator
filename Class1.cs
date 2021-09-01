using System;

namespace Calcy
{
    public class Addition
    {
        public double Add(double num1, double num2)
        {
            double res = num1 + num2;
            Console.WriteLine("Addition is = " + res);
            return res;
        }
    }
    public class Substraction
    {
        public double subs(double num1, double num2)
        {
            double res = num1 - num2;
            Console.WriteLine("Substraction is = " + res);
            return res;
        }
    }
    public class Multiplication
    {
        public double mult(double num1, double num2)
        {
            double res = num1 * num2;
            Console.WriteLine("Multiplication is = " + res);
            return res;
        }
    }
    public class Division
    {
        public double Divi(double num1, double num2)
        {
            double res = num1 / num2;
            double mod = num1 % num2;
            Console.WriteLine("Quotiont is = " + res);
            Console.WriteLine("Reminder is = " + mod);
            return res;
        }
    }
    public class Qual
    {
        public void eqa(double num1, double num2)
        {
            if (num1 == num2) 
            {
                Console.WriteLine(num1 + " is equal to " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " is not eqaul to " + num2);
            }
        }
    }
    public class Greater
    {
        public void great(double num1, double num2)
        {
            if (num1 > num2) 
            {
                Console.WriteLine(num1 + " is gerater than " + num2);
            }
            else
            {
                Console.WriteLine(num2 + " is greater than " + num1);
            }
        }
    }
}
