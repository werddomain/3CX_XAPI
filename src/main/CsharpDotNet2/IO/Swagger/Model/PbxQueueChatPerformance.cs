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
  public class PbxQueueChatPerformance {
    /// <summary>
    /// Gets or Sets AbandonedCount
    /// </summary>
    [DataMember(Name="AbandonedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AbandonedCount")]
    public long? AbandonedCount { get; set; }

    /// <summary>
    /// Gets or Sets AnsweredCount
    /// </summary>
    [DataMember(Name="AnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredCount")]
    public long? AnsweredCount { get; set; }

    /// <summary>
    /// Gets or Sets IncomingCount
    /// </summary>
    [DataMember(Name="IncomingCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IncomingCount")]
    public long? IncomingCount { get; set; }

    /// <summary>
    /// Gets or Sets QuantityAgents
    /// </summary>
    [DataMember(Name="QuantityAgents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QuantityAgents")]
    public long? QuantityAgents { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxQueueChatPerformance {\n");
      sb.Append("  AbandonedCount: ").Append(AbandonedCount).Append("\n");
      sb.Append("  AnsweredCount: ").Append(AnsweredCount).Append("\n");
      sb.Append("  IncomingCount: ").Append(IncomingCount).Append("\n");
      sb.Append("  QuantityAgents: ").Append(QuantityAgents).Append("\n");
      sb.Append("  Queue: ").Append(Queue).Append("\n");
      sb.Append("  QueueDisplayName: ").Append(QueueDisplayName).Append("\n");
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
