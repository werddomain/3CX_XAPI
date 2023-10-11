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
  public class PbxWeblink {
    /// <summary>
    /// Gets or Sets Advanced
    /// </summary>
    [DataMember(Name="Advanced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Advanced")]
    public AllOfPbxWeblinkAdvanced Advanced { get; set; }

    /// <summary>
    /// Gets or Sets CallsEnabled
    /// </summary>
    [DataMember(Name="CallsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallsEnabled")]
    public bool? CallsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets ChatBox
    /// </summary>
    [DataMember(Name="ChatBox", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChatBox")]
    public AllOfPbxWeblinkChatBox ChatBox { get; set; }

    /// <summary>
    /// Gets or Sets ChatEnabled
    /// </summary>
    [DataMember(Name="ChatEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChatEnabled")]
    public bool? ChatEnabled { get; set; }

    /// <summary>
    /// Gets or Sets DefaultRecord
    /// </summary>
    [DataMember(Name="DefaultRecord", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultRecord")]
    public bool? DefaultRecord { get; set; }

    /// <summary>
    /// Gets or Sets DN
    /// </summary>
    [DataMember(Name="DN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DN")]
    public AllOfPbxWeblinkDN DN { get; set; }

    /// <summary>
    /// Gets or Sets General
    /// </summary>
    [DataMember(Name="General", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "General")]
    public AllOfPbxWeblinkGeneral General { get; set; }

    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name="Group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Group")]
    public string Group { get; set; }

    /// <summary>
    /// Gets or Sets Hidden
    /// </summary>
    [DataMember(Name="Hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Link
    /// </summary>
    [DataMember(Name="Link", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Link")]
    public string Link { get; set; }

    /// <summary>
    /// Gets or Sets MeetingEnabled
    /// </summary>
    [DataMember(Name="MeetingEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MeetingEnabled")]
    public bool? MeetingEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Styling
    /// </summary>
    [DataMember(Name="Styling", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Styling")]
    public AllOfPbxWeblinkStyling Styling { get; set; }

    /// <summary>
    /// Gets or Sets Translations
    /// </summary>
    [DataMember(Name="Translations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Translations")]
    public AllOfPbxWeblinkTranslations Translations { get; set; }

    /// <summary>
    /// Gets or Sets Website
    /// </summary>
    [DataMember(Name="Website", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Website")]
    public List<string> Website { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxWeblink {\n");
      sb.Append("  Advanced: ").Append(Advanced).Append("\n");
      sb.Append("  CallsEnabled: ").Append(CallsEnabled).Append("\n");
      sb.Append("  ChatBox: ").Append(ChatBox).Append("\n");
      sb.Append("  ChatEnabled: ").Append(ChatEnabled).Append("\n");
      sb.Append("  DefaultRecord: ").Append(DefaultRecord).Append("\n");
      sb.Append("  DN: ").Append(DN).Append("\n");
      sb.Append("  General: ").Append(General).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Link: ").Append(Link).Append("\n");
      sb.Append("  MeetingEnabled: ").Append(MeetingEnabled).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Styling: ").Append(Styling).Append("\n");
      sb.Append("  Translations: ").Append(Translations).Append("\n");
      sb.Append("  Website: ").Append(Website).Append("\n");
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
