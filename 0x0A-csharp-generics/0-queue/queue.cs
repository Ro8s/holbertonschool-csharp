using System;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T">Type of elements inside the queue</typeparam>
class Queue<T>
{
    /// <summary>
    /// Function that returns the type that contains the queue
    /// </summary>
    /// <returns>Type of the element</returns>
	public Type CheckType()
    {
        return typeof(T);
    }
}
