namespace Pikot.DDD.Essentials;


/// <summary>
/// Generic domain entity
/// </summary>
/// <typeparam name="TKey">Entity unique key, value type required</typeparam>
public abstract class DomainEntity<TKey> where TKey : struct, IEquatable<TKey>
{
    /// <summary>
    /// Helper for some ORMs that need the parameterless constructor
    /// </summary>
    protected DomainEntity() { }

    protected DomainEntity(DateTimeOffset createdAt, DateTimeOffset insertedAt)
    {
        CreatedAt = createdAt;
        InsertedAt = insertedAt;
    }
    
    /// <summary>
    /// Primary unique key of the aggregate entity.
    /// </summary>
    public TKey Id { get; protected set; }
    
    /// <summary>
    /// DateTime with offset when the entity creation was requested.
    /// </summary>
    public required DateTimeOffset CreatedAt { get; init; }
    /// <summary>
    /// DateTime with offset when the entity was persisted.
    /// </summary>
    public required DateTimeOffset InsertedAt { get; init; }
}

/// <summary>
/// Default domain entity with int32 as the key.
/// </summary>
public abstract class DomainEntity : DomainEntity<int>;