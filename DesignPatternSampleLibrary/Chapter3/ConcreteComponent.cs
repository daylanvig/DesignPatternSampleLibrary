namespace DesignPatternSampleLibrary.Chapter3;

/// <summary>
/// The ConcreteComponent is the object we're going to dynamically add behaviour to
/// </summary>
public class ConcreteComponent : Component
{
    public override double CalculateValueSpecificToType()
    {
        return 3;
    }

    public override void MethodA()
    {
        Console.WriteLine("Concrete MethodA Called!");
    }
}