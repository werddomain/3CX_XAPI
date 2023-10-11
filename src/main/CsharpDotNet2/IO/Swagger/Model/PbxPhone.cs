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
  public class PbxPhone {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets _Interface
    /// </summary>
    [DataMember(Name="Interface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Interface")]
    public string _Interface { get; set; }

    /// <summary>
    /// Gets or Sets MacAddress
    /// </summary>
    [DataMember(Name="MacAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MacAddress")]
    public string MacAddress { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ProvisioningLinkExt
    /// </summary>
    [DataMember(Name="ProvisioningLinkExt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProvisioningLinkExt")]
    public string ProvisioningLinkExt { get; set; }

    /// <summary>
    /// Gets or Sets ProvisioningLinkLocal
    /// </summary>
    [DataMember(Name="ProvisioningLinkLocal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProvisioningLinkLocal")]
    public string ProvisioningLinkLocal { get; set; }

    /// <summary>
    /// Gets or Sets Settings
    /// </summary>
    [DataMember(Name="Settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Settings")]
    public AllOfPbxPhoneSettings Settings { get; set; }

    /// <summary>
    /// Gets or Sets TemplateName
    /// </summary>
    [DataMember(Name="TemplateName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TemplateName")]
    public string TemplateName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxPhone {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  _Interface: ").Append(_Interface).Append("\n");
      sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ProvisioningLinkExt: ").Append(ProvisioningLinkExt).Append("\n");
      sb.Append("  ProvisioningLinkLocal: ").Append(ProvisioningLinkLocal).Append("\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
      sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
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
