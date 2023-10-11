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
  public class PbxCallCostByExtensionGroup {
    /// <summary>
    /// Gets or Sets BillingCost
    /// </summary>
    [DataMember(Name="BillingCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillingCost")]
    public decimal? BillingCost { get; set; }

    /// <summary>
    /// Gets or Sets CallType
    /// </summary>
    [DataMember(Name="CallType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallType")]
    public string CallType { get; set; }

    /// <summary>
    /// Gets or Sets DstDn
    /// </summary>
    [DataMember(Name="DstDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstDn")]
    public string DstDn { get; set; }

    /// <summary>
    /// Gets or Sets DstDnClass
    /// </summary>
    [DataMember(Name="DstDnClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstDnClass")]
    public int? DstDnClass { get; set; }

    /// <summary>
    /// Gets or Sets GroupName
    /// </summary>
    [DataMember(Name="GroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupName")]
    public string GroupName { get; set; }

    /// <summary>
    /// Gets or Sets IsAnswered
    /// </summary>
    [DataMember(Name="IsAnswered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsAnswered")]
    public bool? IsAnswered { get; set; }

    /// <summary>
    /// Gets or Sets RingingDur
    /// </summary>
    [DataMember(Name="RingingDur", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingingDur")]
    public string RingingDur { get; set; }

    /// <summary>
    /// Gets or Sets SegId
    /// </summary>
    [DataMember(Name="SegId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SegId")]
    public int? SegId { get; set; }

    /// <summary>
    /// Gets or Sets SrcDisplayName
    /// </summary>
    [DataMember(Name="SrcDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcDisplayName")]
    public string SrcDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets SrcDn
    /// </summary>
    [DataMember(Name="SrcDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcDn")]
    public string SrcDn { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="StartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Gets or Sets TalkingDur
    /// </summary>
    [DataMember(Name="TalkingDur", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TalkingDur")]
    public string TalkingDur { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxCallCostByExtensionGroup {\n");
      sb.Append("  BillingCost: ").Append(BillingCost).Append("\n");
      sb.Append("  CallType: ").Append(CallType).Append("\n");
      sb.Append("  DstDn: ").Append(DstDn).Append("\n");
      sb.Append("  DstDnClass: ").Append(DstDnClass).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      sb.Append("  IsAnswered: ").Append(IsAnswered).Append("\n");
      sb.Append("  RingingDur: ").Append(RingingDur).Append("\n");
      sb.Append("  SegId: ").Append(SegId).Append("\n");
      sb.Append("  SrcDisplayName: ").Append(SrcDisplayName).Append("\n");
      sb.Append("  SrcDn: ").Append(SrcDn).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  TalkingDur: ").Append(TalkingDur).Append("\n");
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
