using Pikot.DDD.Essentials;

namespace Pikot.DDD.Ports.CQRS;

/// <summary>
/// Write enabled repository interface for aggregates persisting.
/// </summary>
/// <typeparam name="TAggregate">Aggregate type</typeparam>
/// <typeparam name="TKey">Aggregate unique key type</typeparam>
public abstract class Repository<TAggregate, TKey> 
    where TAggregate : DomainAggregate<TKey>
{
    public abstract Task<TAggregate?> GetAsync(TKey id, CancellationToken cancellationToken);
    public abstract void Add(TAggregate aggregate);
    public abstract Task SaveChangesAsync(CancellationToken cancellationToken);
}

/// <summary>
/// Write enabled repository interface for aggregates persisting, with int32 as the key.
/// </summary>
/// <typeparam name="TAggregate">Aggregate type</typeparam>
public abstract class Repository<TAggregate> : Repository<TAggregate, int>
    where TAggregate : DomainAggregate;