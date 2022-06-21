using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Class1 reliance = new Class1("TATA", 100, 200, 400);
            reliance.computeEmpWage();

            Class1 Dmart = new Class1("TATA", 100, 200, 400);
            Dmart.computeEmpWage();



        }

    }
}