namespace _2._5_dars;

public class Car:Vehicle
{
    public void Refuel(int amount)
    {
        Fuel+=amount;
    }
    public void Drive(int distance)
    {
        Console.WriteLine(distance/Speed);
    }

}
