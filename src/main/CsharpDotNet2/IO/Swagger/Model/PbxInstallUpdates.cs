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
  public class PbxInstallUpdates {
    /// <summary>
    /// Gets or Sets Entries
    /// </summary>
    [DataMember(Name="Entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Entries")]
    public List<Guid?> Entries { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="Key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Key")]
    public Guid? Key { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxInstallUpdates {\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
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
