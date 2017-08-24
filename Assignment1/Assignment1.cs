using System;

class Assignment1
{
    public static void Ex1()
    {
        for(int i = 100; i <= 202; i += 2)
        {
            Console.WriteLine("" + i);
        }
    }

    public static void Ex2()
    {
        for(int i = 100; i <= 202; i += 2)
        {
            Console.WriteLine("" + i);
        }
    }


    static void Main()
    {
        Assignment1.Ex1();
        Console.ReadKey();
    }
}