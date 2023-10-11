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
  public class PbxTrunkTemplate {
    /// <summary>
    /// Gets or Sets AddAllowed
    /// </summary>
    [DataMember(Name="AddAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AddAllowed")]
    public bool? AddAllowed { get; set; }

    /// <summary>
    /// Gets or Sets Countries
    /// </summary>
    [DataMember(Name="Countries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Countries")]
    public List<string> Countries { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Editors
    /// </summary>
    [DataMember(Name="Editors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Editors")]
    public List<PbxTrunkEditorType> Editors { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets MessagingTemplate
    /// </summary>
    [DataMember(Name="MessagingTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MessagingTemplate")]
    public AllOfPbxTrunkTemplateMessagingTemplate MessagingTemplate { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name="Tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public PbxProviderType Type { get; set; }

    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name="Url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxTrunkTemplate {\n");
      sb.Append("  AddAllowed: ").Append(AddAllowed).Append("\n");
      sb.Append("  Countries: ").Append(Countries).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Editors: ").Append(Editors).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MessagingTemplate: ").Append(MessagingTemplate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
