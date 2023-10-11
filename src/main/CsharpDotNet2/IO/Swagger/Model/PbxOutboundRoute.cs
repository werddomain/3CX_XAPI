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
  public class PbxOutboundRoute {
    /// <summary>
    /// Gets or Sets Append
    /// </summary>
    [DataMember(Name="Append", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Append")]
    public string Append { get; set; }

    /// <summary>
    /// Gets or Sets CallerID
    /// </summary>
    [DataMember(Name="CallerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallerID")]
    public string CallerID { get; set; }

    /// <summary>
    /// Gets or Sets Prepend
    /// </summary>
    [DataMember(Name="Prepend", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Prepend")]
    public string Prepend { get; set; }

    /// <summary>
    /// Gets or Sets StripDigits
    /// </summary>
    [DataMember(Name="StripDigits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StripDigits")]
    public int? StripDigits { get; set; }

    /// <summary>
    /// Gets or Sets TrunkId
    /// </summary>
    [DataMember(Name="TrunkId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TrunkId")]
    public int? TrunkId { get; set; }

    /// <summary>
    /// Gets or Sets TrunkName
    /// </summary>
    [DataMember(Name="TrunkName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TrunkName")]
    public string TrunkName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxOutboundRoute {\n");
      sb.Append("  Append: ").Append(Append).Append("\n");
      sb.Append("  CallerID: ").Append(CallerID).Append("\n");
      sb.Append("  Prepend: ").Append(Prepend).Append("\n");
      sb.Append("  StripDigits: ").Append(StripDigits).Append("\n");
      sb.Append("  TrunkId: ").Append(TrunkId).Append("\n");
      sb.Append("  TrunkName: ").Append(TrunkName).Append("\n");
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
