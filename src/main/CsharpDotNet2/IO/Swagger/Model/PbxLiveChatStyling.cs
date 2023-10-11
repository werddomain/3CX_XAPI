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
  public class PbxLiveChatStyling {
    /// <summary>
    /// Gets or Sets Animation
    /// </summary>
    [DataMember(Name="Animation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Animation")]
    public AllOfPbxLiveChatStylingAnimation Animation { get; set; }

    /// <summary>
    /// Gets or Sets Minimized
    /// </summary>
    [DataMember(Name="Minimized", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Minimized")]
    public bool? Minimized { get; set; }

    /// <summary>
    /// Gets or Sets Style
    /// </summary>
    [DataMember(Name="Style", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Style")]
    public string Style { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxLiveChatStyling {\n");
      sb.Append("  Animation: ").Append(Animation).Append("\n");
      sb.Append("  Minimized: ").Append(Minimized).Append("\n");
      sb.Append("  Style: ").Append(Style).Append("\n");
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
