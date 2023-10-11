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
  public class PbxQueuePerformanceTotals {
    /// <summary>
    /// Gets or Sets ExtensionAnsweredCount
    /// </summary>
    [DataMember(Name="ExtensionAnsweredCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtensionAnsweredCount")]
    public long? ExtensionAnsweredCount { get; set; }

    /// <summary>
    /// Gets or Sets ExtensionDroppedCount
    /// </summary>
    [DataMember(Name="ExtensionDroppedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtensionDroppedCount")]
    public long? ExtensionDroppedCount { get; set; }

    /// <summary>
    /// Gets or Sets QueueDisplayName
    /// </summary>
    [DataMember(Name="QueueDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDisplayName")]
    public string QueueDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets QueueDn
    /// </summary>
    [DataMember(Name="QueueDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDn")]
    public string QueueDn { get; set; }

    /// <summary>
    /// Gets or Sets QueueReceivedCount
    /// </summary>
    [DataMember(Name="QueueReceivedCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueReceivedCount")]
    public long? QueueReceivedCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxQueuePerformanceTotals {\n");
      sb.Append("  ExtensionAnsweredCount: ").Append(ExtensionAnsweredCount).Append("\n");
      sb.Append("  ExtensionDroppedCount: ").Append(ExtensionDroppedCount).Append("\n");
      sb.Append("  QueueDisplayName: ").Append(QueueDisplayName).Append("\n");
      sb.Append("  QueueDn: ").Append(QueueDn).Append("\n");
      sb.Append("  QueueReceivedCount: ").Append(QueueReceivedCount).Append("\n");
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
