using prototype_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.Engine = "V4 1.0L";
        car.Make = "Dacia";
        car.Model = "Logan";
        car.Year = 2016;

        Console.WriteLine(car);

        Car dacia = car.Clone();

        Console.WriteLine(dacia);
    }
}