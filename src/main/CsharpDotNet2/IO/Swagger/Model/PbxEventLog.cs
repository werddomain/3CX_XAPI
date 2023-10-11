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
  public class PbxEventLog {
    /// <summary>
    /// Gets or Sets EventId
    /// </summary>
    [DataMember(Name="EventId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventId")]
    public int? EventId { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="Source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Source")]
    public string Source { get; set; }

    /// <summary>
    /// Gets or Sets TimeGenerated
    /// </summary>
    [DataMember(Name="TimeGenerated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeGenerated")]
    public DateTime? TimeGenerated { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public AllOfPbxEventLogType Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxEventLog {\n");
      sb.Append("  EventId: ").Append(EventId).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  TimeGenerated: ").Append(TimeGenerated).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
