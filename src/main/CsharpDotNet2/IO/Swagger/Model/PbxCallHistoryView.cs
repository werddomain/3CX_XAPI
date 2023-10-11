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
  public class PbxCallHistoryView {
    /// <summary>
    /// Gets or Sets CallAnswered
    /// </summary>
    [DataMember(Name="CallAnswered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallAnswered")]
    public bool? CallAnswered { get; set; }

    /// <summary>
    /// Gets or Sets CallTime
    /// </summary>
    [DataMember(Name="CallTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallTime")]
    public string CallTime { get; set; }

    /// <summary>
    /// Gets or Sets DstCallerNumber
    /// </summary>
    [DataMember(Name="DstCallerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstCallerNumber")]
    public string DstCallerNumber { get; set; }

    /// <summary>
    /// Gets or Sets DstDisplayName
    /// </summary>
    [DataMember(Name="DstDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstDisplayName")]
    public string DstDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DstDn
    /// </summary>
    [DataMember(Name="DstDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstDn")]
    public string DstDn { get; set; }

    /// <summary>
    /// Gets or Sets DstDnType
    /// </summary>
    [DataMember(Name="DstDnType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstDnType")]
    public int? DstDnType { get; set; }

    /// <summary>
    /// Gets or Sets DstExtendedDisplayName
    /// </summary>
    [DataMember(Name="DstExtendedDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstExtendedDisplayName")]
    public string DstExtendedDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DstExternal
    /// </summary>
    [DataMember(Name="DstExternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstExternal")]
    public bool? DstExternal { get; set; }

    /// <summary>
    /// Gets or Sets DstId
    /// </summary>
    [DataMember(Name="DstId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstId")]
    public int? DstId { get; set; }

    /// <summary>
    /// Gets or Sets DstInternal
    /// </summary>
    [DataMember(Name="DstInternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstInternal")]
    public bool? DstInternal { get; set; }

    /// <summary>
    /// Gets or Sets DstParticipantId
    /// </summary>
    [DataMember(Name="DstParticipantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstParticipantId")]
    public int? DstParticipantId { get; set; }

    /// <summary>
    /// Gets or Sets DstRecId
    /// </summary>
    [DataMember(Name="DstRecId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstRecId")]
    public int? DstRecId { get; set; }

    /// <summary>
    /// Gets or Sets SegmentActionId
    /// </summary>
    [DataMember(Name="SegmentActionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SegmentActionId")]
    public int? SegmentActionId { get; set; }

    /// <summary>
    /// Gets or Sets SegmentEndTime
    /// </summary>
    [DataMember(Name="SegmentEndTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SegmentEndTime")]
    public DateTime? SegmentEndTime { get; set; }

    /// <summary>
    /// Gets or Sets SegmentId
    /// </summary>
    [DataMember(Name="SegmentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SegmentId")]
    public int? SegmentId { get; set; }

    /// <summary>
    /// Gets or Sets SegmentStartTime
    /// </summary>
    [DataMember(Name="SegmentStartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SegmentStartTime")]
    public DateTime? SegmentStartTime { get; set; }

    /// <summary>
    /// Gets or Sets SegmentType
    /// </summary>
    [DataMember(Name="SegmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SegmentType")]
    public int? SegmentType { get; set; }

    /// <summary>
    /// Gets or Sets SrcCallerNumber
    /// </summary>
    [DataMember(Name="SrcCallerNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcCallerNumber")]
    public string SrcCallerNumber { get; set; }

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
    /// Gets or Sets SrcDnType
    /// </summary>
    [DataMember(Name="SrcDnType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcDnType")]
    public int? SrcDnType { get; set; }

    /// <summary>
    /// Gets or Sets SrcExtendedDisplayName
    /// </summary>
    [DataMember(Name="SrcExtendedDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcExtendedDisplayName")]
    public string SrcExtendedDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets SrcExternal
    /// </summary>
    [DataMember(Name="SrcExternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcExternal")]
    public bool? SrcExternal { get; set; }

    /// <summary>
    /// Gets or Sets SrcId
    /// </summary>
    [DataMember(Name="SrcId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcId")]
    public int? SrcId { get; set; }

    /// <summary>
    /// Gets or Sets SrcInternal
    /// </summary>
    [DataMember(Name="SrcInternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcInternal")]
    public bool? SrcInternal { get; set; }

    /// <summary>
    /// Gets or Sets SrcParticipantId
    /// </summary>
    [DataMember(Name="SrcParticipantId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcParticipantId")]
    public int? SrcParticipantId { get; set; }

    /// <summary>
    /// Gets or Sets SrcRecId
    /// </summary>
    [DataMember(Name="SrcRecId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcRecId")]
    public int? SrcRecId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxCallHistoryView {\n");
      sb.Append("  CallAnswered: ").Append(CallAnswered).Append("\n");
      sb.Append("  CallTime: ").Append(CallTime).Append("\n");
      sb.Append("  DstCallerNumber: ").Append(DstCallerNumber).Append("\n");
      sb.Append("  DstDisplayName: ").Append(DstDisplayName).Append("\n");
      sb.Append("  DstDn: ").Append(DstDn).Append("\n");
      sb.Append("  DstDnType: ").Append(DstDnType).Append("\n");
      sb.Append("  DstExtendedDisplayName: ").Append(DstExtendedDisplayName).Append("\n");
      sb.Append("  DstExternal: ").Append(DstExternal).Append("\n");
      sb.Append("  DstId: ").Append(DstId).Append("\n");
      sb.Append("  DstInternal: ").Append(DstInternal).Append("\n");
      sb.Append("  DstParticipantId: ").Append(DstParticipantId).Append("\n");
      sb.Append("  DstRecId: ").Append(DstRecId).Append("\n");
      sb.Append("  SegmentActionId: ").Append(SegmentActionId).Append("\n");
      sb.Append("  SegmentEndTime: ").Append(SegmentEndTime).Append("\n");
      sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
      sb.Append("  SegmentStartTime: ").Append(SegmentStartTime).Append("\n");
      sb.Append("  SegmentType: ").Append(SegmentType).Append("\n");
      sb.Append("  SrcCallerNumber: ").Append(SrcCallerNumber).Append("\n");
      sb.Append("  SrcDisplayName: ").Append(SrcDisplayName).Append("\n");
      sb.Append("  SrcDn: ").Append(SrcDn).Append("\n");
      sb.Append("  SrcDnType: ").Append(SrcDnType).Append("\n");
      sb.Append("  SrcExtendedDisplayName: ").Append(SrcExtendedDisplayName).Append("\n");
      sb.Append("  SrcExternal: ").Append(SrcExternal).Append("\n");
      sb.Append("  SrcId: ").Append(SrcId).Append("\n");
      sb.Append("  SrcInternal: ").Append(SrcInternal).Append("\n");
      sb.Append("  SrcParticipantId: ").Append(SrcParticipantId).Append("\n");
      sb.Append("  SrcRecId: ").Append(SrcRecId).Append("\n");
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
