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
  public class PbxUpdateItem {
    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="Category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets DescriptionLink
    /// </summary>
    [DataMember(Name="DescriptionLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DescriptionLink")]
    public string DescriptionLink { get; set; }

    /// <summary>
    /// Gets or Sets Guid
    /// </summary>
    [DataMember(Name="Guid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Guid")]
    public Guid? Guid { get; set; }

    /// <summary>
    /// Gets or Sets Ignore
    /// </summary>
    [DataMember(Name="Ignore", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Ignore")]
    public bool? Ignore { get; set; }

    /// <summary>
    /// Gets or Sets Image
    /// </summary>
    [DataMember(Name="Image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Image")]
    public string Image { get; set; }

    /// <summary>
    /// Gets or Sets LocalVersion
    /// </summary>
    [DataMember(Name="LocalVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalVersion")]
    public string LocalVersion { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets OutOfDate
    /// </summary>
    [DataMember(Name="OutOfDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutOfDate")]
    public bool? OutOfDate { get; set; }

    /// <summary>
    /// Gets or Sets ServerVersion
    /// </summary>
    [DataMember(Name="ServerVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServerVersion")]
    public string ServerVersion { get; set; }

    /// <summary>
    /// Gets or Sets UpdateType
    /// </summary>
    [DataMember(Name="UpdateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UpdateType")]
    public AllOfPbxUpdateItemUpdateType UpdateType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxUpdateItem {\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  DescriptionLink: ").Append(DescriptionLink).Append("\n");
      sb.Append("  Guid: ").Append(Guid).Append("\n");
      sb.Append("  Ignore: ").Append(Ignore).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  LocalVersion: ").Append(LocalVersion).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OutOfDate: ").Append(OutOfDate).Append("\n");
      sb.Append("  ServerVersion: ").Append(ServerVersion).Append("\n");
      sb.Append("  UpdateType: ").Append(UpdateType).Append("\n");
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
