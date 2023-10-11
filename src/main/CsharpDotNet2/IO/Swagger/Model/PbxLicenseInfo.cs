using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PbxLicenseInfo {
    /// <summary>
    /// Gets or Sets Activated
    /// </summary>
    [DataMember(Name="Activated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Activated")]
    public bool? Activated { get; set; }

    /// <summary>
    /// Gets or Sets AdminEMail
    /// </summary>
    [DataMember(Name="AdminEMail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdminEMail")]
    public string AdminEMail { get; set; }

    /// <summary>
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or Sets ContactName
    /// </summary>
    [DataMember(Name="ContactName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactName")]
    public string ContactName { get; set; }

    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    [DataMember(Name="CountryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or Sets CountryName
    /// </summary>
    [DataMember(Name="CountryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountryName")]
    public string CountryName { get; set; }

    /// <summary>
    /// Gets or Sets EMail
    /// </summary>
    [DataMember(Name="EMail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EMail")]
    public string EMail { get; set; }

    /// <summary>
    /// Gets or Sets ExpirationDate
    /// </summary>
    [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Gets or Sets LicenseActive
    /// </summary>
    [DataMember(Name="LicenseActive", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LicenseActive")]
    public bool? LicenseActive { get; set; }

    /// <summary>
    /// Gets or Sets LicenseKey
    /// </summary>
    [DataMember(Name="LicenseKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LicenseKey")]
    public string LicenseKey { get; set; }

    /// <summary>
    /// Gets or Sets LicenseType
    /// </summary>
    [DataMember(Name="LicenseType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LicenseType")]
    public AllOfPbxLicenseInfoLicenseType LicenseType { get; set; }

    /// <summary>
    /// Gets or Sets MaintenanceExpiresAt
    /// </summary>
    [DataMember(Name="MaintenanceExpiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaintenanceExpiresAt")]
    public DateTime? MaintenanceExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets MaxSimCalls
    /// </summary>
    [DataMember(Name="MaxSimCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxSimCalls")]
    public int? MaxSimCalls { get; set; }

    /// <summary>
    /// Gets or Sets ProductCode
    /// </summary>
    [DataMember(Name="ProductCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductCode")]
    public string ProductCode { get; set; }

    /// <summary>
    /// Gets or Sets ResellerName
    /// </summary>
    [DataMember(Name="ResellerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResellerName")]
    public string ResellerName { get; set; }

    /// <summary>
    /// Gets or Sets SimMeetingParticipants
    /// </summary>
    [DataMember(Name="SimMeetingParticipants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SimMeetingParticipants")]
    public int? SimMeetingParticipants { get; set; }

    /// <summary>
    /// Gets or Sets Support
    /// </summary>
    [DataMember(Name="Support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Support")]
    public bool? Support { get; set; }

    /// <summary>
    /// Gets or Sets Telephone
    /// </summary>
    [DataMember(Name="Telephone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Telephone")]
    public string Telephone { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxLicenseInfo {\n");
      sb.Append("  Activated: ").Append(Activated).Append("\n");
      sb.Append("  AdminEMail: ").Append(AdminEMail).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  ContactName: ").Append(ContactName).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  CountryName: ").Append(CountryName).Append("\n");
      sb.Append("  EMail: ").Append(EMail).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  LicenseActive: ").Append(LicenseActive).Append("\n");
      sb.Append("  LicenseKey: ").Append(LicenseKey).Append("\n");
      sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
      sb.Append("  MaintenanceExpiresAt: ").Append(MaintenanceExpiresAt).Append("\n");
      sb.Append("  MaxSimCalls: ").Append(MaxSimCalls).Append("\n");
      sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
      sb.Append("  ResellerName: ").Append(ResellerName).Append("\n");
      sb.Append("  SimMeetingParticipants: ").Append(SimMeetingParticipants).Append("\n");
      sb.Append("  Support: ").Append(Support).Append("\n");
      sb.Append("  Telephone: ").Append(Telephone).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
