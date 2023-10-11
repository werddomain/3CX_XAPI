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
  public class PbxQueueAnsweredCallsByWaitTime {
    /// <summary>
    /// Gets or Sets AnsweredTime
    /// </summary>
    [DataMember(Name="AnsweredTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnsweredTime")]
    public DateTime? AnsweredTime { get; set; }

    /// <summary>
    /// Gets or Sets CallTime
    /// </summary>
    [DataMember(Name="CallTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallTime")]
    public DateTime? CallTime { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="Destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Destination")]
    public string Destination { get; set; }

    /// <summary>
    /// Gets or Sets Dn
    /// </summary>
    [DataMember(Name="Dn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Dn")]
    public string Dn { get; set; }

    /// <summary>
    /// Gets or Sets DnNumber
    /// </summary>
    [DataMember(Name="DnNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DnNumber")]
    public string DnNumber { get; set; }

    /// <summary>
    /// Gets or Sets RingTime
    /// </summary>
    [DataMember(Name="RingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingTime")]
    public string RingTime { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="Source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Source")]
    public string Source { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxQueueAnsweredCallsByWaitTime {\n");
      sb.Append("  AnsweredTime: ").Append(AnsweredTime).Append("\n");
      sb.Append("  CallTime: ").Append(CallTime).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Dn: ").Append(Dn).Append("\n");
      sb.Append("  DnNumber: ").Append(DnNumber).Append("\n");
      sb.Append("  RingTime: ").Append(RingTime).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
