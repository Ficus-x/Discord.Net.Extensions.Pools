using System.Collections.Concurrent;

namespace Discord.Net.Extensions.Pools.Features;

/// <summary>
/// Exposes how a pool has to be made.
/// </summary>
public abstract class Pool<T> where T : class, new()
{
    private readonly ConcurrentQueue<T> _objects = new ConcurrentQueue<T>();

    /// <summary>
    /// Gets an object.
    /// </summary>
    /// <returns>Returns an object of provided type.</returns>
    public virtual T Get() => _objects.TryDequeue(out var result) ? result : new T();

    /// <summary>
    /// Returns an object.
    /// </summary>
    public virtual void Return(T obj)
    {
        _objects.Enqueue(obj);
    }
}