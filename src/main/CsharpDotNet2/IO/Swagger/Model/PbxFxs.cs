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
  public class PbxFxs {
    /// <summary>
    /// Gets or Sets Brand
    /// </summary>
    [DataMember(Name="Brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Gets or Sets Codecs
    /// </summary>
    [DataMember(Name="Codecs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Codecs")]
    public List<string> Codecs { get; set; }

    /// <summary>
    /// Gets or Sets FxsLineCount
    /// </summary>
    [DataMember(Name="FxsLineCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FxsLineCount")]
    public int? FxsLineCount { get; set; }

    /// <summary>
    /// Gets or Sets FxsLines
    /// </summary>
    [DataMember(Name="FxsLines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FxsLines")]
    public List<AllOfPbxFxsFxsLinesItems> FxsLines { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name="Group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Group")]
    public string Group { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="Language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets MacAddress
    /// </summary>
    [DataMember(Name="MacAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MacAddress")]
    public string MacAddress { get; set; }

    /// <summary>
    /// Gets or Sets Model
    /// </summary>
    [DataMember(Name="Model", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Model")]
    public string Model { get; set; }

    /// <summary>
    /// Gets or Sets ModelName
    /// </summary>
    [DataMember(Name="ModelName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ModelName")]
    public string ModelName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Password
    /// </summary>
    [DataMember(Name="Password", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Password")]
    public string Password { get; set; }

    /// <summary>
    /// Gets or Sets Provisioning
    /// </summary>
    [DataMember(Name="Provisioning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Provisioning")]
    public AllOfPbxFxsProvisioning Provisioning { get; set; }

    /// <summary>
    /// Gets or Sets Registered
    /// </summary>
    [DataMember(Name="Registered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Registered")]
    public AllOfPbxFxsRegistered Registered { get; set; }

    /// <summary>
    /// Gets or Sets Secret
    /// </summary>
    [DataMember(Name="Secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets Template
    /// </summary>
    [DataMember(Name="Template", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Template")]
    public AllOfPbxFxsTemplate Template { get; set; }

    /// <summary>
    /// Gets or Sets TimeZone
    /// </summary>
    [DataMember(Name="TimeZone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZone")]
    public string TimeZone { get; set; }

    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    [DataMember(Name="Variables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Variables")]
    public List<AllOfPbxFxsVariablesItems> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxFxs {\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  Codecs: ").Append(Codecs).Append("\n");
      sb.Append("  FxsLineCount: ").Append(FxsLineCount).Append("\n");
      sb.Append("  FxsLines: ").Append(FxsLines).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
      sb.Append("  Model: ").Append(Model).Append("\n");
      sb.Append("  ModelName: ").Append(ModelName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Password: ").Append(Password).Append("\n");
      sb.Append("  Provisioning: ").Append(Provisioning).Append("\n");
      sb.Append("  Registered: ").Append(Registered).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  Template: ").Append(Template).Append("\n");
      sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
      sb.Append("  Variables: ").Append(Variables).Append("\n");
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
