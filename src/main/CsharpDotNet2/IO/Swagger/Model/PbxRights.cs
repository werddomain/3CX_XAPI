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
  public class PbxRights {
    /// <summary>
    /// Gets or Sets AllowIVR
    /// </summary>
    [DataMember(Name="AllowIVR", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowIVR")]
    public bool? AllowIVR { get; set; }

    /// <summary>
    /// Gets or Sets AllowParking
    /// </summary>
    [DataMember(Name="AllowParking", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowParking")]
    public bool? AllowParking { get; set; }

    /// <summary>
    /// Gets or Sets AllowToChangePresence
    /// </summary>
    [DataMember(Name="AllowToChangePresence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowToChangePresence")]
    public bool? AllowToChangePresence { get; set; }

    /// <summary>
    /// Gets or Sets AllowToManageCompanyBook
    /// </summary>
    [DataMember(Name="AllowToManageCompanyBook", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowToManageCompanyBook")]
    public bool? AllowToManageCompanyBook { get; set; }

    /// <summary>
    /// Gets or Sets AssignClearOperations
    /// </summary>
    [DataMember(Name="AssignClearOperations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssignClearOperations")]
    public bool? AssignClearOperations { get; set; }

    /// <summary>
    /// Gets or Sets CanBargeIn
    /// </summary>
    [DataMember(Name="CanBargeIn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanBargeIn")]
    public bool? CanBargeIn { get; set; }

    /// <summary>
    /// Gets or Sets CanIntercom
    /// </summary>
    [DataMember(Name="CanIntercom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanIntercom")]
    public bool? CanIntercom { get; set; }

    /// <summary>
    /// Gets or Sets CanSeeGroupCalls
    /// </summary>
    [DataMember(Name="CanSeeGroupCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanSeeGroupCalls")]
    public bool? CanSeeGroupCalls { get; set; }

    /// <summary>
    /// Gets or Sets CanSeeGroupMembers
    /// </summary>
    [DataMember(Name="CanSeeGroupMembers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanSeeGroupMembers")]
    public bool? CanSeeGroupMembers { get; set; }

    /// <summary>
    /// Gets or Sets CanSeeGroupRecordings
    /// </summary>
    [DataMember(Name="CanSeeGroupRecordings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanSeeGroupRecordings")]
    public bool? CanSeeGroupRecordings { get; set; }

    /// <summary>
    /// Gets or Sets PerformOperations
    /// </summary>
    [DataMember(Name="PerformOperations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PerformOperations")]
    public bool? PerformOperations { get; set; }

    /// <summary>
    /// Gets or Sets RoleName
    /// </summary>
    [DataMember(Name="RoleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleName")]
    public string RoleName { get; set; }

    /// <summary>
    /// Gets or Sets ShowMyCalls
    /// </summary>
    [DataMember(Name="ShowMyCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShowMyCalls")]
    public bool? ShowMyCalls { get; set; }

    /// <summary>
    /// Gets or Sets ShowMyPresence
    /// </summary>
    [DataMember(Name="ShowMyPresence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShowMyPresence")]
    public bool? ShowMyPresence { get; set; }

    /// <summary>
    /// Gets or Sets ShowMyPresenceOutside
    /// </summary>
    [DataMember(Name="ShowMyPresenceOutside", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShowMyPresenceOutside")]
    public bool? ShowMyPresenceOutside { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxRights {\n");
      sb.Append("  AllowIVR: ").Append(AllowIVR).Append("\n");
      sb.Append("  AllowParking: ").Append(AllowParking).Append("\n");
      sb.Append("  AllowToChangePresence: ").Append(AllowToChangePresence).Append("\n");
      sb.Append("  AllowToManageCompanyBook: ").Append(AllowToManageCompanyBook).Append("\n");
      sb.Append("  AssignClearOperations: ").Append(AssignClearOperations).Append("\n");
      sb.Append("  CanBargeIn: ").Append(CanBargeIn).Append("\n");
      sb.Append("  CanIntercom: ").Append(CanIntercom).Append("\n");
      sb.Append("  CanSeeGroupCalls: ").Append(CanSeeGroupCalls).Append("\n");
      sb.Append("  CanSeeGroupMembers: ").Append(CanSeeGroupMembers).Append("\n");
      sb.Append("  CanSeeGroupRecordings: ").Append(CanSeeGroupRecordings).Append("\n");
      sb.Append("  PerformOperations: ").Append(PerformOperations).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  ShowMyCalls: ").Append(ShowMyCalls).Append("\n");
      sb.Append("  ShowMyPresence: ").Append(ShowMyPresence).Append("\n");
      sb.Append("  ShowMyPresenceOutside: ").Append(ShowMyPresenceOutside).Append("\n");
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
