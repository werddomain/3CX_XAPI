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
  public class PbxUpdateSettings {
    /// <summary>
    /// Gets or Sets AutoUpdateEnabled
    /// </summary>
    [DataMember(Name="AutoUpdateEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoUpdateEnabled")]
    public bool? AutoUpdateEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [DataMember(Name="Schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Schedule")]
    public AllOfPbxUpdateSettingsSchedule Schedule { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxUpdateSettings {\n");
      sb.Append("  AutoUpdateEnabled: ").Append(AutoUpdateEnabled).Append("\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
