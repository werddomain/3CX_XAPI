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
  public class PbxRegistrarFxs {
    /// <summary>
    /// Gets or Sets InterfaceLink
    /// </summary>
    [DataMember(Name="InterfaceLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InterfaceLink")]
    public string InterfaceLink { get; set; }

    /// <summary>
    /// Gets or Sets MacAddress
    /// </summary>
    [DataMember(Name="MacAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MacAddress")]
    public string MacAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxRegistrarFxs {\n");
      sb.Append("  InterfaceLink: ").Append(InterfaceLink).Append("\n");
      sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
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
