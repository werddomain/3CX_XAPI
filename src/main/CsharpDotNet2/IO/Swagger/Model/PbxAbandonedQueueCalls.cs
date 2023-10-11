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
  public class PbxAbandonedQueueCalls {
    /// <summary>
    /// Gets or Sets CallerId
    /// </summary>
    [DataMember(Name="CallerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallerId")]
    public string CallerId { get; set; }

    /// <summary>
    /// Gets or Sets CallHistoryId
    /// </summary>
    [DataMember(Name="CallHistoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallHistoryId")]
    public string CallHistoryId { get; set; }

    /// <summary>
    /// Gets or Sets CallTime
    /// </summary>
    [DataMember(Name="CallTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallTime")]
    public DateTime? CallTime { get; set; }

    /// <summary>
    /// Gets or Sets CallTimeForCsv
    /// </summary>
    [DataMember(Name="CallTimeForCsv", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallTimeForCsv")]
    public DateTime? CallTimeForCsv { get; set; }

    /// <summary>
    /// Gets or Sets ExtensionDisplayName
    /// </summary>
    [DataMember(Name="ExtensionDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtensionDisplayName")]
    public string ExtensionDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ExtensionDn
    /// </summary>
    [DataMember(Name="ExtensionDn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExtensionDn")]
    public string ExtensionDn { get; set; }

    /// <summary>
    /// Gets or Sets IsLoggedIn
    /// </summary>
    [DataMember(Name="IsLoggedIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsLoggedIn")]
    public bool? IsLoggedIn { get; set; }

    /// <summary>
    /// Gets or Sets PollingAttempts
    /// </summary>
    [DataMember(Name="PollingAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PollingAttempts")]
    public long? PollingAttempts { get; set; }

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
    /// Gets or Sets WaitTime
    /// </summary>
    [DataMember(Name="WaitTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WaitTime")]
    public string WaitTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxAbandonedQueueCalls {\n");
      sb.Append("  CallerId: ").Append(CallerId).Append("\n");
      sb.Append("  CallHistoryId: ").Append(CallHistoryId).Append("\n");
      sb.Append("  CallTime: ").Append(CallTime).Append("\n");
      sb.Append("  CallTimeForCsv: ").Append(CallTimeForCsv).Append("\n");
      sb.Append("  ExtensionDisplayName: ").Append(ExtensionDisplayName).Append("\n");
      sb.Append("  ExtensionDn: ").Append(ExtensionDn).Append("\n");
      sb.Append("  IsLoggedIn: ").Append(IsLoggedIn).Append("\n");
      sb.Append("  PollingAttempts: ").Append(PollingAttempts).Append("\n");
      sb.Append("  QueueDisplayName: ").Append(QueueDisplayName).Append("\n");
      sb.Append("  QueueDn: ").Append(QueueDn).Append("\n");
      sb.Append("  WaitTime: ").Append(WaitTime).Append("\n");
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
