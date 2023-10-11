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
  public class UpgradePhoneRequestBody {
    /// <summary>
    /// Gets or Sets Mac
    /// </summary>
    [DataMember(Name="mac", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mac")]
    public string Mac { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// Gets or Sets Useragent
    /// </summary>
    [DataMember(Name="useragent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "useragent")]
    public string Useragent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpgradePhoneRequestBody {\n");
      sb.Append("  Mac: ").Append(Mac).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Useragent: ").Append(Useragent).Append("\n");
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
