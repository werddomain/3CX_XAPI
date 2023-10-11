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
  public class PbxCustomPrompt {
    /// <summary>
    /// Gets or Sets CanBeDeleted
    /// </summary>
    [DataMember(Name="CanBeDeleted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CanBeDeleted")]
    public bool? CanBeDeleted { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets FileLink
    /// </summary>
    [DataMember(Name="FileLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FileLink")]
    public string FileLink { get; set; }

    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [DataMember(Name="Filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Filename")]
    public string Filename { get; set; }

    /// <summary>
    /// Gets or Sets PromptType
    /// </summary>
    [DataMember(Name="PromptType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptType")]
    public PbxPromptType PromptType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxCustomPrompt {\n");
      sb.Append("  CanBeDeleted: ").Append(CanBeDeleted).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  FileLink: ").Append(FileLink).Append("\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  PromptType: ").Append(PromptType).Append("\n");
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
