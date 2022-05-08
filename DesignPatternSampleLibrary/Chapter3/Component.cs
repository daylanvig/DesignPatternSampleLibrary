namespace DesignPatternSampleLibrary.Chapter3;

/// <summary>
/// The Component is something that can be used on its own, or wrapped with a decorator
/// </summary>
public abstract class Component
{
    public virtual void MethodA()
    {
        Console.WriteLine("MethodA Called!");
    }

    public virtual void MethodB()
    {
        Console.WriteLine("MethodB Called!");
    }

    public abstract double CalculateValueSpecificToType();
}