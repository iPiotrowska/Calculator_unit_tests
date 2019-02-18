using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Methods
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public string Divide(double a, double b)
        {
            if (b == 0)
            {
                return "Nie można dzielić przez zero";
            }

            return (a / b).ToString();
        }
    }
}
