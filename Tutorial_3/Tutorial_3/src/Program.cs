using System;

class ContainerApp
{
    public static void Main(String[] args)
    {
        Tut3.LiquidContainer myContainer = new Tut3.LiquidContainer(500, 400, 200, 800, 1000);

        Console.WriteLine("My Container: " + myContainer);
        
    }
}