# Pikot.DDD.Ports

The `Pikot.DDD.Ports` namespace provides essential abstractions and utilities for implementing Domain-Driven Design (DDD) and supporting Test-Driven Development (TDD).

## Components

### IClock
The `IClock` interface defines a contract for accessing the current date and time. It abstracts time-related operations, making it easier to test time-dependent logic in your application.

#### Key Features:
- Provides the current UTC time (`UtcNow`).
- Provides the current local time (`Now`).
- Provides the current local time with offset (`NowWithOffset`).

### Clock
The `Clock` class is the default implementation of the `IClock` interface. It retrieves the current system time.

---

### Test-Driven Development (TDD)
The `IClock` interface simplifies testing by allowing you to mock or stub time-related operations. This is particularly useful for testing scenarios that depend on specific timestamps, such as scheduling, expiration, or time-based calculations.


### Using `IClock` in Application Code
```csharp
public class Order : DomainAggregate
{
    private readonly DateTime _orderDate;

    public bool IsOrderExpired(IClock clock)
    {
        return _orderDate < clock.UtcNow.AddDays(-30);
    }
}
```

### Mocking `IClock` in Unit Tests
```csharp
public class OrderTests
{
    [Fact]
    public void IsOrderExpired_ShouldReturnTrue_WhenOrderDateIsOlderThan30Days()
    {
        // Arrange
        var mockClock = new Mock<IClock>();
        mockClock.Setup(c => c.UtcNow).Returns(DateTime.UtcNow.AddDays(-31));
        
        var order = new Order(DateTime.UtcNow.AddDays(-31));

        // Act
        var result = order.IsOrderExpired(mockClock.Object);

        // Assert
        Assert.True(result);
    }
}
```