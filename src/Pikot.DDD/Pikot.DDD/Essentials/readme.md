# Pikot.DDD.Essentials

The `Pikot.DDD.Essentials` namespace provides foundational abstractions for implementing Domain-Driven Design (DDD) principles. It includes base classes for defining domain aggregates and entities, ensuring consistency and scalability in DDD-based applications.

## Components

### DomainAggregate
The `DomainAggregate` class represents the root of an aggregate in DDD. It ensures that all changes to the aggregate are controlled through the root.

#### Key Features:
- **Generic Support**: Supports aggregates with customizable key types.
- **Timestamps**: Tracks creation and persistence timestamps.

#### Classes:
- `DomainAggregate<TKey>`: Generic aggregate with a specified key type.
- `DomainAggregate`: Default implementation with `int` as the key type.
- `DomainAggregateVersioned<TKey>`: Generic aggregate with versioning support.
- `DomainAggregateVersioned`: Default implementation with versioning and `int` as the key type.

#### Example Usage:
```csharp
public class ProductAggregate : DomainAggregate
{
    public ProductAggregate(DateTimeOffset createdAt, DateTimeOffset insertedAt)
        : base(createdAt, insertedAt)
    {
    }

    public string Name { get; set; }
}
```

### DomainEntity
The `DomainEntity` class represents an entity within an aggregate in Domain-Driven Design (DDD). It is used to model components of an aggregate that have their own identity.

#### Key Features:
- **Generic Support**: Supports entities with customizable key types.
- **Timestamps**: Tracks creation and persistence timestamps.

#### Classes:
- `DomainEntity<TKey>`: Generic entity with a specified key type.
- `DomainEntity`: Default implementation with `int` as the key type.

#### Example Usage:
```csharp
public class ProductEntity : DomainEntity
{
    public ProductEntity(DateTimeOffset createdAt, DateTimeOffset insertedAt)
        : base(createdAt, insertedAt)
    {
    }

    public string Description { get; set; }
}
```