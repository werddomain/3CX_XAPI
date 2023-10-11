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
  public class PbxExtensionRule {
    /// <summary>
    /// Gets or Sets CallerId
    /// </summary>
    [DataMember(Name="CallerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallerId")]
    public string CallerId { get; set; }

    /// <summary>
    /// Gets or Sets Destination
    /// </summary>
    [DataMember(Name="Destination", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Destination")]
    public AllOfPbxExtensionRuleDestination Destination { get; set; }

    /// <summary>
    /// Gets or Sets Hours
    /// </summary>
    [DataMember(Name="Hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hours")]
    public AllOfPbxExtensionRuleHours Hours { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxExtensionRule {\n");
      sb.Append("  CallerId: ").Append(CallerId).Append("\n");
      sb.Append("  Destination: ").Append(Destination).Append("\n");
      sb.Append("  Hours: ").Append(Hours).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
