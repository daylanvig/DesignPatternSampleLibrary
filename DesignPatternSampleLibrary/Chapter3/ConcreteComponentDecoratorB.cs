namespace DesignPatternSampleLibrary.Chapter3;

public class ConcreteComponentDecoratorB : ComponentDecorator
{
    private readonly Component _wrappedComponent;
    private readonly object? _newState = null; // Decorators can extend state of the component, if desired

    public ConcreteComponentDecoratorB(Component component)
    {
        _wrappedComponent = component;
    }

    public override double CalculateValueSpecificToType()
    {
        return _wrappedComponent.CalculateValueSpecificToType() + 12;
    }

    public override void MethodA()
    {
        base.MethodA();
        Console.WriteLine("ConcreteDecoratorB MethodA Called!");
    }

    // New methods could be added here
}