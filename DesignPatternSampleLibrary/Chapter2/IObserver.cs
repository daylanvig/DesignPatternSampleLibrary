namespace DesignPatternSampleLibrary.Chapter2;

/// <summary>
/// The observer is the object who is listening for changes in data
/// </summary>
public interface IObserver
{
    /// <summary>
    /// Method to invoke when the subscriber has changed
    /// </summary>
    /// <remarks>
    /// This argument is intentionally left parameterless to encapsulate the code.
    /// Rather than having the subject send the changed values, the observer itself will maintain a reference to the subject class, and get the values directly from it.
    /// </remarks>
    void Update();
}
