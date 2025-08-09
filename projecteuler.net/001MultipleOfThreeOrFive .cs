internal class _001MultipleOfThreeOrFive
{
    static void Main(string[] args)
    {
        var count = 0;
        for (int i = 1; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                count = count + i;
            }
        }
        Console.WriteLine(count);
    }
    
}

