[![](https://img.shields.io/nuget/v/soenneker.dtos.streetaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.streetaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.streetaddress/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.streetaddress/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.dtos.streetaddress.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.dtos.streetaddress/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.dtos.streetaddress/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.dtos.streetaddress/actions/workflows/codeql.yml)

# Soenneker.Dtos.StreetAddress

Describes a physical or mailing address using international locality, administrative-area, postal-code, and country fields.

## Install

```bash
dotnet add package Soenneker.Dtos.StreetAddress
```

## What you get

- `StreetAddress` — Describes a physical or mailing address using international locality, administrative-area, postal-code, and country fields.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `StreetAddress.Line1` | Primary delivery line, such as a street address, post-office box, or company name. | Primary delivery line, such as a street address, post-office box, or company name. |
| `StreetAddress.Line2` | Secondary delivery line, such as an apartment, suite, unit, floor, or building. | Secondary delivery line, such as an apartment, suite, unit, floor, or building. |
| `StreetAddress.City` | City, town, village, or other postal locality. | City, town, village, or other postal locality. |
| `StreetAddress.State` | State or equivalent first-level administrative subdivision when that label is used by the country. | State or equivalent first-level administrative subdivision when that label is used by the country. |
| `StreetAddress.Province` | Province or territory when represented separately from `State` by the source or destination system. | Province or territory when represented separately from `State` by the source or destination system. |
| `StreetAddress.Region` | Region, district, county, prefecture, or other administrative area not represented by state or province. | Region, district, county, prefecture, or other administrative area not represented by state or province. |
| `StreetAddress.PostalCode` | Postal routing code, such as a ZIP code or postcode, formatted according to the destination country. | Postal routing code, such as a ZIP code or postcode, formatted according to the destination country. |
| `StreetAddress.Country` | Two-letter ISO 3166-1 alpha-2 country code, such as `US`, `GB`, or `CA`. | Two-letter ISO 3166-1 alpha-2 country code, such as `US`, `GB`, or `CA`. |
| `StreetAddress.AdditionalInfo` | Additional address context or delivery instructions that do not fit the structured fields. | Additional address context or delivery instructions that do not fit the structured fields. |
