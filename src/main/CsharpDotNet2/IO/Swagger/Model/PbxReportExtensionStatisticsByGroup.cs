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
  public class PbxReportExtensionStatisticsByGroup {
    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Dn
    /// </summary>
    [DataMember(Name="Dn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Dn")]
    public string Dn { get; set; }

    /// <summary>
    /// Gets or Sets InboundAnsweredCount
    /// </summary>
    [DataMember(Name="InboundAnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InboundAnsweredCount")]
    public long? InboundAnsweredCount { get; set; }

    /// <summary>
    /// Gets or Sets InboundAnsweredTalkingDur
    /// </summary>
    [DataMember(Name="InboundAnsweredTalkingDur", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InboundAnsweredTalkingDur")]
    public string InboundAnsweredTalkingDur { get; set; }

    /// <summary>
    /// Gets or Sets InboundUnansweredCount
    /// </summary>
    [DataMember(Name="InboundUnansweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InboundUnansweredCount")]
    public long? InboundUnansweredCount { get; set; }

    /// <summary>
    /// Gets or Sets OutboundAnsweredCount
    /// </summary>
    [DataMember(Name="OutboundAnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutboundAnsweredCount")]
    public long? OutboundAnsweredCount { get; set; }

    /// <summary>
    /// Gets or Sets OutboundAnsweredTalkingDur
    /// </summary>
    [DataMember(Name="OutboundAnsweredTalkingDur", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutboundAnsweredTalkingDur")]
    public string OutboundAnsweredTalkingDur { get; set; }

    /// <summary>
    /// Gets or Sets OutboundUnansweredCount
    /// </summary>
    [DataMember(Name="OutboundUnansweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutboundUnansweredCount")]
    public long? OutboundUnansweredCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxReportExtensionStatisticsByGroup {\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Dn: ").Append(Dn).Append("\n");
      sb.Append("  InboundAnsweredCount: ").Append(InboundAnsweredCount).Append("\n");
      sb.Append("  InboundAnsweredTalkingDur: ").Append(InboundAnsweredTalkingDur).Append("\n");
      sb.Append("  InboundUnansweredCount: ").Append(InboundUnansweredCount).Append("\n");
      sb.Append("  OutboundAnsweredCount: ").Append(OutboundAnsweredCount).Append("\n");
      sb.Append("  OutboundAnsweredTalkingDur: ").Append(OutboundAnsweredTalkingDur).Append("\n");
      sb.Append("  OutboundUnansweredCount: ").Append(OutboundUnansweredCount).Append("\n");
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
