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
  public class PbxSetRoute {
    /// <summary>
    /// Gets or Sets DID
    /// </summary>
    [DataMember(Name="DID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DID")]
    public string DID { get; set; }

    /// <summary>
    /// Gets or Sets TrunkId
    /// </summary>
    [DataMember(Name="TrunkId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TrunkId")]
    public int? TrunkId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxSetRoute {\n");
      sb.Append("  DID: ").Append(DID).Append("\n");
      sb.Append("  TrunkId: ").Append(TrunkId).Append("\n");
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
