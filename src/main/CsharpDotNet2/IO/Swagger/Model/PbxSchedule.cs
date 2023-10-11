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
  public class PbxSchedule {
    /// <summary>
    /// Gets or Sets IgnoreHolidays
    /// </summary>
    [DataMember(Name="IgnoreHolidays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IgnoreHolidays")]
    public bool? IgnoreHolidays { get; set; }

    /// <summary>
    /// Gets or Sets Periods
    /// </summary>
    [DataMember(Name="Periods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Periods")]
    public List<AllOfPbxSchedulePeriodsItems> Periods { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public PbxRuleHoursType Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxSchedule {\n");
      sb.Append("  IgnoreHolidays: ").Append(IgnoreHolidays).Append("\n");
      sb.Append("  Periods: ").Append(Periods).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
