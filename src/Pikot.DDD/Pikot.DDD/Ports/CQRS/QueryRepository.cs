using Pikot.DDD.Essentials;

namespace Pikot.DDD.Ports.CQRS;

/// <summary>
/// Read-only repository interface for aggregates.
/// </summary>
/// <typeparam name="TAggregate">Aggregate type</typeparam>
/// <typeparam name="TKey">Aggregate unique key type</typeparam>
public abstract class QueryRepository<TAggregate, TKey> 
    where TAggregate : DomainAggregate<TKey>
{
    public abstract Task<TAggregate?> GetAsync(TKey id, CancellationToken cancellationToken);
}

/// <summary>
/// Read-only repository interface for aggregates, with int32 as the key.
/// </summary>
/// <typeparam name="TAggregate">Aggregate type</typeparam>
public abstract class QueryRepository<TAggregate> : QueryRepository<TAggregate, int>
    where TAggregate : DomainAggregate;