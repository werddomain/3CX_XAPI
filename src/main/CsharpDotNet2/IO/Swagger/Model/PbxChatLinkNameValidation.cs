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
  public class PbxChatLinkNameValidation {
    /// <summary>
    /// Gets or Sets FriendlyName
    /// </summary>
    [DataMember(Name="FriendlyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FriendlyName")]
    public string FriendlyName { get; set; }

    /// <summary>
    /// Gets or Sets Pair
    /// </summary>
    [DataMember(Name="Pair", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Pair")]
    public string Pair { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxChatLinkNameValidation {\n");
      sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
      sb.Append("  Pair: ").Append(Pair).Append("\n");
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
