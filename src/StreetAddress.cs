using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.StreetAddress;

/// <summary>
/// A minimal record type for physical addresses, with international support and maximum serialization compatibility
/// </summary>
[DataContract]
public record StreetAddress
{
    /// <summary>
    /// Gets or sets the primary street address.
    /// </summary>
    [JsonPropertyName("street1")]
    [JsonProperty("street1")]
    [DataMember(Name = "street1")]
    public string Street1 { get; set; } = default!;

    /// <summary>
    /// Gets or sets the secondary street address (e.g., apartment or suite number).
    /// </summary>
    [JsonPropertyName("street2")]
    [JsonProperty("street2")]
    [DataMember(Name = "street2")]
    public string? Street2 { get; set; }

    /// <summary>
    /// Gets or sets the city of the address.
    /// </summary>
    [JsonPropertyName("city")]
    [JsonProperty("city")]
    [DataMember(Name = "city")]
    public string City { get; set; } = default!;

    /// <summary>
    /// Gets or sets the state or equivalent administrative region of the address.
    /// </summary>
    [JsonPropertyName("state")]
    [JsonProperty("state")]
    [DataMember(Name = "state")]
    public string? State { get; set; }

    /// <summary>
    /// Gets or sets the province or equivalent administrative region of the address (used in some countries).
    /// </summary>
    [JsonPropertyName("province")]
    [JsonProperty("province")]
    [DataMember(Name = "province")]
    public string? Province { get; set; }

    /// <summary>
    /// Gets or sets the region or equivalent larger administrative area of the address (used in some countries).
    /// </summary>
    [JsonPropertyName("region")]
    [JsonProperty("region")]
    [DataMember(Name = "region")]
    public string? Region { get; set; }

    /// <summary>
    /// Gets or sets the postal code of the address.
    /// </summary>
    [JsonPropertyName("postalCode")]
    [JsonProperty("postalCode")]
    [DataMember(Name = "postalCode")]
    public string PostalCode { get; set; } = default!;

    /// <summary>
    /// Gets or sets the country of the address.
    /// </summary>
    [JsonPropertyName("country")]
    [JsonProperty("country")]
    [DataMember(Name = "country")]
    public string? Country { get; set; }

    /// <summary>
    /// Gets or sets any additional information related to the address.
    /// </summary>
    [JsonPropertyName("additionalInfo")]
    [JsonProperty("additionalInfo")]
    [DataMember(Name = "additionalInfo")]
    public string? AdditionalInfo { get; set; }
}