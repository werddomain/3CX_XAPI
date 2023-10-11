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
  public class PbxBackup {
    /// <summary>
    /// Gets or Sets CreationTime
    /// </summary>
    [DataMember(Name="CreationTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Gets or Sets DownloadLink
    /// </summary>
    [DataMember(Name="DownloadLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DownloadLink")]
    public string DownloadLink { get; set; }

    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    [DataMember(Name="FileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FileName")]
    public string FileName { get; set; }

    /// <summary>
    /// Gets or Sets Size
    /// </summary>
    [DataMember(Name="Size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Size")]
    public long? Size { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxBackup {\n");
      sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
      sb.Append("  DownloadLink: ").Append(DownloadLink).Append("\n");
      sb.Append("  FileName: ").Append(FileName).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
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
