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
  public class PbxBackupSettings {
    /// <summary>
    /// Gets or Sets Contents
    /// </summary>
    [DataMember(Name="Contents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Contents")]
    public AllOfPbxBackupSettingsContents Contents { get; set; }

    /// <summary>
    /// Gets or Sets Rotation
    /// </summary>
    [DataMember(Name="Rotation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Rotation")]
    public int? Rotation { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [DataMember(Name="Schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Schedule")]
    public AllOfPbxBackupSettingsSchedule Schedule { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleEnabled
    /// </summary>
    [DataMember(Name="ScheduleEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduleEnabled")]
    public bool? ScheduleEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxBackupSettings {\n");
      sb.Append("  Contents: ").Append(Contents).Append("\n");
      sb.Append("  Rotation: ").Append(Rotation).Append("\n");
      sb.Append("  Schedule: ").Append(Schedule).Append("\n");
      sb.Append("  ScheduleEnabled: ").Append(ScheduleEnabled).Append("\n");
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
