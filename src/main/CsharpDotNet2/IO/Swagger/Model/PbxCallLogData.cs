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
  public class PbxCallLogData {
    /// <summary>
    /// Gets or Sets ActionDnCallerId
    /// </summary>
    [DataMember(Name="ActionDnCallerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionDnCallerId")]
    public string ActionDnCallerId { get; set; }

    /// <summary>
    /// Gets or Sets ActionDnDisplayName
    /// </summary>
    [DataMember(Name="ActionDnDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionDnDisplayName")]
    public string ActionDnDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ActionDnDn
    /// </summary>
    [DataMember(Name="actionDnDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "actionDnDn")]
    public string ActionDnDn { get; set; }

    /// <summary>
    /// Gets or Sets ActionDnType
    /// </summary>
    [DataMember(Name="ActionDnType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionDnType")]
    public int? ActionDnType { get; set; }

    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    [DataMember(Name="ActionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActionType")]
    public int? ActionType { get; set; }

    /// <summary>
    /// Gets or Sets Answered
    /// </summary>
    [DataMember(Name="Answered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Answered")]
    public bool? Answered { get; set; }

    /// <summary>
    /// Gets or Sets CallCost
    /// </summary>
    [DataMember(Name="CallCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallCost")]
    public decimal? CallCost { get; set; }

    /// <summary>
    /// Gets or Sets CallId
    /// </summary>
    [DataMember(Name="CallId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallId")]
    public int? CallId { get; set; }

    /// <summary>
    /// Gets or Sets DestinationCallerId
    /// </summary>
    [DataMember(Name="DestinationCallerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DestinationCallerId")]
    public string DestinationCallerId { get; set; }

    /// <summary>
    /// Gets or Sets DestinationDisplayName
    /// </summary>
    [DataMember(Name="DestinationDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DestinationDisplayName")]
    public string DestinationDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DestinationDn
    /// </summary>
    [DataMember(Name="DestinationDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DestinationDn")]
    public string DestinationDn { get; set; }

    /// <summary>
    /// Gets or Sets DestinationType
    /// </summary>
    [DataMember(Name="DestinationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DestinationType")]
    public int? DestinationType { get; set; }

    /// <summary>
    /// Gets or Sets DstRecId
    /// </summary>
    [DataMember(Name="DstRecId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DstRecId")]
    public int? DstRecId { get; set; }

    /// <summary>
    /// Gets or Sets Indent
    /// </summary>
    [DataMember(Name="Indent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Indent")]
    public int? Indent { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name="Reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or Sets RecordingUrl
    /// </summary>
    [DataMember(Name="RecordingUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingUrl")]
    public string RecordingUrl { get; set; }

    /// <summary>
    /// Gets or Sets RingingDuration
    /// </summary>
    [DataMember(Name="RingingDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingingDuration")]
    public string RingingDuration { get; set; }

    /// <summary>
    /// Gets or Sets SegmentId
    /// </summary>
    [DataMember(Name="SegmentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SegmentId")]
    public int? SegmentId { get; set; }

    /// <summary>
    /// Gets or Sets SourceCallerId
    /// </summary>
    [DataMember(Name="SourceCallerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceCallerId")]
    public string SourceCallerId { get; set; }

    /// <summary>
    /// Gets or Sets SourceDisplayName
    /// </summary>
    [DataMember(Name="SourceDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceDisplayName")]
    public string SourceDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets SourceDn
    /// </summary>
    [DataMember(Name="SourceDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceDn")]
    public string SourceDn { get; set; }

    /// <summary>
    /// Gets or Sets SourceType
    /// </summary>
    [DataMember(Name="SourceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceType")]
    public int? SourceType { get; set; }

    /// <summary>
    /// Gets or Sets SrcRecId
    /// </summary>
    [DataMember(Name="SrcRecId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SrcRecId")]
    public int? SrcRecId { get; set; }

    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="StartTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartTime")]
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// Gets or Sets SubrowDescNumber
    /// </summary>
    [DataMember(Name="SubrowDescNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubrowDescNumber")]
    public int? SubrowDescNumber { get; set; }

    /// <summary>
    /// Gets or Sets TalkingDuration
    /// </summary>
    [DataMember(Name="TalkingDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TalkingDuration")]
    public string TalkingDuration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxCallLogData {\n");
      sb.Append("  ActionDnCallerId: ").Append(ActionDnCallerId).Append("\n");
      sb.Append("  ActionDnDisplayName: ").Append(ActionDnDisplayName).Append("\n");
      sb.Append("  ActionDnDn: ").Append(ActionDnDn).Append("\n");
      sb.Append("  ActionDnType: ").Append(ActionDnType).Append("\n");
      sb.Append("  ActionType: ").Append(ActionType).Append("\n");
      sb.Append("  Answered: ").Append(Answered).Append("\n");
      sb.Append("  CallCost: ").Append(CallCost).Append("\n");
      sb.Append("  CallId: ").Append(CallId).Append("\n");
      sb.Append("  DestinationCallerId: ").Append(DestinationCallerId).Append("\n");
      sb.Append("  DestinationDisplayName: ").Append(DestinationDisplayName).Append("\n");
      sb.Append("  DestinationDn: ").Append(DestinationDn).Append("\n");
      sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
      sb.Append("  DstRecId: ").Append(DstRecId).Append("\n");
      sb.Append("  Indent: ").Append(Indent).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  RecordingUrl: ").Append(RecordingUrl).Append("\n");
      sb.Append("  RingingDuration: ").Append(RingingDuration).Append("\n");
      sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
      sb.Append("  SourceCallerId: ").Append(SourceCallerId).Append("\n");
      sb.Append("  SourceDisplayName: ").Append(SourceDisplayName).Append("\n");
      sb.Append("  SourceDn: ").Append(SourceDn).Append("\n");
      sb.Append("  SourceType: ").Append(SourceType).Append("\n");
      sb.Append("  SrcRecId: ").Append(SrcRecId).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  SubrowDescNumber: ").Append(SubrowDescNumber).Append("\n");
      sb.Append("  TalkingDuration: ").Append(TalkingDuration).Append("\n");
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
