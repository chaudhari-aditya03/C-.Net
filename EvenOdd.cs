using System;
 class EvenOdd
{
    public void isEvenOdd()
    {
        Console.WriteLine("Enter a number:");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " is even");
        }
        else
        {
            Console.WriteLine(i + " is odd");
        }
    }
}