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
  public class PbxFxsProvisioning {
    /// <summary>
    /// Gets or Sets LocalAudioPortEnd
    /// </summary>
    [DataMember(Name="LocalAudioPortEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalAudioPortEnd")]
    public int? LocalAudioPortEnd { get; set; }

    /// <summary>
    /// Gets or Sets LocalAudioPortStart
    /// </summary>
    [DataMember(Name="LocalAudioPortStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalAudioPortStart")]
    public int? LocalAudioPortStart { get; set; }

    /// <summary>
    /// Gets or Sets LocalInterface
    /// </summary>
    [DataMember(Name="LocalInterface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalInterface")]
    public string LocalInterface { get; set; }

    /// <summary>
    /// Gets or Sets LocalSipPort
    /// </summary>
    [DataMember(Name="LocalSipPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalSipPort")]
    public int? LocalSipPort { get; set; }

    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [DataMember(Name="Method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Method")]
    public AllOfPbxFxsProvisioningMethod Method { get; set; }

    /// <summary>
    /// Gets or Sets ProvLink
    /// </summary>
    [DataMember(Name="ProvLink", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProvLink")]
    public string ProvLink { get; set; }

    /// <summary>
    /// Gets or Sets RemoteFQDN
    /// </summary>
    [DataMember(Name="RemoteFQDN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemoteFQDN")]
    public string RemoteFQDN { get; set; }

    /// <summary>
    /// Gets or Sets RemotePort
    /// </summary>
    [DataMember(Name="RemotePort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemotePort")]
    public int? RemotePort { get; set; }

    /// <summary>
    /// Gets or Sets SbcName
    /// </summary>
    [DataMember(Name="SbcName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SbcName")]
    public string SbcName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxFxsProvisioning {\n");
      sb.Append("  LocalAudioPortEnd: ").Append(LocalAudioPortEnd).Append("\n");
      sb.Append("  LocalAudioPortStart: ").Append(LocalAudioPortStart).Append("\n");
      sb.Append("  LocalInterface: ").Append(LocalInterface).Append("\n");
      sb.Append("  LocalSipPort: ").Append(LocalSipPort).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  ProvLink: ").Append(ProvLink).Append("\n");
      sb.Append("  RemoteFQDN: ").Append(RemoteFQDN).Append("\n");
      sb.Append("  RemotePort: ").Append(RemotePort).Append("\n");
      sb.Append("  SbcName: ").Append(SbcName).Append("\n");
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
