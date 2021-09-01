using System;
using Calcy;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 18;
            double b = 3;
            
            Addition ad = new Addition();
            Substraction sub = new Substraction();
            Multiplication mul = new Multiplication();
            Division div = new Division();
            Qual eq = new Qual();
            Greater gr = new Greater();
            
            ad.Add(a,b);
            sub.subs(a, b);
            mul.mult(a, b);
            div.Divi(a, b);
            eq.eqa(a, b);
            gr.great(a, b);
        }
    }
}
