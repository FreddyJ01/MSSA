# Interface Segregation Demo

## Purpose
Demonstrates the Interface Segregation Principle (ISP) - clients should not be forced to depend on interfaces they don't use.

## Key Concepts
- Interface Segregation Principle violation example
- Fat interfaces vs. focused interfaces
- NotImplementedException as a code smell
- Better interface design patterns

## What's Demonstrated
- Current code violates ISP by forcing all workers to implement `Eat()`
- Shows the problems with "fat" interfaces
- Example of what NOT to do in interface design

## Better Approach (Not Implemented Here)
Split interfaces into:
- `IWorker` (for Work method)
- `IEater` (for Eat method)

## Usage
```bash
dotnet run
```

This demo shows interface violations as a learning example.