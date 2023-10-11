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
  public class PbxRecordingSettings {
    /// <summary>
    /// Gets or Sets AutoDeleteRecordingDays
    /// </summary>
    [DataMember(Name="AutoDeleteRecordingDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoDeleteRecordingDays")]
    public int? AutoDeleteRecordingDays { get; set; }

    /// <summary>
    /// Gets or Sets AutoDeleteRecordingEnabled
    /// </summary>
    [DataMember(Name="AutoDeleteRecordingEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoDeleteRecordingEnabled")]
    public bool? AutoDeleteRecordingEnabled { get; set; }

    /// <summary>
    /// Gets or Sets CallRecordingCompression
    /// </summary>
    [DataMember(Name="CallRecordingCompression", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallRecordingCompression")]
    public bool? CallRecordingCompression { get; set; }

    /// <summary>
    /// Gets or Sets EmailWhenQuotaReachedEnabled
    /// </summary>
    [DataMember(Name="EmailWhenQuotaReachedEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailWhenQuotaReachedEnabled")]
    public bool? EmailWhenQuotaReachedEnabled { get; set; }

    /// <summary>
    /// Gets or Sets EmailWhenQuotaReachedPercent
    /// </summary>
    [DataMember(Name="EmailWhenQuotaReachedPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailWhenQuotaReachedPercent")]
    public int? EmailWhenQuotaReachedPercent { get; set; }

    /// <summary>
    /// Gets or Sets IsScheduleForArchiveEnabled
    /// </summary>
    [DataMember(Name="IsScheduleForArchiveEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsScheduleForArchiveEnabled")]
    public bool? IsScheduleForArchiveEnabled { get; set; }

    /// <summary>
    /// Gets or Sets RecordingDiskSpace
    /// </summary>
    [DataMember(Name="RecordingDiskSpace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingDiskSpace")]
    public int? RecordingDiskSpace { get; set; }

    /// <summary>
    /// Gets or Sets RecordingsQuota
    /// </summary>
    [DataMember(Name="RecordingsQuota", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingsQuota")]
    public int? RecordingsQuota { get; set; }

    /// <summary>
    /// Gets or Sets RecordingUsedSpace
    /// </summary>
    [DataMember(Name="RecordingUsedSpace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingUsedSpace")]
    public long? RecordingUsedSpace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxRecordingSettings {\n");
      sb.Append("  AutoDeleteRecordingDays: ").Append(AutoDeleteRecordingDays).Append("\n");
      sb.Append("  AutoDeleteRecordingEnabled: ").Append(AutoDeleteRecordingEnabled).Append("\n");
      sb.Append("  CallRecordingCompression: ").Append(CallRecordingCompression).Append("\n");
      sb.Append("  EmailWhenQuotaReachedEnabled: ").Append(EmailWhenQuotaReachedEnabled).Append("\n");
      sb.Append("  EmailWhenQuotaReachedPercent: ").Append(EmailWhenQuotaReachedPercent).Append("\n");
      sb.Append("  IsScheduleForArchiveEnabled: ").Append(IsScheduleForArchiveEnabled).Append("\n");
      sb.Append("  RecordingDiskSpace: ").Append(RecordingDiskSpace).Append("\n");
      sb.Append("  RecordingsQuota: ").Append(RecordingsQuota).Append("\n");
      sb.Append("  RecordingUsedSpace: ").Append(RecordingUsedSpace).Append("\n");
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
