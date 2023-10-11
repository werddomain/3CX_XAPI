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
  public class PbxInboundRule {
    /// <summary>
    /// Gets or Sets AlterDestinationDuringHolidays
    /// </summary>
    [DataMember(Name="AlterDestinationDuringHolidays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlterDestinationDuringHolidays")]
    public bool? AlterDestinationDuringHolidays { get; set; }

    /// <summary>
    /// Gets or Sets AlterDestinationDuringOutOfOfficeHours
    /// </summary>
    [DataMember(Name="AlterDestinationDuringOutOfOfficeHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AlterDestinationDuringOutOfOfficeHours")]
    public bool? AlterDestinationDuringOutOfOfficeHours { get; set; }

    /// <summary>
    /// Gets or Sets CallType
    /// </summary>
    [DataMember(Name="CallType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallType")]
    public PbxRuleCallTypeType CallType { get; set; }

    /// <summary>
    /// Gets or Sets Condition
    /// </summary>
    [DataMember(Name="Condition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Condition")]
    public PbxRuleConditionType Condition { get; set; }

    /// <summary>
    /// Gets or Sets CustomData
    /// </summary>
    [DataMember(Name="CustomData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomData")]
    public string CustomData { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="Data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Data")]
    public string Data { get; set; }

    /// <summary>
    /// Gets or Sets HolidaysDestination
    /// </summary>
    [DataMember(Name="HolidaysDestination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HolidaysDestination")]
    public AllOfPbxInboundRuleHolidaysDestination HolidaysDestination { get; set; }

    /// <summary>
    /// Gets or Sets Hours
    /// </summary>
    [DataMember(Name="Hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hours")]
    public AllOfPbxInboundRuleHours Hours { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets OfficeHoursDestination
    /// </summary>
    [DataMember(Name="OfficeHoursDestination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfficeHoursDestination")]
    public PbxDestination OfficeHoursDestination { get; set; }

    /// <summary>
    /// Gets or Sets OutOfOfficeHoursDestination
    /// </summary>
    [DataMember(Name="OutOfOfficeHoursDestination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutOfOfficeHoursDestination")]
    public PbxDestination OutOfOfficeHoursDestination { get; set; }

    /// <summary>
    /// Gets or Sets RuleName
    /// </summary>
    [DataMember(Name="RuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RuleName")]
    public string RuleName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxInboundRule {\n");
      sb.Append("  AlterDestinationDuringHolidays: ").Append(AlterDestinationDuringHolidays).Append("\n");
      sb.Append("  AlterDestinationDuringOutOfOfficeHours: ").Append(AlterDestinationDuringOutOfOfficeHours).Append("\n");
      sb.Append("  CallType: ").Append(CallType).Append("\n");
      sb.Append("  Condition: ").Append(Condition).Append("\n");
      sb.Append("  CustomData: ").Append(CustomData).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  HolidaysDestination: ").Append(HolidaysDestination).Append("\n");
      sb.Append("  Hours: ").Append(Hours).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OfficeHoursDestination: ").Append(OfficeHoursDestination).Append("\n");
      sb.Append("  OutOfOfficeHoursDestination: ").Append(OutOfOfficeHoursDestination).Append("\n");
      sb.Append("  RuleName: ").Append(RuleName).Append("\n");
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
