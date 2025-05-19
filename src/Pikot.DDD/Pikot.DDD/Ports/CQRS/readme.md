# Pikot.DDD.Ports.CQRS

The `Ports.CQRS` namespace provides abstractions for implementing the Command Query Responsibility Segregation (CQRS) pattern in a Domain-Driven Design (DDD) context. It defines base classes for read and write repositories, enabling a clear separation of concerns between querying and persisting domain aggregates.

By leveraging these abstractions, developers can implement scalable and maintainable solutions that adhere to clean architecture principles.

## Components

### QueryRepository
The `QueryRepository` class is an abstract base class for read-only repositories. It provides methods to retrieve domain aggregates without modifying them.

#### Key Features:
- **Generic Support**: Supports aggregates with customizable key types.
- **Async Retrieval**: Provides an asynchronous method to fetch aggregates by their unique key.

#### Classes:
- `QueryRepository<TAggregate, TKey>`: Generic repository for aggregates with a specified key type.
- `QueryRepository<TAggregate>`: Default implementation for aggregates with `int` as the key type.

#### Example Usage:
```csharp
public class ProductQueryRepository : QueryRepository<ProductAggregate>
{
    public override Task<ProductAggregate?> GetAsync(int id, CancellationToken cancellationToken)
    {
        // Implementation for fetching a product by ID
    }
}
```

### Repository
The `Repository` class is an abstract base class for write-enabled repositories. It provides methods to add and persist domain aggregates.

#### Key Features:
- **Generic Support**: Supports aggregates with customizable key types.
- **Add and Save**: Includes methods to add aggregates and save changes asynchronously.

#### Classes:
- `Repository<TAggregate, TKey>`: Generic repository for aggregates with a specified key type.
- `Repository<TAggregate>`: Default implementation for aggregates with `int` as the key type.

#### Example Usage:
```csharp
public class ProductRepository : Repository<ProductAggregate>
{
    public override Task<ProductAggregate?> GetAsync(int id, CancellationToken cancellationToken)
    {
        // Implementation for fetching a product by ID
    }

    public override void Add(ProductAggregate aggregate)
    {
        // Implementation for adding a product
    }

    public override Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        // Implementation for saving changes
    }
}
```
