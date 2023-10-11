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
  public class PbxLiveChatAdvancedSettings {
    /// <summary>
    /// Gets or Sets CallTitle
    /// </summary>
    [DataMember(Name="CallTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallTitle")]
    public string CallTitle { get; set; }

    /// <summary>
    /// Gets or Sets CommunicationOptions
    /// </summary>
    [DataMember(Name="CommunicationOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CommunicationOptions")]
    public AllOfPbxLiveChatAdvancedSettingsCommunicationOptions CommunicationOptions { get; set; }

    /// <summary>
    /// Gets or Sets EnableDirectCall
    /// </summary>
    [DataMember(Name="EnableDirectCall", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnableDirectCall")]
    public bool? EnableDirectCall { get; set; }

    /// <summary>
    /// Gets or Sets IgnoreQueueOwnership
    /// </summary>
    [DataMember(Name="IgnoreQueueOwnership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IgnoreQueueOwnership")]
    public bool? IgnoreQueueOwnership { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxLiveChatAdvancedSettings {\n");
      sb.Append("  CallTitle: ").Append(CallTitle).Append("\n");
      sb.Append("  CommunicationOptions: ").Append(CommunicationOptions).Append("\n");
      sb.Append("  EnableDirectCall: ").Append(EnableDirectCall).Append("\n");
      sb.Append("  IgnoreQueueOwnership: ").Append(IgnoreQueueOwnership).Append("\n");
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
