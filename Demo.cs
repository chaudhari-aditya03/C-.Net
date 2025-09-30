using System;
class Demo {
    int a = 50;
   public static void Main(string[] args)
    {
        Demo d1 = new Demo();
        d1.display();
    }
   public void display()
    {
        Console.WriteLine("Value of a is " + a);
    }
    }