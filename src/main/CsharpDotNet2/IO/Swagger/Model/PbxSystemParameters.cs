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
  public class PbxSystemParameters {
    /// <summary>
    /// Gets or Sets Custom1Name
    /// </summary>
    [DataMember(Name="Custom1Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Custom1Name")]
    public string Custom1Name { get; set; }

    /// <summary>
    /// Gets or Sets Custom2Name
    /// </summary>
    [DataMember(Name="Custom2Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Custom2Name")]
    public string Custom2Name { get; set; }

    /// <summary>
    /// Gets or Sets IsHosted
    /// </summary>
    [DataMember(Name="IsHosted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsHosted")]
    public bool? IsHosted { get; set; }

    /// <summary>
    /// Gets or Sets IsHosted3CX
    /// </summary>
    [DataMember(Name="IsHosted3CX", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsHosted3CX")]
    public bool? IsHosted3CX { get; set; }

    /// <summary>
    /// Gets or Sets IsMulticompanyMode
    /// </summary>
    [DataMember(Name="IsMulticompanyMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsMulticompanyMode")]
    public bool? IsMulticompanyMode { get; set; }

    /// <summary>
    /// Gets or Sets IsStaticIp
    /// </summary>
    [DataMember(Name="IsStaticIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsStaticIp")]
    public bool? IsStaticIp { get; set; }

    /// <summary>
    /// Gets or Sets License
    /// </summary>
    [DataMember(Name="License", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "License")]
    public AllOfPbxSystemParametersLicense License { get; set; }

    /// <summary>
    /// Gets or Sets PbxExternalHost
    /// </summary>
    [DataMember(Name="PbxExternalHost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PbxExternalHost")]
    public string PbxExternalHost { get; set; }

    /// <summary>
    /// Gets or Sets SipPort
    /// </summary>
    [DataMember(Name="SipPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SipPort")]
    public int? SipPort { get; set; }

    /// <summary>
    /// Gets or Sets StaticIp
    /// </summary>
    [DataMember(Name="StaticIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StaticIp")]
    public string StaticIp { get; set; }

    /// <summary>
    /// Gets or Sets StunIp
    /// </summary>
    [DataMember(Name="StunIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StunIp")]
    public string StunIp { get; set; }

    /// <summary>
    /// Gets or Sets UseLocalRps
    /// </summary>
    [DataMember(Name="UseLocalRps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseLocalRps")]
    public bool? UseLocalRps { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public string Version { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxSystemParameters {\n");
      sb.Append("  Custom1Name: ").Append(Custom1Name).Append("\n");
      sb.Append("  Custom2Name: ").Append(Custom2Name).Append("\n");
      sb.Append("  IsHosted: ").Append(IsHosted).Append("\n");
      sb.Append("  IsHosted3CX: ").Append(IsHosted3CX).Append("\n");
      sb.Append("  IsMulticompanyMode: ").Append(IsMulticompanyMode).Append("\n");
      sb.Append("  IsStaticIp: ").Append(IsStaticIp).Append("\n");
      sb.Append("  License: ").Append(License).Append("\n");
      sb.Append("  PbxExternalHost: ").Append(PbxExternalHost).Append("\n");
      sb.Append("  SipPort: ").Append(SipPort).Append("\n");
      sb.Append("  StaticIp: ").Append(StaticIp).Append("\n");
      sb.Append("  StunIp: ").Append(StunIp).Append("\n");
      sb.Append("  UseLocalRps: ").Append(UseLocalRps).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
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
