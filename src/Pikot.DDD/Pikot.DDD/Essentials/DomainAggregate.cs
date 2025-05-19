namespace Pikot.DDD.Essentials;


/// <summary>
/// Generic domain aggregate
/// </summary>
/// <typeparam name="TKey">Aggregate unique key</typeparam>
public abstract class DomainAggregate<TKey>
{
    /// <summary>
    /// Helper for some ORMs that need the parameterless constructor.
    /// </summary>
    protected DomainAggregate() {}
    
    protected DomainAggregate(DateTimeOffset createdAt, DateTimeOffset insertedAt)
    {
        CreatedAt = createdAt;
        InsertedAt = insertedAt;
    }


    /// <summary>
    /// Primary unique key of the aggregate.
    /// </summary>
    public TKey Id { get; protected set; }
    
    /// <summary>
    /// DateTime with offset when the aggregate creation was requested.
    /// </summary>
    public required DateTimeOffset CreatedAt { get; init; }
    /// <summary>
    /// DateTime with offset when the aggregate was persisted.
    /// </summary>
    public required DateTimeOffset InsertedAt { get; init; }
}



/// <summary>
/// Default domain aggregate with int32 as the key.
/// </summary>
public abstract class DomainAggregate : DomainAggregate<int>;


/// <summary>
/// Generic domain aggregate with version specification.
/// </summary>
/// <typeparam name="TKey">Aggregate unique key, value type required</typeparam>
public abstract class DomainAggregateVersioned<TKey> : DomainAggregate<TKey>
{
    /// <summary>
    /// Current aggregate version
    /// </summary>
    public int Version { get; protected set; } = 1;
}


/// <summary>
/// Default domain aggregate with version specification, int32 as the key.
/// </summary>
public abstract class DomainAggregateVersioned : DomainAggregateVersioned<int>;