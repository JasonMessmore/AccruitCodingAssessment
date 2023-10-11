namespace OvertimePayCalculator
{
    class Program

    {
        public static void Main(string[] args)
        {
            double hours;
            double rate;

            if (args.Length == 2)
            {
                hours = Convert.ToDouble(args[0]);
                rate = Convert.ToDouble(args[1]);
            }
            else
            {
                try
                {
                    Console.WriteLine("Hours Worked: ");
                    hours = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Rate of Pay: ");
                    rate = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter valid numbers only");
                }
            }

            var calculator = new Calculator();


            Console.WriteLine("Total Pay: " + calculator);

                }
            }
        }