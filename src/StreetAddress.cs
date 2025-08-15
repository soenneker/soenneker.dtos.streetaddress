using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.StreetAddress;

/// <summary>
/// A minimal, serializable record type for physical mailing addresses, 
/// with support for international formats and compatibility with common APIs.
/// </summary>
[PublicOpenApiObject]
public sealed record StreetAddress
{
    /// <summary>
    /// The primary address line (e.g., street address, P.O. box, company name).
    /// </summary>
    [JsonPropertyName("line1")]
    [JsonProperty("line1")]
    public string? Line1 { get; set; }

    /// <summary>
    /// The secondary address line (e.g., apartment, suite, unit, or building).
    /// </summary>
    [JsonPropertyName("line2")]
    [JsonProperty("line2")]
    public string? Line2 { get; set; }

    /// <summary>
    /// The city, town, or locality.
    /// </summary>
    [JsonPropertyName("city")]
    [JsonProperty("city")]
    public string? City { get; set; }

    /// <summary>
    /// The state, province, or equivalent administrative region.
    /// Commonly used in countries like the US, Canada, and Australia.
    /// </summary>
    [JsonPropertyName("state")]
    [JsonProperty("state")]
    public string? State { get; set; }

    /// <summary>
    /// The province or territory, if distinct from state in your use case (optional, use with care).
    /// </summary>
    [JsonPropertyName("province")]
    [JsonProperty("province")]
    public string? Province { get; set; }

    /// <summary>
    /// The broader region, district, or administrative area (e.g., prefecture or county).
    /// </summary>
    [JsonPropertyName("region")]
    [JsonProperty("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The postal or ZIP code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    [JsonProperty("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The ISO 3166-1 alpha-2 country code (e.g., "US", "GB", "CA").
    /// </summary>
    [JsonPropertyName("country")]
    [JsonProperty("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Optional additional notes or delivery instructions.
    /// </summary>
    [JsonPropertyName("additionalInfo")]
    [JsonProperty("additionalInfo")]
    public string? AdditionalInfo { get; set; }
}