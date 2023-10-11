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
  public class PbxBackupExtras {
    /// <summary>
    /// Gets or Sets Footprint
    /// </summary>
    [DataMember(Name="Footprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Footprint")]
    public long? Footprint { get; set; }

    /// <summary>
    /// Gets or Sets IsEncrypted
    /// </summary>
    [DataMember(Name="IsEncrypted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEncrypted")]
    public bool? IsEncrypted { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxBackupExtras {\n");
      sb.Append("  Footprint: ").Append(Footprint).Append("\n");
      sb.Append("  IsEncrypted: ").Append(IsEncrypted).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
