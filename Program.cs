namespace console_app;
class Program
{
    static void Main(string[] args)
    {
        double principle_amount = 5000;
        double rate = 0.08;
        int time_years = 2;
        int time_compounded = 4;

        double simple_interest = principle_amount * rate * time_years;
        Console.WriteLine($"Simple Interest on an amount of {principle_amount} for {time_years} years is --- {simple_interest}");

        double total_quarters = time_compounded * time_years;
        double interest_every_quarter = (1 + (rate / time_compounded));
        double powerValue = Math.Pow(interest_every_quarter, total_quarters);

        double amount_after_interest = principle_amount * powerValue;
        amount_after_interest = (Math.Round(amount_after_interest, 2, MidpointRounding.AwayFromZero));
        double total_interest = amount_after_interest - principle_amount;
        Console.WriteLine($"Compound Interest on an amount of {principle_amount} for {time_years} years is --- {total_interest}");

    }
}
