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
  public class PbxLiveChatBox {
    /// <summary>
    /// Gets or Sets ButtonIconType
    /// </summary>
    [DataMember(Name="ButtonIconType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ButtonIconType")]
    public AllOfPbxLiveChatBoxButtonIconType ButtonIconType { get; set; }

    /// <summary>
    /// Gets or Sets ButtonIconUrl
    /// </summary>
    [DataMember(Name="ButtonIconUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ButtonIconUrl")]
    public string ButtonIconUrl { get; set; }

    /// <summary>
    /// Gets or Sets ChatDelay
    /// </summary>
    [DataMember(Name="ChatDelay", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChatDelay")]
    public int? ChatDelay { get; set; }

    /// <summary>
    /// Gets or Sets Height
    /// </summary>
    [DataMember(Name="Height", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Height")]
    public string Height { get; set; }

    /// <summary>
    /// Gets or Sets LiveChatLanguage
    /// </summary>
    [DataMember(Name="LiveChatLanguage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LiveChatLanguage")]
    public AllOfPbxLiveChatBoxLiveChatLanguage LiveChatLanguage { get; set; }

    /// <summary>
    /// Gets or Sets LiveMessageUserinfoFormat
    /// </summary>
    [DataMember(Name="LiveMessageUserinfoFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LiveMessageUserinfoFormat")]
    public AllOfPbxLiveChatBoxLiveMessageUserinfoFormat LiveMessageUserinfoFormat { get; set; }

    /// <summary>
    /// Gets or Sets MessageDateformat
    /// </summary>
    [DataMember(Name="MessageDateformat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MessageDateformat")]
    public AllOfPbxLiveChatBoxMessageDateformat MessageDateformat { get; set; }

    /// <summary>
    /// Gets or Sets MinimizedStyle
    /// </summary>
    [DataMember(Name="MinimizedStyle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinimizedStyle")]
    public AllOfPbxLiveChatBoxMinimizedStyle MinimizedStyle { get; set; }

    /// <summary>
    /// Gets or Sets OperatorIcon
    /// </summary>
    [DataMember(Name="OperatorIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatorIcon")]
    public string OperatorIcon { get; set; }

    /// <summary>
    /// Gets or Sets OperatorName
    /// </summary>
    [DataMember(Name="OperatorName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperatorName")]
    public string OperatorName { get; set; }

    /// <summary>
    /// Gets or Sets ShowOperatorActualName
    /// </summary>
    [DataMember(Name="ShowOperatorActualName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ShowOperatorActualName")]
    public bool? ShowOperatorActualName { get; set; }

    /// <summary>
    /// Gets or Sets WindowIcon
    /// </summary>
    [DataMember(Name="WindowIcon", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WindowIcon")]
    public string WindowIcon { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxLiveChatBox {\n");
      sb.Append("  ButtonIconType: ").Append(ButtonIconType).Append("\n");
      sb.Append("  ButtonIconUrl: ").Append(ButtonIconUrl).Append("\n");
      sb.Append("  ChatDelay: ").Append(ChatDelay).Append("\n");
      sb.Append("  Height: ").Append(Height).Append("\n");
      sb.Append("  LiveChatLanguage: ").Append(LiveChatLanguage).Append("\n");
      sb.Append("  LiveMessageUserinfoFormat: ").Append(LiveMessageUserinfoFormat).Append("\n");
      sb.Append("  MessageDateformat: ").Append(MessageDateformat).Append("\n");
      sb.Append("  MinimizedStyle: ").Append(MinimizedStyle).Append("\n");
      sb.Append("  OperatorIcon: ").Append(OperatorIcon).Append("\n");
      sb.Append("  OperatorName: ").Append(OperatorName).Append("\n");
      sb.Append("  ShowOperatorActualName: ").Append(ShowOperatorActualName).Append("\n");
      sb.Append("  WindowIcon: ").Append(WindowIcon).Append("\n");
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
