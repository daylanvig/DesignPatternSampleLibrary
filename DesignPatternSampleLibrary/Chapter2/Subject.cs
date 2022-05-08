namespace DesignPatternSampleLibrary.Chapter2;

/// <summary>
/// Sample of code for a hypothetical subject
/// </summary>
/// <remarks>
/// 
/// </remarks>
public class Subject : ISubject
{
    private readonly HashSet<IObserver> _observers = new();

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public string GetHypotheticalValue()
    {
        return "This value was observed!";
    }
}
