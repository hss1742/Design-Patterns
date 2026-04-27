# Design Patterns in C#

This repository contains implementations and examples of various design patterns using C#.

## Project Structure

- `main.cs` - Entry point for the application (Strategy Pattern demo)
- `src/ObserverDesignPattern/` - Implementation of the Observer Design Pattern
  - `main.cs` - Demo for Observer Pattern
  - `Observable/` - Subject classes
  - `Observer/` - Observer classes
  - `Notification/` - Notification strategies (hybrid with Strategy Pattern)
  - `Models/` - Data models (Product, User)
- `src/StrategyDesignPattern/` - Implementation of the Strategy Design Pattern
  - `With/` - Strategy pattern with proper abstraction
  - `Without/` - Direct implementation without strategy pattern

## Getting Started

1. Ensure you have .NET SDK installed
2. Build the project: `dotnet build`
3. Run the application: `dotnet run` (for Strategy) or `dotnet run src/ObserverDesignPattern/main.cs` (for Observer)

## Design Patterns Covered

- Observer Pattern (with Strategy Pattern for notifications)
- Strategy Pattern

## Contributing

Feel free to add more design pattern implementations!