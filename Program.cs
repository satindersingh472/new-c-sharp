namespace console_app;
class Program
{
    static void Main(string[] args)
    {
       int principle_amount = 29000;
       double rate = 6.99;
       int time_years = 5;

    double simple_interest = (principle_amount * rate * time_years)/100;
    Console.WriteLine($"Simple Interest on an amount of {principle_amount} for {time_years} is --- {simple_interest}");
    }
}
