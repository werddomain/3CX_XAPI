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
  public class PbxRecordingRepositorySettings {
    /// <summary>
    /// Gets or Sets IsRecordingArchiveEnabled
    /// </summary>
    [DataMember(Name="IsRecordingArchiveEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRecordingArchiveEnabled")]
    public bool? IsRecordingArchiveEnabled { get; set; }

    /// <summary>
    /// Gets or Sets IsScheduleForCleanupEnabled
    /// </summary>
    [DataMember(Name="IsScheduleForCleanupEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsScheduleForCleanupEnabled")]
    public bool? IsScheduleForCleanupEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="Location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Location")]
    public AllOfPbxRecordingRepositorySettingsLocation Location { get; set; }

    /// <summary>
    /// Gets or Sets RecordingArchiveSchedule
    /// </summary>
    [DataMember(Name="RecordingArchiveSchedule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingArchiveSchedule")]
    public AllOfPbxRecordingRepositorySettingsRecordingArchiveSchedule RecordingArchiveSchedule { get; set; }

    /// <summary>
    /// Gets or Sets RecordingPath
    /// </summary>
    [DataMember(Name="RecordingPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingPath")]
    public string RecordingPath { get; set; }

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
      sb.Append("class PbxRecordingRepositorySettings {\n");
      sb.Append("  IsRecordingArchiveEnabled: ").Append(IsRecordingArchiveEnabled).Append("\n");
      sb.Append("  IsScheduleForCleanupEnabled: ").Append(IsScheduleForCleanupEnabled).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  RecordingArchiveSchedule: ").Append(RecordingArchiveSchedule).Append("\n");
      sb.Append("  RecordingPath: ").Append(RecordingPath).Append("\n");
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
