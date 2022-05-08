namespace DesignPatternSampleLibrary.Chapter2;

/// <summary>
/// The subject is the object whose data is being watched
/// </summary>
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}