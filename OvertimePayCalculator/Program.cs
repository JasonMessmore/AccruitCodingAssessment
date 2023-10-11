class Program

{
    public static void Main(string[] args)
    {
        double finalPay = 0.0;
        double hours;
        double rate;

        while (true)
        {
            try
            {
                Console.WriteLine("Hours Worked: ");
                hours = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Rate of Pay: ");
                rate = Convert.ToDouble(Console.ReadLine());

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

                Console.WriteLine("Total Pay: " + finalPay);
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter valid numbers only");
            }
        }
    }
}

class PayCalculator
{

}