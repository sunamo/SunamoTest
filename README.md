# SunamoTest

## Short description

Pomocné třídy pro unit testy, například TypeWithProperties a práce s výjimkami v testech. Součást sbírky pinp s testy a Runnerem.


Helpers for unit tests

## Overview

SunamoTest is part of the Sunamo package ecosystem, providing modular, platform-independent utilities for .NET development.

## Main Components

### Key Classes

- **TypeWithProperties**
- **ExcTypes**
- **TestData**
- **TestDataCs**
- **TestDataTxt**
- **TestHelper**
- **TestLogger**
- **XmlTestsBase**

### Key Methods

- `Init()`
- `DefaultFolderPath()`
- `FolderForTestFiles()`
- `TestFile()`
- `GetFileInProjectsFolder()`
- `IsEnabled()`

## Installation

```bash
dotnet add package SunamoTest
```

## Dependencies

- **Microsoft.Extensions.Logging.Abstractions** (v9.0.3)

## Package Information

- **Package Name**: SunamoTest
- **Version**: 25.3.16.1
- **Target Framework**: net9.0
- **Category**: Platform-Independent NuGet Package
- **Source Files**: 24

## Related Packages

This package is part of the Sunamo package ecosystem. For more information about related packages, visit the main repository.

## License

See the repository root for license information.

<!-- sunamo:test-coverage:start -->
## Test coverage

| Metric | Value |
|---|---|
| Method | static |
| Test projects | 1 |
| Public types referenced by tests | 4/8 (50.0 %) |
| Public methods referenced by tests | 2/9 (22.2 %) |
| Line coverage | n/a |
| Branch coverage | n/a |
| Generated (UTC) | 2026-11-22 21:24 |

<!-- sunamo:test-coverage:data {"package":"SunamoTest","container":"pinp","testProjects":1,"publicTypes":8,"typesReferencedByTests":4,"publicMethods":9,"methodsReferencedByTests":2,"lineRate":null,"branchRate":null,"method":"static","generatedUtc":"2026-11-22 21:24"} -->
<!-- sunamo:test-coverage:end -->
