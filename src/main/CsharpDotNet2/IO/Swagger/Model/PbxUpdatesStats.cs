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
  public class PbxUpdatesStats {
    /// <summary>
    /// Gets or Sets PerPage
    /// </summary>
    [DataMember(Name="PerPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PerPage")]
    public List<AllOfPbxUpdatesStatsPerPageItems> PerPage { get; set; }

    /// <summary>
    /// Gets or Sets TcxUpdate
    /// </summary>
    [DataMember(Name="TcxUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TcxUpdate")]
    public List<AllOfPbxUpdatesStatsTcxUpdateItems> TcxUpdate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxUpdatesStats {\n");
      sb.Append("  PerPage: ").Append(PerPage).Append("\n");
      sb.Append("  TcxUpdate: ").Append(TcxUpdate).Append("\n");
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
