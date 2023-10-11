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
  public class PbxTrunkMessagingTemplate {
    /// <summary>
    /// Gets or Sets MessagingVariables
    /// </summary>
    [DataMember(Name="MessagingVariables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MessagingVariables")]
    public List<AllOfPbxTrunkMessagingTemplateMessagingVariablesItems> MessagingVariables { get; set; }

    /// <summary>
    /// Gets or Sets Optional
    /// </summary>
    [DataMember(Name="Optional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Optional")]
    public bool? Optional { get; set; }

    /// <summary>
    /// Gets or Sets Outbound
    /// </summary>
    [DataMember(Name="Outbound", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Outbound")]
    public bool? Outbound { get; set; }

    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [DataMember(Name="Provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Provider")]
    public string Provider { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxTrunkMessagingTemplate {\n");
      sb.Append("  MessagingVariables: ").Append(MessagingVariables).Append("\n");
      sb.Append("  Optional: ").Append(Optional).Append("\n");
      sb.Append("  Outbound: ").Append(Outbound).Append("\n");
      sb.Append("  Provider: ").Append(Provider).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
