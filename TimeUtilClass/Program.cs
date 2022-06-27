

Console.WriteLine("***** Fun with Static Classes ****** \n");
TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();


static class TimeUtilClass
{
    public static void PrintTime()
        => Console.WriteLine(DateTime.Now.ToShortTimeString());

    public static void PrintDate()
    {
        Console.WriteLine(DateTime.Now.Date);
    }
}