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
  public class PbxGroup {
    /// <summary>
    /// Gets or Sets AllowCallService
    /// </summary>
    [DataMember(Name="AllowCallService", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowCallService")]
    public bool? AllowCallService { get; set; }

    /// <summary>
    /// Gets or Sets AnswerAfter
    /// </summary>
    [DataMember(Name="AnswerAfter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnswerAfter")]
    public int? AnswerAfter { get; set; }

    /// <summary>
    /// Gets or Sets BreakTime
    /// </summary>
    [DataMember(Name="BreakTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BreakTime")]
    public AllOfPbxGroupBreakTime BreakTime { get; set; }

    /// <summary>
    /// Gets or Sets BreakTimeOperator
    /// </summary>
    [DataMember(Name="BreakTimeOperator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BreakTimeOperator")]
    public AllOfPbxGroupBreakTimeOperator BreakTimeOperator { get; set; }

    /// <summary>
    /// Gets or Sets BreakTimePrompt
    /// </summary>
    [DataMember(Name="BreakTimePrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BreakTimePrompt")]
    public string BreakTimePrompt { get; set; }

    /// <summary>
    /// Gets or Sets CallHandlingMode
    /// </summary>
    [DataMember(Name="CallHandlingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallHandlingMode")]
    public List<PbxCallHandlingFlags> CallHandlingMode { get; set; }

    /// <summary>
    /// Gets or Sets CallUsRequirement
    /// </summary>
    [DataMember(Name="CallUsRequirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsRequirement")]
    public AllOfPbxGroupCallUsRequirement CallUsRequirement { get; set; }

    /// <summary>
    /// Gets or Sets ClosedHoursOperator
    /// </summary>
    [DataMember(Name="ClosedHoursOperator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClosedHoursOperator")]
    public AllOfPbxGroupClosedHoursOperator ClosedHoursOperator { get; set; }

    /// <summary>
    /// Gets or Sets ClosedHoursPrompt
    /// </summary>
    [DataMember(Name="ClosedHoursPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClosedHoursPrompt")]
    public string ClosedHoursPrompt { get; set; }

    /// <summary>
    /// Gets or Sets CurrentGroupHours
    /// </summary>
    [DataMember(Name="CurrentGroupHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentGroupHours")]
    public AllOfPbxGroupCurrentGroupHours CurrentGroupHours { get; set; }

    /// <summary>
    /// Gets or Sets CustomOperator
    /// </summary>
    [DataMember(Name="CustomOperator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomOperator")]
    public AllOfPbxGroupCustomOperator CustomOperator { get; set; }

    /// <summary>
    /// Gets or Sets CustomPrompt
    /// </summary>
    [DataMember(Name="CustomPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomPrompt")]
    public string CustomPrompt { get; set; }

    /// <summary>
    /// Gets or Sets DisableBreakTimePrompt
    /// </summary>
    [DataMember(Name="DisableBreakTimePrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisableBreakTimePrompt")]
    public bool? DisableBreakTimePrompt { get; set; }

    /// <summary>
    /// Gets or Sets DisableClosedHoursPrompt
    /// </summary>
    [DataMember(Name="DisableClosedHoursPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisableClosedHoursPrompt")]
    public bool? DisableClosedHoursPrompt { get; set; }

    /// <summary>
    /// Gets or Sets DisableCustomPrompt
    /// </summary>
    [DataMember(Name="DisableCustomPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisableCustomPrompt")]
    public bool? DisableCustomPrompt { get; set; }

    /// <summary>
    /// Gets or Sets DisableOpenedHoursPrompt
    /// </summary>
    [DataMember(Name="DisableOpenedHoursPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisableOpenedHoursPrompt")]
    public bool? DisableOpenedHoursPrompt { get; set; }

    /// <summary>
    /// Gets or Sets GloballyVisible
    /// </summary>
    [DataMember(Name="GloballyVisible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GloballyVisible")]
    public bool? GloballyVisible { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="Groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups")]
    public List<PbxUserGroup> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Hours
    /// </summary>
    [DataMember(Name="Hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hours")]
    public AllOfPbxGroupHours Hours { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets IsDefault
    /// </summary>
    [DataMember(Name="IsDefault", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="Language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets LastLoginTime
    /// </summary>
    [DataMember(Name="LastLoginTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastLoginTime")]
    public DateTime? LastLoginTime { get; set; }

    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name="Members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Members")]
    public List<PbxUserGroup> Members { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets OfficeHolidays
    /// </summary>
    [DataMember(Name="OfficeHolidays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfficeHolidays")]
    public List<PbxHoliday> OfficeHolidays { get; set; }

    /// <summary>
    /// Gets or Sets OpenedHoursOperator
    /// </summary>
    [DataMember(Name="OpenedHoursOperator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpenedHoursOperator")]
    public AllOfPbxGroupOpenedHoursOperator OpenedHoursOperator { get; set; }

    /// <summary>
    /// Gets or Sets OpenedHoursPrompt
    /// </summary>
    [DataMember(Name="OpenedHoursPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OpenedHoursPrompt")]
    public string OpenedHoursPrompt { get; set; }

    /// <summary>
    /// Gets or Sets OverrideExpiresAt
    /// </summary>
    [DataMember(Name="OverrideExpiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverrideExpiresAt")]
    public DateTime? OverrideExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets OverrideHolidays
    /// </summary>
    [DataMember(Name="OverrideHolidays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OverrideHolidays")]
    public bool? OverrideHolidays { get; set; }

    /// <summary>
    /// Gets or Sets PromptSet
    /// </summary>
    [DataMember(Name="PromptSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptSet")]
    public string PromptSet { get; set; }

    /// <summary>
    /// Gets or Sets Props
    /// </summary>
    [DataMember(Name="Props", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Props")]
    public AllOfPbxGroupProps Props { get; set; }

    /// <summary>
    /// Gets or Sets Rights
    /// </summary>
    [DataMember(Name="Rights", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Rights")]
    public List<PbxRights> Rights { get; set; }

    /// <summary>
    /// Gets or Sets TimeZoneId
    /// </summary>
    [DataMember(Name="TimeZoneId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZoneId")]
    public string TimeZoneId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxGroup {\n");
      sb.Append("  AllowCallService: ").Append(AllowCallService).Append("\n");
      sb.Append("  AnswerAfter: ").Append(AnswerAfter).Append("\n");
      sb.Append("  BreakTime: ").Append(BreakTime).Append("\n");
      sb.Append("  BreakTimeOperator: ").Append(BreakTimeOperator).Append("\n");
      sb.Append("  BreakTimePrompt: ").Append(BreakTimePrompt).Append("\n");
      sb.Append("  CallHandlingMode: ").Append(CallHandlingMode).Append("\n");
      sb.Append("  CallUsRequirement: ").Append(CallUsRequirement).Append("\n");
      sb.Append("  ClosedHoursOperator: ").Append(ClosedHoursOperator).Append("\n");
      sb.Append("  ClosedHoursPrompt: ").Append(ClosedHoursPrompt).Append("\n");
      sb.Append("  CurrentGroupHours: ").Append(CurrentGroupHours).Append("\n");
      sb.Append("  CustomOperator: ").Append(CustomOperator).Append("\n");
      sb.Append("  CustomPrompt: ").Append(CustomPrompt).Append("\n");
      sb.Append("  DisableBreakTimePrompt: ").Append(DisableBreakTimePrompt).Append("\n");
      sb.Append("  DisableClosedHoursPrompt: ").Append(DisableClosedHoursPrompt).Append("\n");
      sb.Append("  DisableCustomPrompt: ").Append(DisableCustomPrompt).Append("\n");
      sb.Append("  DisableOpenedHoursPrompt: ").Append(DisableOpenedHoursPrompt).Append("\n");
      sb.Append("  GloballyVisible: ").Append(GloballyVisible).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Hours: ").Append(Hours).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  LastLoginTime: ").Append(LastLoginTime).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  OfficeHolidays: ").Append(OfficeHolidays).Append("\n");
      sb.Append("  OpenedHoursOperator: ").Append(OpenedHoursOperator).Append("\n");
      sb.Append("  OpenedHoursPrompt: ").Append(OpenedHoursPrompt).Append("\n");
      sb.Append("  OverrideExpiresAt: ").Append(OverrideExpiresAt).Append("\n");
      sb.Append("  OverrideHolidays: ").Append(OverrideHolidays).Append("\n");
      sb.Append("  PromptSet: ").Append(PromptSet).Append("\n");
      sb.Append("  Props: ").Append(Props).Append("\n");
      sb.Append("  Rights: ").Append(Rights).Append("\n");
      sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
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
