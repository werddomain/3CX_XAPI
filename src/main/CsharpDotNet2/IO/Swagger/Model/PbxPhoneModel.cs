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
  public class PbxPhoneModel {
    /// <summary>
    /// Gets or Sets AddAllowed
    /// </summary>
    [DataMember(Name="AddAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AddAllowed")]
    public bool? AddAllowed { get; set; }

    /// <summary>
    /// Gets or Sets CanBeSBC
    /// </summary>
    [DataMember(Name="CanBeSBC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanBeSBC")]
    public bool? CanBeSBC { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets URL
    /// </summary>
    [DataMember(Name="URL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "URL")]
    public string URL { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxPhoneModel {\n");
      sb.Append("  AddAllowed: ").Append(AddAllowed).Append("\n");
      sb.Append("  CanBeSBC: ").Append(CanBeSBC).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  URL: ").Append(URL).Append("\n");
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
