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
  public class PbxHoliday {
    /// <summary>
    /// Gets or Sets Day
    /// </summary>
    [DataMember(Name="Day", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Day")]
    public int? Day { get; set; }

    /// <summary>
    /// Gets or Sets DayEnd
    /// </summary>
    [DataMember(Name="DayEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DayEnd")]
    public int? DayEnd { get; set; }

    /// <summary>
    /// Gets or Sets HolidayPrompt
    /// </summary>
    [DataMember(Name="HolidayPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HolidayPrompt")]
    public string HolidayPrompt { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets IsRecurrent
    /// </summary>
    [DataMember(Name="IsRecurrent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRecurrent")]
    public bool? IsRecurrent { get; set; }

    /// <summary>
    /// Gets or Sets Month
    /// </summary>
    [DataMember(Name="Month", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Month")]
    public int? Month { get; set; }

    /// <summary>
    /// Gets or Sets MonthEnd
    /// </summary>
    [DataMember(Name="MonthEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MonthEnd")]
    public int? MonthEnd { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets TimeOfEndDate
    /// </summary>
    [DataMember(Name="TimeOfEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeOfEndDate")]
    public string TimeOfEndDate { get; set; }

    /// <summary>
    /// Gets or Sets TimeOfStartDate
    /// </summary>
    [DataMember(Name="TimeOfStartDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeOfStartDate")]
    public string TimeOfStartDate { get; set; }

    /// <summary>
    /// Gets or Sets Year
    /// </summary>
    [DataMember(Name="Year", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Year")]
    public int? Year { get; set; }

    /// <summary>
    /// Gets or Sets YearEnd
    /// </summary>
    [DataMember(Name="YearEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "YearEnd")]
    public int? YearEnd { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxHoliday {\n");
      sb.Append("  Day: ").Append(Day).Append("\n");
      sb.Append("  DayEnd: ").Append(DayEnd).Append("\n");
      sb.Append("  HolidayPrompt: ").Append(HolidayPrompt).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsRecurrent: ").Append(IsRecurrent).Append("\n");
      sb.Append("  Month: ").Append(Month).Append("\n");
      sb.Append("  MonthEnd: ").Append(MonthEnd).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  TimeOfEndDate: ").Append(TimeOfEndDate).Append("\n");
      sb.Append("  TimeOfStartDate: ").Append(TimeOfStartDate).Append("\n");
      sb.Append("  Year: ").Append(Year).Append("\n");
      sb.Append("  YearEnd: ").Append(YearEnd).Append("\n");
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
