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
  public class PbxBackupSchedule {
    /// <summary>
    /// Gets or Sets Day
    /// </summary>
    [DataMember(Name="Day", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Day")]
    public AllOfPbxBackupScheduleDay Day { get; set; }

    /// <summary>
    /// Gets or Sets ScheduleType
    /// </summary>
    [DataMember(Name="ScheduleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduleType")]
    public AllOfPbxBackupScheduleScheduleType ScheduleType { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="Time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Time")]
    public string Time { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxBackupSchedule {\n");
      sb.Append("  Day: ").Append(Day).Append("\n");
      sb.Append("  ScheduleType: ").Append(ScheduleType).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
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
