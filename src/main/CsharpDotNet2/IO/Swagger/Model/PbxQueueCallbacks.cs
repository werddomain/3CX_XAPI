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
  public class PbxQueueCallbacks {
    /// <summary>
    /// Gets or Sets CallbacksCount
    /// </summary>
    [DataMember(Name="CallbacksCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallbacksCount")]
    public long? CallbacksCount { get; set; }

    /// <summary>
    /// Gets or Sets Dn
    /// </summary>
    [DataMember(Name="Dn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Dn")]
    public string Dn { get; set; }

    /// <summary>
    /// Gets or Sets FailCallbacksCount
    /// </summary>
    [DataMember(Name="FailCallbacksCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailCallbacksCount")]
    public long? FailCallbacksCount { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxQueueCallbacks {\n");
      sb.Append("  CallbacksCount: ").Append(CallbacksCount).Append("\n");
      sb.Append("  Dn: ").Append(Dn).Append("\n");
      sb.Append("  FailCallbacksCount: ").Append(FailCallbacksCount).Append("\n");
      sb.Append("  QueueDnNumber: ").Append(QueueDnNumber).Append("\n");
      sb.Append("  ReceivedCount: ").Append(ReceivedCount).Append("\n");
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
