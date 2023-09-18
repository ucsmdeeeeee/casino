public class smaller : Exception
{
    public smaller() { }
    public smaller(string message) : base(message) { }
}

public class bigger : Exception
{
    public bigger() { }
    public bigger(string message) : base(message) { }
}

public class noDiap : Exception
{
    public noDiap() { }
    public noDiap(string message) : base(message) { }
}

public class Casino
{
    public static int b;
    public static bool CasinoPlay(int a)
    {

        Random compChis = new Random();
        b = compChis.Next(-50, 50);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(value: $"комп загадал число({Casino.b})");

        try
        {
            if (a < b)
            {
                throw new smaller("число загаданное компом больше");
            }

            if (a > b)
            {
                throw new bigger("число загаданное компом меньше");
            }

            if (a > 50 || a < -50)
            {
                throw new noDiap("число вне диапазона -50:50");
            }

            return true;
        }
        catch (smaller ex)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"неверное число: {ex.Message}");
            return false;
        }
        catch (bigger ex)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"неверное число: {ex.Message}");
            return false;
        }
        catch (noDiap ex)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"ошибка: {ex.Message}");
            return false;
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите свое число");
        int a = Convert.ToInt32(Console.ReadLine());

        if (Casino.CasinoPlay(a))
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("вы угадали");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("вы не угадали");
        }
    }
}