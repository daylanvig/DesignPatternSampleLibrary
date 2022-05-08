namespace DesignPatternSampleLibrary.Chapter3;

static class SampleSetup
{
    static void RunComponent()
    {
        // In reality, we would use a builder or factory to create a decorated component, rather than relying on this implementation
        // We're using the base type, not the implementation type
        Component component = new ConcreteComponent();
        component = new ConcreteComponentDecoratorA(component);
        component = new ConcreteComponentDecoratorB(component);
        var decoratedValue = component.CalculateValueSpecificToType(); // This is the total value returned from the concrete method + decoratorA + decoratorB
    }
}
