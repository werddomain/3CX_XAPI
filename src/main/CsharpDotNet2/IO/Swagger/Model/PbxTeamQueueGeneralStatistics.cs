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
  public class PbxTeamQueueGeneralStatistics {
    /// <summary>
    /// Gets or Sets AgentsInQueueCount
    /// </summary>
    [DataMember(Name="AgentsInQueueCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AgentsInQueueCount")]
    public int? AgentsInQueueCount { get; set; }

    /// <summary>
    /// Gets or Sets AnsweredCount
    /// </summary>
    [DataMember(Name="AnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredCount")]
    public long? AnsweredCount { get; set; }

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
    /// Gets or Sets QueueDnNumber
    /// </summary>
    [DataMember(Name="QueueDnNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDnNumber")]
    public string QueueDnNumber { get; set; }

    /// <summary>
    /// Gets or Sets ReceivedCount
    /// </summary>
    [DataMember(Name="ReceivedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReceivedCount")]
    public long? ReceivedCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalTalkTime
    /// </summary>
    [DataMember(Name="TotalTalkTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TotalTalkTime")]
    public string TotalTalkTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxTeamQueueGeneralStatistics {\n");
      sb.Append("  AgentsInQueueCount: ").Append(AgentsInQueueCount).Append("\n");
      sb.Append("  AnsweredCount: ").Append(AnsweredCount).Append("\n");
      sb.Append("  AvgTalkTime: ").Append(AvgTalkTime).Append("\n");
      sb.Append("  Dn: ").Append(Dn).Append("\n");
      sb.Append("  QueueDnNumber: ").Append(QueueDnNumber).Append("\n");
      sb.Append("  ReceivedCount: ").Append(ReceivedCount).Append("\n");
      sb.Append("  TotalTalkTime: ").Append(TotalTalkTime).Append("\n");
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
