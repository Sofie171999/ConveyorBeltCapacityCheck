// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        // Prompt for number of motors
        Console.Write("How many motors are carrying the packages? ");
        int motors = Convert.ToInt32(Console.ReadLine());

        // Prompt for weight of packages
        Console.Write("How many kg of packages do we expect? ");
        double packagesWeight = Convert.ToDouble(Console.ReadLine());

        // Hver motor kan bære 5.6 kg
        double capacityPerMotor = 5.6;

        // Udregn gennemsnitsvægt per motor
        double loadPerMotor = packagesWeight / motors;

        if (loadPerMotor <= capacityPerMotor)
        {
            Console.WriteLine("Yes! The conveyor belt can carry the packages.");
        }
        else
        {
            Console.WriteLine("No. The conveyor belt cannot carry the packages.");
        }
    }
}

