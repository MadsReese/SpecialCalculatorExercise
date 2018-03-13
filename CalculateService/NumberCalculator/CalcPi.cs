using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCalculator
{
    class CalcPi
    {
        //Nilakantha series - shamelessly borrowed from http://csharphelper.com/blog/2015/03/approximate-pi-using-several-different-methods-in-c/
        public double CalculatePrime(int num_terms)
        {

            double result = 0;
            double sign = 1;
            for (int i = 0; i < num_terms; i++)
            {
                result += sign / (2 * i + 2) / (2 * i + 3) / (2 * i + 4);
                sign = -sign;
            }
            return 3 + result * 4;
        }
    }   
}