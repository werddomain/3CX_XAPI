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
  public class ReportRingGroupStatisticsGetRingGroupStatisticsDataPostRequestBody {
    /// <summary>
    /// Gets or Sets PeriodFrom
    /// </summary>
    [DataMember(Name="periodFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periodFrom")]
    public DateTime? PeriodFrom { get; set; }

    /// <summary>
    /// Gets or Sets PeriodTo
    /// </summary>
    [DataMember(Name="periodTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periodTo")]
    public DateTime? PeriodTo { get; set; }

    /// <summary>
    /// Gets or Sets RingGroupDns
    /// </summary>
    [DataMember(Name="ringGroupDns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ringGroupDns")]
    public string RingGroupDns { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReportRingGroupStatisticsGetRingGroupStatisticsDataPostRequestBody {\n");
      sb.Append("  PeriodFrom: ").Append(PeriodFrom).Append("\n");
      sb.Append("  PeriodTo: ").Append(PeriodTo).Append("\n");
      sb.Append("  RingGroupDns: ").Append(RingGroupDns).Append("\n");
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
