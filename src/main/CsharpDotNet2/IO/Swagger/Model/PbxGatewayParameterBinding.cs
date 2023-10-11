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
  public class PbxGatewayParameterBinding {
    /// <summary>
    /// Gets or Sets Custom
    /// </summary>
    [DataMember(Name="Custom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Custom")]
    public string Custom { get; set; }

    /// <summary>
    /// Gets or Sets ParamId
    /// </summary>
    [DataMember(Name="ParamId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParamId")]
    public int? ParamId { get; set; }

    /// <summary>
    /// Gets or Sets ValueId
    /// </summary>
    [DataMember(Name="ValueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ValueId")]
    public int? ValueId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxGatewayParameterBinding {\n");
      sb.Append("  Custom: ").Append(Custom).Append("\n");
      sb.Append("  ParamId: ").Append(ParamId).Append("\n");
      sb.Append("  ValueId: ").Append(ValueId).Append("\n");
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
