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
  public class PbxGateway {
    /// <summary>
    /// Gets or Sets Codecs
    /// </summary>
    [DataMember(Name="Codecs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Codecs")]
    public List<string> Codecs { get; set; }

    /// <summary>
    /// Gets or Sets DeliverAudio
    /// </summary>
    [DataMember(Name="DeliverAudio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeliverAudio")]
    public bool? DeliverAudio { get; set; }

    /// <summary>
    /// Gets or Sets DestNumberInRemotePartyIDCalled
    /// </summary>
    [DataMember(Name="DestNumberInRemotePartyIDCalled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DestNumberInRemotePartyIDCalled")]
    public bool? DestNumberInRemotePartyIDCalled { get; set; }

    /// <summary>
    /// Gets or Sets DestNumberInRequestLineURI
    /// </summary>
    [DataMember(Name="DestNumberInRequestLineURI", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DestNumberInRequestLineURI")]
    public bool? DestNumberInRequestLineURI { get; set; }

    /// <summary>
    /// Gets or Sets DestNumberInTo
    /// </summary>
    [DataMember(Name="DestNumberInTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DestNumberInTo")]
    public bool? DestNumberInTo { get; set; }

    /// <summary>
    /// Gets or Sets Host
    /// </summary>
    [DataMember(Name="Host", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Host")]
    public string Host { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets InboundParams
    /// </summary>
    [DataMember(Name="InboundParams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InboundParams")]
    public List<AllOfPbxGatewayInboundParamsItems> InboundParams { get; set; }

    /// <summary>
    /// Gets or Sets _Internal
    /// </summary>
    [DataMember(Name="Internal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Internal")]
    public bool? _Internal { get; set; }

    /// <summary>
    /// Gets or Sets IPInRegistrationContact
    /// </summary>
    [DataMember(Name="IPInRegistrationContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IPInRegistrationContact")]
    public AllOfPbxGatewayIPInRegistrationContact IPInRegistrationContact { get; set; }

    /// <summary>
    /// Gets or Sets Lines
    /// </summary>
    [DataMember(Name="Lines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Lines")]
    public int? Lines { get; set; }

    /// <summary>
    /// Gets or Sets MatchingStrategy
    /// </summary>
    [DataMember(Name="MatchingStrategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MatchingStrategy")]
    public AllOfPbxGatewayMatchingStrategy MatchingStrategy { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets OutboundCallerID
    /// </summary>
    [DataMember(Name="OutboundCallerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutboundCallerID")]
    public string OutboundCallerID { get; set; }

    /// <summary>
    /// Gets or Sets OutboundParams
    /// </summary>
    [DataMember(Name="OutboundParams", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutboundParams")]
    public List<AllOfPbxGatewayOutboundParamsItems> OutboundParams { get; set; }

    /// <summary>
    /// Gets or Sets Port
    /// </summary>
    [DataMember(Name="Port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Port")]
    public int? Port { get; set; }

    /// <summary>
    /// Gets or Sets ProxyHost
    /// </summary>
    [DataMember(Name="ProxyHost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProxyHost")]
    public string ProxyHost { get; set; }

    /// <summary>
    /// Gets or Sets ProxyPort
    /// </summary>
    [DataMember(Name="ProxyPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProxyPort")]
    public int? ProxyPort { get; set; }

    /// <summary>
    /// Gets or Sets RequireRegistrationFor
    /// </summary>
    [DataMember(Name="RequireRegistrationFor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireRegistrationFor")]
    public AllOfPbxGatewayRequireRegistrationFor RequireRegistrationFor { get; set; }

    /// <summary>
    /// Gets or Sets SourceIdentification
    /// </summary>
    [DataMember(Name="SourceIdentification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SourceIdentification")]
    public List<AllOfPbxGatewaySourceIdentificationItems> SourceIdentification { get; set; }

    /// <summary>
    /// Gets or Sets SpecifiedIPForRegistrationContact
    /// </summary>
    [DataMember(Name="SpecifiedIPForRegistrationContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpecifiedIPForRegistrationContact")]
    public string SpecifiedIPForRegistrationContact { get; set; }

    /// <summary>
    /// Gets or Sets SRTPMode
    /// </summary>
    [DataMember(Name="SRTPMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SRTPMode")]
    public AllOfPbxGatewaySRTPMode SRTPMode { get; set; }

    /// <summary>
    /// Gets or Sets SupportReinvite
    /// </summary>
    [DataMember(Name="SupportReinvite", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportReinvite")]
    public bool? SupportReinvite { get; set; }

    /// <summary>
    /// Gets or Sets SupportReplaces
    /// </summary>
    [DataMember(Name="SupportReplaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportReplaces")]
    public bool? SupportReplaces { get; set; }

    /// <summary>
    /// Gets or Sets TemplateFilename
    /// </summary>
    [DataMember(Name="TemplateFilename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TemplateFilename")]
    public string TemplateFilename { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public PbxGatewayType Type { get; set; }

    /// <summary>
    /// Gets or Sets UseIPInContact
    /// </summary>
    [DataMember(Name="UseIPInContact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseIPInContact")]
    public bool? UseIPInContact { get; set; }

    /// <summary>
    /// Gets or Sets VariableChoices
    /// </summary>
    [DataMember(Name="VariableChoices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VariableChoices")]
    public List<AllOfPbxGatewayVariableChoicesItems> VariableChoices { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxGateway {\n");
      sb.Append("  Codecs: ").Append(Codecs).Append("\n");
      sb.Append("  DeliverAudio: ").Append(DeliverAudio).Append("\n");
      sb.Append("  DestNumberInRemotePartyIDCalled: ").Append(DestNumberInRemotePartyIDCalled).Append("\n");
      sb.Append("  DestNumberInRequestLineURI: ").Append(DestNumberInRequestLineURI).Append("\n");
      sb.Append("  DestNumberInTo: ").Append(DestNumberInTo).Append("\n");
      sb.Append("  Host: ").Append(Host).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InboundParams: ").Append(InboundParams).Append("\n");
      sb.Append("  _Internal: ").Append(_Internal).Append("\n");
      sb.Append("  IPInRegistrationContact: ").Append(IPInRegistrationContact).Append("\n");
      sb.Append("  Lines: ").Append(Lines).Append("\n");
      sb.Append("  MatchingStrategy: ").Append(MatchingStrategy).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  OutboundCallerID: ").Append(OutboundCallerID).Append("\n");
      sb.Append("  OutboundParams: ").Append(OutboundParams).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  ProxyHost: ").Append(ProxyHost).Append("\n");
      sb.Append("  ProxyPort: ").Append(ProxyPort).Append("\n");
      sb.Append("  RequireRegistrationFor: ").Append(RequireRegistrationFor).Append("\n");
      sb.Append("  SourceIdentification: ").Append(SourceIdentification).Append("\n");
      sb.Append("  SpecifiedIPForRegistrationContact: ").Append(SpecifiedIPForRegistrationContact).Append("\n");
      sb.Append("  SRTPMode: ").Append(SRTPMode).Append("\n");
      sb.Append("  SupportReinvite: ").Append(SupportReinvite).Append("\n");
      sb.Append("  SupportReplaces: ").Append(SupportReplaces).Append("\n");
      sb.Append("  TemplateFilename: ").Append(TemplateFilename).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UseIPInContact: ").Append(UseIPInContact).Append("\n");
      sb.Append("  VariableChoices: ").Append(VariableChoices).Append("\n");
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
