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
  public class PbxTrunk {
    /// <summary>
    /// Gets or Sets AuthID
    /// </summary>
    [DataMember(Name="AuthID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthID")]
    public string AuthID { get; set; }

    /// <summary>
    /// Gets or Sets AuthPassword
    /// </summary>
    [DataMember(Name="AuthPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthPassword")]
    public string AuthPassword { get; set; }

    /// <summary>
    /// Gets or Sets ConfigurationIssue
    /// </summary>
    [DataMember(Name="ConfigurationIssue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConfigurationIssue")]
    public string ConfigurationIssue { get; set; }

    /// <summary>
    /// Gets or Sets DidNumbers
    /// </summary>
    [DataMember(Name="DidNumbers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DidNumbers")]
    public List<string> DidNumbers { get; set; }

    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name="Direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Direction")]
    public AllOfPbxTrunkDirection Direction { get; set; }

    /// <summary>
    /// Gets or Sets ExternalNumber
    /// </summary>
    [DataMember(Name="ExternalNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExternalNumber")]
    public string ExternalNumber { get; set; }

    /// <summary>
    /// Gets or Sets Gateway
    /// </summary>
    [DataMember(Name="Gateway", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Gateway")]
    public AllOfPbxTrunkGateway Gateway { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="Groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups")]
    public List<PbxUserGroup> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets IsOnline
    /// </summary>
    [DataMember(Name="IsOnline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsOnline")]
    public bool? IsOnline { get; set; }

    /// <summary>
    /// Gets or Sets Messaging
    /// </summary>
    [DataMember(Name="Messaging", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Messaging")]
    public AllOfPbxTrunkMessaging Messaging { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets OutboundCallerID
    /// </summary>
    [DataMember(Name="OutboundCallerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutboundCallerID")]
    public string OutboundCallerID { get; set; }

    /// <summary>
    /// Gets or Sets PublicIPinSIP
    /// </summary>
    [DataMember(Name="PublicIPinSIP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PublicIPinSIP")]
    public string PublicIPinSIP { get; set; }

    /// <summary>
    /// Gets or Sets RoutingRules
    /// </summary>
    [DataMember(Name="RoutingRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoutingRules")]
    public List<PbxInboundRule> RoutingRules { get; set; }

    /// <summary>
    /// Gets or Sets SecondaryRegistrar
    /// </summary>
    [DataMember(Name="SecondaryRegistrar", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecondaryRegistrar")]
    public string SecondaryRegistrar { get; set; }

    /// <summary>
    /// Gets or Sets SeparateAuthId
    /// </summary>
    [DataMember(Name="SeparateAuthId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SeparateAuthId")]
    public string SeparateAuthId { get; set; }

    /// <summary>
    /// Gets or Sets SimultaneousCalls
    /// </summary>
    [DataMember(Name="SimultaneousCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SimultaneousCalls")]
    public int? SimultaneousCalls { get; set; }

    /// <summary>
    /// Gets or Sets UseSeparateAuthId
    /// </summary>
    [DataMember(Name="UseSeparateAuthId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseSeparateAuthId")]
    public bool? UseSeparateAuthId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxTrunk {\n");
      sb.Append("  AuthID: ").Append(AuthID).Append("\n");
      sb.Append("  AuthPassword: ").Append(AuthPassword).Append("\n");
      sb.Append("  ConfigurationIssue: ").Append(ConfigurationIssue).Append("\n");
      sb.Append("  DidNumbers: ").Append(DidNumbers).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  ExternalNumber: ").Append(ExternalNumber).Append("\n");
      sb.Append("  Gateway: ").Append(Gateway).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
      sb.Append("  Messaging: ").Append(Messaging).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  OutboundCallerID: ").Append(OutboundCallerID).Append("\n");
      sb.Append("  PublicIPinSIP: ").Append(PublicIPinSIP).Append("\n");
      sb.Append("  RoutingRules: ").Append(RoutingRules).Append("\n");
      sb.Append("  SecondaryRegistrar: ").Append(SecondaryRegistrar).Append("\n");
      sb.Append("  SeparateAuthId: ").Append(SeparateAuthId).Append("\n");
      sb.Append("  SimultaneousCalls: ").Append(SimultaneousCalls).Append("\n");
      sb.Append("  UseSeparateAuthId: ").Append(UseSeparateAuthId).Append("\n");
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
