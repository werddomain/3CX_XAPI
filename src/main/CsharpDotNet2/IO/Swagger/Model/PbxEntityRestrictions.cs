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
  public class PbxEntityRestrictions {
    /// <summary>
    /// Gets or Sets Allowed
    /// </summary>
    [DataMember(Name="Allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Allowed")]
    public int? Allowed { get; set; }

    /// <summary>
    /// Gets or Sets Unlimited
    /// </summary>
    [DataMember(Name="Unlimited", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Unlimited")]
    public bool? Unlimited { get; set; }

    /// <summary>
    /// Gets or Sets Used
    /// </summary>
    [DataMember(Name="Used", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Used")]
    public int? Used { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxEntityRestrictions {\n");
      sb.Append("  Allowed: ").Append(Allowed).Append("\n");
      sb.Append("  Unlimited: ").Append(Unlimited).Append("\n");
      sb.Append("  Used: ").Append(Used).Append("\n");
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
