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
  public class PbxTrunkVariable {
    /// <summary>
    /// Gets or Sets DefaultValue
    /// </summary>
    [DataMember(Name="DefaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// Gets or Sets MaxLength
    /// </summary>
    [DataMember(Name="MaxLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxLength")]
    public int? MaxLength { get; set; }

    /// <summary>
    /// Gets or Sets MinLength
    /// </summary>
    [DataMember(Name="MinLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinLength")]
    public int? MinLength { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Option
    /// </summary>
    [DataMember(Name="Option", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Option")]
    public string Option { get; set; }

    /// <summary>
    /// Gets or Sets OptionType
    /// </summary>
    [DataMember(Name="OptionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OptionType")]
    public AllOfPbxTrunkVariableOptionType OptionType { get; set; }

    /// <summary>
    /// Gets or Sets Pattern
    /// </summary>
    [DataMember(Name="Pattern", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Pattern")]
    public string Pattern { get; set; }

    /// <summary>
    /// Gets or Sets Prompt
    /// </summary>
    [DataMember(Name="Prompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Prompt")]
    public string Prompt { get; set; }

    /// <summary>
    /// Gets or Sets Required
    /// </summary>
    [DataMember(Name="Required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name="Title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Validation
    /// </summary>
    [DataMember(Name="Validation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Validation")]
    public string Validation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxTrunkVariable {\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
      sb.Append("  MinLength: ").Append(MinLength).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Option: ").Append(Option).Append("\n");
      sb.Append("  OptionType: ").Append(OptionType).Append("\n");
      sb.Append("  Pattern: ").Append(Pattern).Append("\n");
      sb.Append("  Prompt: ").Append(Prompt).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  Validation: ").Append(Validation).Append("\n");
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
