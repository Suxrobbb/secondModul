namespace _2._5_dars;

public class Vehicle
{

    protected int Speed {  get; set; }

    protected double _fuel;
    protected double Fuel
    {
        get { return _fuel; }
        set
        {
            if (50>=_fuel+value)
            {
                _fuel += value;
            }
        }
    }

}
