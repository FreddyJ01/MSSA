# Dependency Injection Demo

## Purpose
Demonstrates the Dependency Inversion Principle (DIP) - the "D" in SOLID principles.

## Key Concepts
- Dependency Injection through constructor
- Interface-based programming
- Loose coupling between classes
- Testability and flexibility

## What's Demonstrated
- `FileManager` depends on `IStorage` abstraction, not concrete implementations
- Storage implementation is injected via constructor
- Easy to swap between `LocalStorage` and `RemoteStorage`
- Follows SOLID principles

## Usage
```bash
dotnet run
```

## Expected Output
```
[FileManager] Saving document 'report.txt'...
[LocalStorage] 'report.txt' saved with content: Quarterly data...
[FileManager] Deleting document 'report.txt'...
[LocalStorage] 'report.txt' deleted from disk.
```