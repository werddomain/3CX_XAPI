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
  public class PbxPeriod {
    /// <summary>
    /// Gets or Sets DayOfWeek
    /// </summary>
    [DataMember(Name="DayOfWeek", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DayOfWeek")]
    public AllOfPbxPeriodDayOfWeek DayOfWeek { get; set; }

    /// <summary>
    /// Gets or Sets Start
    /// </summary>
    [DataMember(Name="Start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Start")]
    public string Start { get; set; }

    /// <summary>
    /// Gets or Sets Stop
    /// </summary>
    [DataMember(Name="Stop", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Stop")]
    public string Stop { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxPeriod {\n");
      sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  Stop: ").Append(Stop).Append("\n");
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
