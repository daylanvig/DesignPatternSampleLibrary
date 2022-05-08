namespace DesignPatternSampleLibrary.Chapter3;

public class ConcreteComponentDecoratorA : ComponentDecorator
{
    private readonly Component _wrappedComponent;

    public ConcreteComponentDecoratorA(Component component)
    {
        _wrappedComponent = component;
    }

    public override double CalculateValueSpecificToType()
    {
        return _wrappedComponent.CalculateValueSpecificToType() + 1.03;
    }

    public override void MethodA()
    {
        base.MethodA();
        Console.WriteLine("ConcreteDecoratorA MethodA Called!");
    }

    // New methods could be added here
}
