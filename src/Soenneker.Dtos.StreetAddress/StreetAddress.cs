using Newtonsoft.Json;
using System.Text.Json.Serialization;
using Soenneker.Attributes.PublicOpenApiObject;

namespace Soenneker.Dtos.StreetAddress;

/// <summary>
/// Describes a physical or mailing address using international locality, administrative-area, postal-code, and country fields.
/// </summary>
[PublicOpenApiObject]
public sealed record StreetAddress
{
    /// <summary>
    /// Primary delivery line, such as a street address, post-office box, or company name.
    /// </summary>
    [JsonPropertyName("line1")]
    [JsonProperty("line1")]
    public string? Line1 { get; set; }

    /// <summary>
    /// Secondary delivery line, such as an apartment, suite, unit, floor, or building.
    /// </summary>
    [JsonPropertyName("line2")]
    [JsonProperty("line2")]
    public string? Line2 { get; set; }

    /// <summary>
    /// City, town, village, or other postal locality.
    /// </summary>
    [JsonPropertyName("city")]
    [JsonProperty("city")]
    public string? City { get; set; }

    /// <summary>
    /// State or equivalent first-level administrative subdivision when that label is used by the country.
    /// </summary>
    [JsonPropertyName("state")]
    [JsonProperty("state")]
    public string? State { get; set; }

    /// <summary>
    /// Province or territory when represented separately from <see cref="State"/> by the source or destination system.
    /// </summary>
    [JsonPropertyName("province")]
    [JsonProperty("province")]
    public string? Province { get; set; }

    /// <summary>
    /// Region, district, county, prefecture, or other administrative area not represented by state or province.
    /// </summary>
    [JsonPropertyName("region")]
    [JsonProperty("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Postal routing code, such as a ZIP code or postcode, formatted according to the destination country.
    /// </summary>
    [JsonPropertyName("postalCode")]
    [JsonProperty("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// Two-letter ISO 3166-1 alpha-2 country code, such as <c>US</c>, <c>GB</c>, or <c>CA</c>.
    /// </summary>
    [JsonPropertyName("country")]
    [JsonProperty("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Additional address context or delivery instructions that do not fit the structured fields.
    /// </summary>
    [JsonPropertyName("additionalInfo")]
    [JsonProperty("additionalInfo")]
    public string? AdditionalInfo { get; set; }
}
