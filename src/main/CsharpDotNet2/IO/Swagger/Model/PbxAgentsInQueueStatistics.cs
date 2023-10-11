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
  public class PbxAgentsInQueueStatistics {
    /// <summary>
    /// Gets or Sets AnsweredCount
    /// </summary>
    [DataMember(Name="AnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredCount")]
    public long? AnsweredCount { get; set; }

    /// <summary>
    /// Gets or Sets AnsweredPercent
    /// </summary>
    [DataMember(Name="AnsweredPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredPercent")]
    public int? AnsweredPercent { get; set; }

    /// <summary>
    /// Gets or Sets AnsweredPerHourCount
    /// </summary>
    [DataMember(Name="AnsweredPerHourCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredPerHourCount")]
    public long? AnsweredPerHourCount { get; set; }

    /// <summary>
    /// Gets or Sets AvgRingTime
    /// </summary>
    [DataMember(Name="AvgRingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AvgRingTime")]
    public string AvgRingTime { get; set; }

    /// <summary>
    /// Gets or Sets AvgTalkTime
    /// </summary>
    [DataMember(Name="AvgTalkTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AvgTalkTime")]
    public string AvgTalkTime { get; set; }

    /// <summary>
    /// Gets or Sets Dn
    /// </summary>
    [DataMember(Name="Dn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Dn")]
    public string Dn { get; set; }

    /// <summary>
    /// Gets or Sets DnDisplayName
    /// </summary>
    [DataMember(Name="DnDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DnDisplayName")]
    public string DnDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets LoggedInTime
    /// </summary>
    [DataMember(Name="LoggedInTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LoggedInTime")]
    public string LoggedInTime { get; set; }

    /// <summary>
    /// Gets or Sets LostCount
    /// </summary>
    [DataMember(Name="LostCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LostCount")]
    public long? LostCount { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [DataMember(Name="Queue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Queue")]
    public string Queue { get; set; }

    /// <summary>
    /// Gets or Sets QueueDisplayName
    /// </summary>
    [DataMember(Name="QueueDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDisplayName")]
    public string QueueDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets RingTime
    /// </summary>
    [DataMember(Name="RingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingTime")]
    public string RingTime { get; set; }

    /// <summary>
    /// Gets or Sets TalkTime
    /// </summary>
    [DataMember(Name="TalkTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TalkTime")]
    public string TalkTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxAgentsInQueueStatistics {\n");
      sb.Append("  AnsweredCount: ").Append(AnsweredCount).Append("\n");
      sb.Append("  AnsweredPercent: ").Append(AnsweredPercent).Append("\n");
      sb.Append("  AnsweredPerHourCount: ").Append(AnsweredPerHourCount).Append("\n");
      sb.Append("  AvgRingTime: ").Append(AvgRingTime).Append("\n");
      sb.Append("  AvgTalkTime: ").Append(AvgTalkTime).Append("\n");
      sb.Append("  Dn: ").Append(Dn).Append("\n");
      sb.Append("  DnDisplayName: ").Append(DnDisplayName).Append("\n");
      sb.Append("  LoggedInTime: ").Append(LoggedInTime).Append("\n");
      sb.Append("  LostCount: ").Append(LostCount).Append("\n");
      sb.Append("  Queue: ").Append(Queue).Append("\n");
      sb.Append("  QueueDisplayName: ").Append(QueueDisplayName).Append("\n");
      sb.Append("  RingTime: ").Append(RingTime).Append("\n");
      sb.Append("  TalkTime: ").Append(TalkTime).Append("\n");
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
