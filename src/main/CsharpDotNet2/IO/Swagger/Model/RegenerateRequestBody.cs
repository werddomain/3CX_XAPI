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
  public class RegenerateRequestBody {
    /// <summary>
    /// Gets or Sets SipAuth
    /// </summary>
    [DataMember(Name="SipAuth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SipAuth")]
    public bool? SipAuth { get; set; }

    /// <summary>
    /// Gets or Sets WebclientPassword
    /// </summary>
    [DataMember(Name="WebclientPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebclientPassword")]
    public bool? WebclientPassword { get; set; }

    /// <summary>
    /// Gets or Sets VoicemailPIN
    /// </summary>
    [DataMember(Name="VoicemailPIN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VoicemailPIN")]
    public bool? VoicemailPIN { get; set; }

    /// <summary>
    /// Gets or Sets DeskphonePassword
    /// </summary>
    [DataMember(Name="DeskphonePassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeskphonePassword")]
    public bool? DeskphonePassword { get; set; }

    /// <summary>
    /// Gets or Sets SendWelcomeEmail
    /// </summary>
    [DataMember(Name="SendWelcomeEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SendWelcomeEmail")]
    public bool? SendWelcomeEmail { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationLink
    /// </summary>
    [DataMember(Name="ConfigurationLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConfigurationLink")]
    public bool? ConfigurationLink { get; set; }

    /// <summary>
    /// Gets or Sets RpsKey
    /// </summary>
    [DataMember(Name="RpsKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RpsKey")]
    public bool? RpsKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RegenerateRequestBody {\n");
      sb.Append("  SipAuth: ").Append(SipAuth).Append("\n");
      sb.Append("  WebclientPassword: ").Append(WebclientPassword).Append("\n");
      sb.Append("  VoicemailPIN: ").Append(VoicemailPIN).Append("\n");
      sb.Append("  DeskphonePassword: ").Append(DeskphonePassword).Append("\n");
      sb.Append("  SendWelcomeEmail: ").Append(SendWelcomeEmail).Append("\n");
      sb.Append("  ConfigurationLink: ").Append(ConfigurationLink).Append("\n");
      sb.Append("  RpsKey: ").Append(RpsKey).Append("\n");
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
