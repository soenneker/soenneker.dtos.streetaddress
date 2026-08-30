[![](https://img.shields.io/nuget/v/soenneker.dtos.streetaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.streetaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.streetaddress/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.streetaddress/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.streetaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.streetaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.streetaddress/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.streetaddress/actions/workflows/codeql.yml)

# Soenneker.Dtos.StreetAddress

A flexible physical or mailing-address DTO with separate locality and administrative-area fields. It preserves the same camel-case JSON shape with `System.Text.Json` and Newtonsoft.Json.

## Install

```bash
dotnet add package Soenneker.Dtos.StreetAddress
```

## Usage

```csharp
using Soenneker.Dtos.StreetAddress;

var address = new StreetAddress
{
    Line1 = "123 Main Street",
    Line2 = "Suite 400",
    City = "Chicago",
    State = "IL",
    PostalCode = "60601",
    Country = "US",
    AdditionalInfo = "Deliver at reception"
};
```

Use `State`, `Province`, and `Region` according to the source or destination system's address schema; the type does not force one international convention. `PostalCode` is a string so formatting and leading zeroes are preserved.

All properties are optional. The DTO does not validate deliverability, normalize casing or abbreviations, geocode the address, or enforce a country-code format. If your API requires particular fields or ISO 3166-1 alpha-2 country codes, validate those rules at its boundary.

Null properties are included or omitted according to your serializer settings.
