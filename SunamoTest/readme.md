# SunamoTest

A lightweight helper library for unit testing in .NET projects. Provides reusable test data, a test logger, XML test base classes, and utility methods for test environment initialization.

## Target Frameworks

**Supported:** `net10.0`, `net9.0`, `net8.0`

## Features

- **TestData** - Pre-built collections and constants (string lists, integer ranges, JSON samples) for common test scenarios
- **TestDataCs / TestDataTxt** - File name constants for C# and text file testing
- **TestLogger** - An `ILogger` implementation that throws on Error/Critical log levels, surfacing failures in tests
- **TestHelper** - Utility methods for initializing test environments, managing test folders, and refreshing original test files
- **XmlTestsBase** - Base class with pre-defined XML test data strings for XML parsing tests
- **ExcTypes** - Static exception type references for assertion helpers
- **TypeWithProperties** - A simple model class with various property types for reflection and serialization testing

## Installation

```bash
dotnet add package SunamoTest
```

## Usage

```csharp
using SunamoTest;

// Use pre-built test data
var list = TestData.ListABC; // ["a", "b", "c"]
var range = TestData.Range0To100; // [0, 1, 2, ..., 100]

// Use the test logger that throws on errors
ILogger logger = TestLogger.Instance;

// Initialize the test environment
TestHelper.Init("MyApp");
```

## License

MIT
