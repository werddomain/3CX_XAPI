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
  public class PbxQueueAgentsChatStatisticsTotals {
    /// <summary>
    /// Gets or Sets AnsweredCount
    /// </summary>
    [DataMember(Name="AnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredCount")]
    public long? AnsweredCount { get; set; }

    /// <summary>
    /// Gets or Sets DealtWithCount
    /// </summary>
    [DataMember(Name="DealtWithCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DealtWithCount")]
    public long? DealtWithCount { get; set; }

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
      sb.Append("class PbxQueueAgentsChatStatisticsTotals {\n");
      sb.Append("  AnsweredCount: ").Append(AnsweredCount).Append("\n");
      sb.Append("  DealtWithCount: ").Append(DealtWithCount).Append("\n");
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
