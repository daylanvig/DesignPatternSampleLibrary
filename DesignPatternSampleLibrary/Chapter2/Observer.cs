namespace DesignPatternSampleLibrary.Chapter2;

/// <summary>
/// Sample implementation of a possible observer
/// </summary>
public class Observer : IObserver
{
    /// <summary>
    /// The subject being observed.
    /// </summary>
    /// <remarks>
    /// This is included as a property since it makes it easy to unsubscribe if required.
    /// A real observer may or may not have this.
    /// </remarks>
    private readonly Subject _subject;
    public Observer(Subject subject)
    {
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public void Update()
    {
        // Here we demonstrate that the observer gets whatever data it wants from the subscriber by accessing the subscriber's methods, not via argument params.
        Console.WriteLine($"Observed a change! Message: {_subject.GetHypotheticalValue()}");
    }
}