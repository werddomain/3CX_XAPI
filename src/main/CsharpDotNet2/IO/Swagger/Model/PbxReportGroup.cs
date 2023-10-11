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
  public class PbxReportGroup {
    /// <summary>
    /// Gets or Sets GroupID
    /// </summary>
    [DataMember(Name="GroupID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupID")]
    public int? GroupID { get; set; }

    /// <summary>
    /// Gets or Sets GroupName
    /// </summary>
    [DataMember(Name="GroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupName")]
    public string GroupName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxReportGroup {\n");
      sb.Append("  GroupID: ").Append(GroupID).Append("\n");
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
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
