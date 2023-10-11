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
  public class PbxPhoneRegistrar {
    /// <summary>
    /// Gets or Sets FirmwareAvailable
    /// </summary>
    [DataMember(Name="FirmwareAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirmwareAvailable")]
    public string FirmwareAvailable { get; set; }

    /// <summary>
    /// Gets or Sets FirmwareVersion
    /// </summary>
    [DataMember(Name="FirmwareVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirmwareVersion")]
    public string FirmwareVersion { get; set; }

    /// <summary>
    /// Gets or Sets InterfaceLink
    /// </summary>
    [DataMember(Name="InterfaceLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InterfaceLink")]
    public string InterfaceLink { get; set; }

    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [DataMember(Name="IpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IpAddress")]
    public string IpAddress { get; set; }

    /// <summary>
    /// Gets or Sets MAC
    /// </summary>
    [DataMember(Name="MAC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MAC")]
    public string MAC { get; set; }

    /// <summary>
    /// Gets or Sets PhoneWebPassword
    /// </summary>
    [DataMember(Name="PhoneWebPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneWebPassword")]
    public string PhoneWebPassword { get; set; }

    /// <summary>
    /// Gets or Sets UserAgent
    /// </summary>
    [DataMember(Name="UserAgent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserAgent")]
    public string UserAgent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxPhoneRegistrar {\n");
      sb.Append("  FirmwareAvailable: ").Append(FirmwareAvailable).Append("\n");
      sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
      sb.Append("  InterfaceLink: ").Append(InterfaceLink).Append("\n");
      sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
      sb.Append("  MAC: ").Append(MAC).Append("\n");
      sb.Append("  PhoneWebPassword: ").Append(PhoneWebPassword).Append("\n");
      sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
