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
  public class PbxSbc {
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name="Group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Group")]
    public string Group { get; set; }

    /// <summary>
    /// Gets or Sets HasConnection
    /// </summary>
    [DataMember(Name="HasConnection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasConnection")]
    public bool? HasConnection { get; set; }

    /// <summary>
    /// Gets or Sets LocalIPv4
    /// </summary>
    [DataMember(Name="LocalIPv4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalIPv4")]
    public string LocalIPv4 { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="Password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets PhoneMAC
    /// </summary>
    [DataMember(Name="PhoneMAC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneMAC")]
    public string PhoneMAC { get; set; }

    /// <summary>
    /// Gets or Sets PhoneUserId
    /// </summary>
    [DataMember(Name="PhoneUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneUserId")]
    public int? PhoneUserId { get; set; }

    /// <summary>
    /// Gets or Sets ProvisionLink
    /// </summary>
    [DataMember(Name="ProvisionLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProvisionLink")]
    public string ProvisionLink { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxSbc {\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  HasConnection: ").Append(HasConnection).Append("\n");
      sb.Append("  LocalIPv4: ").Append(LocalIPv4).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  PhoneMAC: ").Append(PhoneMAC).Append("\n");
      sb.Append("  PhoneUserId: ").Append(PhoneUserId).Append("\n");
      sb.Append("  ProvisionLink: ").Append(ProvisionLink).Append("\n");
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
