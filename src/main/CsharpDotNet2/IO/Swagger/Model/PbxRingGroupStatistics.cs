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
  public class PbxRingGroupStatistics {
    /// <summary>
    /// Gets or Sets RingGroupAnsweredCount
    /// </summary>
    [DataMember(Name="RingGroupAnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingGroupAnsweredCount")]
    public long? RingGroupAnsweredCount { get; set; }

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
    /// Gets or Sets RingGroupReceivedCount
    /// </summary>
    [DataMember(Name="RingGroupReceivedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingGroupReceivedCount")]
    public long? RingGroupReceivedCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxRingGroupStatistics {\n");
      sb.Append("  RingGroupAnsweredCount: ").Append(RingGroupAnsweredCount).Append("\n");
      sb.Append("  RingGroupDisplayName: ").Append(RingGroupDisplayName).Append("\n");
      sb.Append("  RingGroupDn: ").Append(RingGroupDn).Append("\n");
      sb.Append("  RingGroupReceivedCount: ").Append(RingGroupReceivedCount).Append("\n");
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
