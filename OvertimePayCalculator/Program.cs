using OvertimePayCalculator;
class Program
{
    private static double hours;
    private static double rate;

    static void Main(string[] args)
    {
        Console.WriteLine("Hours Worked: ");
        hours = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Rate of Pay: ");
        rate = Convert.ToDouble(Console.ReadLine());

        var calculator1 = new Calculator(hours, rate);
        var calculator2 = new Calculator(hours * 2, rate * 2);

        Console.WriteLine("Total Pay: " + calculator1.Calculate());
        Console.WriteLine("Total Pay with rate doubled and hours doubled: " + calculator2.Calculate());
    }
}