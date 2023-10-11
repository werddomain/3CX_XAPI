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
  public class PbxPromptSet {
    /// <summary>
    /// Gets or Sets CultureCode
    /// </summary>
    [DataMember(Name="CultureCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CultureCode")]
    public string CultureCode { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Folder
    /// </summary>
    [DataMember(Name="Folder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Folder")]
    public string Folder { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets LanguageCode
    /// </summary>
    [DataMember(Name="LanguageCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LanguageCode")]
    public string LanguageCode { get; set; }

    /// <summary>
    /// Gets or Sets Prompts
    /// </summary>
    [DataMember(Name="Prompts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Prompts")]
    public List<PbxPrompt> Prompts { get; set; }

    /// <summary>
    /// Gets or Sets PromptSetName
    /// </summary>
    [DataMember(Name="PromptSetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptSetName")]
    public string PromptSetName { get; set; }

    /// <summary>
    /// Gets or Sets PromptSetType
    /// </summary>
    [DataMember(Name="PromptSetType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptSetType")]
    public AllOfPbxPromptSetPromptSetType PromptSetType { get; set; }

    /// <summary>
    /// Gets or Sets UseAlternateNumberPronunciation
    /// </summary>
    [DataMember(Name="UseAlternateNumberPronunciation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseAlternateNumberPronunciation")]
    public bool? UseAlternateNumberPronunciation { get; set; }

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
      sb.Append("class PbxPromptSet {\n");
      sb.Append("  CultureCode: ").Append(CultureCode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Folder: ").Append(Folder).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
      sb.Append("  Prompts: ").Append(Prompts).Append("\n");
      sb.Append("  PromptSetName: ").Append(PromptSetName).Append("\n");
      sb.Append("  PromptSetType: ").Append(PromptSetType).Append("\n");
      sb.Append("  UseAlternateNumberPronunciation: ").Append(UseAlternateNumberPronunciation).Append("\n");
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
