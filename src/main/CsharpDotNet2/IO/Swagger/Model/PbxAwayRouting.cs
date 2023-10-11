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
  public class PbxAwayRouting {
    /// <summary>
    /// Gets or Sets AllHoursExternal
    /// </summary>
    [DataMember(Name="AllHoursExternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllHoursExternal")]
    public bool? AllHoursExternal { get; set; }

    /// <summary>
    /// Gets or Sets AllHoursInternal
    /// </summary>
    [DataMember(Name="AllHoursInternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllHoursInternal")]
    public bool? AllHoursInternal { get; set; }

    /// <summary>
    /// Gets or Sets External
    /// </summary>
    [DataMember(Name="External", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "External")]
    public AllOfPbxAwayRoutingExternal External { get; set; }

    /// <summary>
    /// Gets or Sets _Internal
    /// </summary>
    [DataMember(Name="Internal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Internal")]
    public AllOfPbxAwayRoutingInternal _Internal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxAwayRouting {\n");
      sb.Append("  AllHoursExternal: ").Append(AllHoursExternal).Append("\n");
      sb.Append("  AllHoursInternal: ").Append(AllHoursInternal).Append("\n");
      sb.Append("  External: ").Append(External).Append("\n");
      sb.Append("  _Internal: ").Append(_Internal).Append("\n");
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
