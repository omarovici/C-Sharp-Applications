namespace Assignment_03_EF_Core;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
}
public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Model)}: {Model}, {nameof(NumberOfDoors)}: {NumberOfDoors}";
    }
}
public class Truck : Vehicle
{
    public int LoadCapacity { get; set; }
}