# DDD Essentials

The `DDD Essentials` repository provides foundational building blocks and abstractions for implementing Domain-Driven Design (DDD) principles. It is designed to support scalable, maintainable, and testable applications by adhering to clean architecture and DDD best practices.

## Key Components

### 1. Essentials
The `Essentials` namespace includes core abstractions for defining domain aggregates and entities. These classes ensure consistency and scalability in DDD-based applications.

- **[Essentials](src/Pikot.DDD/Pikot.DDD/Essentials)**: Dive into the core abstractions of DDD, including `DomainAggregate`, `DomainEntity`...

### 2. Ports
The `Ports` namespace provides utilities and abstractions for integrating DDD principles with application layers. It includes tools like `IClock` for time management, which is useful in both DDD and TDD contexts.

- **[Ports](src/Pikot.DDD/Pikot.DDD/Ports)**: Dive into DDD ports and utilities.

### 3. Ports.CQRS
The `Ports.CQRS` namespace defines abstractions for implementing the Command Query Responsibility Segregation (CQRS) pattern. It includes base classes for read and write repositories, enabling a clear separation of concerns.

- **[Ports.CQRS](src/Pikot.DDD/Pikot.DDD/Ports/CQRS)**: Dive into CQRS abstractions.

## Summary
This repository provides essential tools and abstractions for building robust DDD-based applications. For more details, refer to the specific folders linked above.