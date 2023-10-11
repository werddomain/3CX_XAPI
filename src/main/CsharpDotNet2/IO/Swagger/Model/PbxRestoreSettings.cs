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
  public class PbxRestoreSettings {
    /// <summary>
    /// Gets or Sets EncryptBackup
    /// </summary>
    [DataMember(Name="EncryptBackup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EncryptBackup")]
    public bool? EncryptBackup { get; set; }

    /// <summary>
    /// Gets or Sets EncryptBackupPassword
    /// </summary>
    [DataMember(Name="EncryptBackupPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EncryptBackupPassword")]
    public string EncryptBackupPassword { get; set; }

    /// <summary>
    /// Gets or Sets NotRestart
    /// </summary>
    [DataMember(Name="NotRestart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotRestart")]
    public bool? NotRestart { get; set; }

    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [DataMember(Name="Schedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Schedule")]
    public AllOfPbxRestoreSettingsSchedule Schedule { get; set; }

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
      sb.Append("class PbxRestoreSettings {\n");
      sb.Append("  EncryptBackup: ").Append(EncryptBackup).Append("\n");
      sb.Append("  EncryptBackupPassword: ").Append(EncryptBackupPassword).Append("\n");
      sb.Append("  NotRestart: ").Append(NotRestart).Append("\n");
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
