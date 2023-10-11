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
  public class PbxDetailedQueueStatistics {
    /// <summary>
    /// Gets or Sets AnsweredCount
    /// </summary>
    [DataMember(Name="AnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredCount")]
    public long? AnsweredCount { get; set; }

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
    /// Gets or Sets CallbacksCount
    /// </summary>
    [DataMember(Name="CallbacksCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallbacksCount")]
    public long? CallbacksCount { get; set; }

    /// <summary>
    /// Gets or Sets CallsCount
    /// </summary>
    [DataMember(Name="CallsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallsCount")]
    public long? CallsCount { get; set; }

    /// <summary>
    /// Gets or Sets QueueDn
    /// </summary>
    [DataMember(Name="QueueDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDn")]
    public string QueueDn { get; set; }

    /// <summary>
    /// Gets or Sets QueueDnNumber
    /// </summary>
    [DataMember(Name="QueueDnNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDnNumber")]
    public string QueueDnNumber { get; set; }

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
      sb.Append("class PbxDetailedQueueStatistics {\n");
      sb.Append("  AnsweredCount: ").Append(AnsweredCount).Append("\n");
      sb.Append("  AvgRingTime: ").Append(AvgRingTime).Append("\n");
      sb.Append("  AvgTalkTime: ").Append(AvgTalkTime).Append("\n");
      sb.Append("  CallbacksCount: ").Append(CallbacksCount).Append("\n");
      sb.Append("  CallsCount: ").Append(CallsCount).Append("\n");
      sb.Append("  QueueDn: ").Append(QueueDn).Append("\n");
      sb.Append("  QueueDnNumber: ").Append(QueueDnNumber).Append("\n");
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
