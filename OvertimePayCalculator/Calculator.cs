using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvertimePayCalculator
{
    class Calculator
    {
        public static double Calculate(double hours, double rate)
        {
            double finalPay = 0;

            if (hours > 40)
            {
                double regularPay = hours * rate;
                double overtimePay = (hours - 40.0) * (rate * 0.5);
                finalPay = regularPay + overtimePay;
            }
            else
            {
                finalPay = hours * rate;
            }

            return finalPay;
        }
    }
}
