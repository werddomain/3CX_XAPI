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
  public class PbxGeneralLiveChatSettings {
    /// <summary>
    /// Gets or Sets AllowSoundNotifications
    /// </summary>
    [DataMember(Name="AllowSoundNotifications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSoundNotifications")]
    public bool? AllowSoundNotifications { get; set; }

    /// <summary>
    /// Gets or Sets Authentication
    /// </summary>
    [DataMember(Name="Authentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Authentication")]
    public AllOfPbxGeneralLiveChatSettingsAuthentication Authentication { get; set; }

    /// <summary>
    /// Gets or Sets DisableOfflineMessages
    /// </summary>
    [DataMember(Name="DisableOfflineMessages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisableOfflineMessages")]
    public bool? DisableOfflineMessages { get; set; }

    /// <summary>
    /// Gets or Sets EnableGA
    /// </summary>
    [DataMember(Name="EnableGA", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnableGA")]
    public bool? EnableGA { get; set; }

    /// <summary>
    /// Gets or Sets EnableOnMobile
    /// </summary>
    [DataMember(Name="EnableOnMobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnableOnMobile")]
    public bool? EnableOnMobile { get; set; }

    /// <summary>
    /// Gets or Sets GdprEnabled
    /// </summary>
    [DataMember(Name="GdprEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GdprEnabled")]
    public bool? GdprEnabled { get; set; }

    /// <summary>
    /// Gets or Sets Greeting
    /// </summary>
    [DataMember(Name="Greeting", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Greeting")]
    public AllOfPbxGeneralLiveChatSettingsGreeting Greeting { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxGeneralLiveChatSettings {\n");
      sb.Append("  AllowSoundNotifications: ").Append(AllowSoundNotifications).Append("\n");
      sb.Append("  Authentication: ").Append(Authentication).Append("\n");
      sb.Append("  DisableOfflineMessages: ").Append(DisableOfflineMessages).Append("\n");
      sb.Append("  EnableGA: ").Append(EnableGA).Append("\n");
      sb.Append("  EnableOnMobile: ").Append(EnableOnMobile).Append("\n");
      sb.Append("  GdprEnabled: ").Append(GdprEnabled).Append("\n");
      sb.Append("  Greeting: ").Append(Greeting).Append("\n");
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
