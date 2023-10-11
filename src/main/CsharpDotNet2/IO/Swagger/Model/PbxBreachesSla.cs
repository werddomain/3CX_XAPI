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
  public class PbxBreachesSla {
    /// <summary>
    /// Gets or Sets CallerId
    /// </summary>
    [DataMember(Name="CallerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallerId")]
    public string CallerId { get; set; }

    /// <summary>
    /// Gets or Sets CallTime
    /// </summary>
    [DataMember(Name="CallTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallTime")]
    public DateTime? CallTime { get; set; }

    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [DataMember(Name="Queue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Queue")]
    public string Queue { get; set; }

    /// <summary>
    /// Gets or Sets QueueDnNumber
    /// </summary>
    [DataMember(Name="QueueDnNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDnNumber")]
    public string QueueDnNumber { get; set; }

    /// <summary>
    /// Gets or Sets WaitingTime
    /// </summary>
    [DataMember(Name="WaitingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WaitingTime")]
    public string WaitingTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxBreachesSla {\n");
      sb.Append("  CallerId: ").Append(CallerId).Append("\n");
      sb.Append("  CallTime: ").Append(CallTime).Append("\n");
      sb.Append("  Queue: ").Append(Queue).Append("\n");
      sb.Append("  QueueDnNumber: ").Append(QueueDnNumber).Append("\n");
      sb.Append("  WaitingTime: ").Append(WaitingTime).Append("\n");
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
