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
  public class PbxLicense {
    /// <summary>
    /// Gets or Sets IsMaintainceExpired
    /// </summary>
    [DataMember(Name="IsMaintainceExpired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsMaintainceExpired")]
    public bool? IsMaintainceExpired { get; set; }

    /// <summary>
    /// Gets or Sets ProductCode
    /// </summary>
    [DataMember(Name="ProductCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductCode")]
    public string ProductCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxLicense {\n");
      sb.Append("  IsMaintainceExpired: ").Append(IsMaintainceExpired).Append("\n");
      sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
