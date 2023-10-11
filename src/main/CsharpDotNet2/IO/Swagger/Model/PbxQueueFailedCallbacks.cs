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
  public class PbxQueueFailedCallbacks {
    /// <summary>
    /// Gets or Sets CallbackNo
    /// </summary>
    [DataMember(Name="CallbackNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallbackNo")]
    public string CallbackNo { get; set; }

    /// <summary>
    /// Gets or Sets CallTime
    /// </summary>
    [DataMember(Name="CallTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallTime")]
    public DateTime? CallTime { get; set; }

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
    /// Gets or Sets RingTime
    /// </summary>
    [DataMember(Name="RingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingTime")]
    public string RingTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxQueueFailedCallbacks {\n");
      sb.Append("  CallbackNo: ").Append(CallbackNo).Append("\n");
      sb.Append("  CallTime: ").Append(CallTime).Append("\n");
      sb.Append("  Dn: ").Append(Dn).Append("\n");
      sb.Append("  QueueDnNumber: ").Append(QueueDnNumber).Append("\n");
      sb.Append("  RingTime: ").Append(RingTime).Append("\n");
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
