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
  public class PbxExtensionsStatisticsByRingGroups {
    /// <summary>
    /// Gets or Sets ExtensionAnsweredCount
    /// </summary>
    [DataMember(Name="ExtensionAnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtensionAnsweredCount")]
    public long? ExtensionAnsweredCount { get; set; }

    /// <summary>
    /// Gets or Sets ExtensionDisplayName
    /// </summary>
    [DataMember(Name="ExtensionDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtensionDisplayName")]
    public string ExtensionDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ExtensionDn
    /// </summary>
    [DataMember(Name="ExtensionDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtensionDn")]
    public string ExtensionDn { get; set; }

    /// <summary>
    /// Gets or Sets RingGroupDisplayName
    /// </summary>
    [DataMember(Name="RingGroupDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingGroupDisplayName")]
    public string RingGroupDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets RingGroupDn
    /// </summary>
    [DataMember(Name="RingGroupDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingGroupDn")]
    public string RingGroupDn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxExtensionsStatisticsByRingGroups {\n");
      sb.Append("  ExtensionAnsweredCount: ").Append(ExtensionAnsweredCount).Append("\n");
      sb.Append("  ExtensionDisplayName: ").Append(ExtensionDisplayName).Append("\n");
      sb.Append("  ExtensionDn: ").Append(ExtensionDn).Append("\n");
      sb.Append("  RingGroupDisplayName: ").Append(RingGroupDisplayName).Append("\n");
      sb.Append("  RingGroupDn: ").Append(RingGroupDn).Append("\n");
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
