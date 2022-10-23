abstract class Vehicle
{
    protected int maxSpeed;
    protected static int numberOfVehicles = 0;
    public void Go()
    {
        System.Console.WriteLine("This vehicle is moving");
    }

    public int MaxSpeed
    {
        get { return this.maxSpeed; }
        set
        {
            this.maxSpeed = value > 500 ? 500 : value;
        }
    }

    // abstract method
    public abstract void Drive();

    public static int GetNumberOfVehicles()
    {
        return numberOfVehicles;
    }
}

class Car : Vehicle
{
    private String make;
    private String model;
    private int year;
    public Car(String make, String model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.maxSpeed = 300;
        numberOfVehicles++;
    }

    public override void Drive()
    {
        System.Console.WriteLine($"You r driving a {make} {model} car");
    }
}

class Bicycle : Vehicle
{
    public Bicycle()
    {
        this.maxSpeed = 60;
        numberOfVehicles++;
    }

    public override void Drive()
    {
        System.Console.WriteLine("You are driving a bike");
    }
}

