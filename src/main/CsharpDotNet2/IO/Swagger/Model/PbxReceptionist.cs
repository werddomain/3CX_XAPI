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
  public class PbxReceptionist {
    /// <summary>
    /// Gets or Sets Forwards
    /// </summary>
    [DataMember(Name="Forwards", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Forwards")]
    public List<PbxReceptionistForward> Forwards { get; set; }

    /// <summary>
    /// Gets or Sets ForwardSmsTo
    /// </summary>
    [DataMember(Name="ForwardSmsTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForwardSmsTo")]
    public string ForwardSmsTo { get; set; }

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
    /// Gets or Sets InvalidKeyForwardDN
    /// </summary>
    [DataMember(Name="InvalidKeyForwardDN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InvalidKeyForwardDN")]
    public string InvalidKeyForwardDN { get; set; }

    /// <summary>
    /// Gets or Sets IsRegistered
    /// </summary>
    [DataMember(Name="IsRegistered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRegistered")]
    public bool? IsRegistered { get; set; }

    /// <summary>
    /// Gets or Sets IVRType
    /// </summary>
    [DataMember(Name="IVRType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IVRType")]
    public AllOfPbxReceptionistIVRType IVRType { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets PromptFilename
    /// </summary>
    [DataMember(Name="PromptFilename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptFilename")]
    public string PromptFilename { get; set; }

    /// <summary>
    /// Gets or Sets PromptSet
    /// </summary>
    [DataMember(Name="PromptSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptSet")]
    public string PromptSet { get; set; }

    /// <summary>
    /// Gets or Sets Timeout
    /// </summary>
    [DataMember(Name="Timeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Timeout")]
    public int? Timeout { get; set; }

    /// <summary>
    /// Gets or Sets TimeoutForwardDN
    /// </summary>
    [DataMember(Name="TimeoutForwardDN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeoutForwardDN")]
    public string TimeoutForwardDN { get; set; }

    /// <summary>
    /// Gets or Sets TimeoutForwardType
    /// </summary>
    [DataMember(Name="TimeoutForwardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeoutForwardType")]
    public AllOfPbxReceptionistTimeoutForwardType TimeoutForwardType { get; set; }

    /// <summary>
    /// Gets or Sets UseMSExchange
    /// </summary>
    [DataMember(Name="UseMSExchange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseMSExchange")]
    public bool? UseMSExchange { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxReceptionist {\n");
      sb.Append("  Forwards: ").Append(Forwards).Append("\n");
      sb.Append("  ForwardSmsTo: ").Append(ForwardSmsTo).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  InvalidKeyForwardDN: ").Append(InvalidKeyForwardDN).Append("\n");
      sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
      sb.Append("  IVRType: ").Append(IVRType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  PromptFilename: ").Append(PromptFilename).Append("\n");
      sb.Append("  PromptSet: ").Append(PromptSet).Append("\n");
      sb.Append("  Timeout: ").Append(Timeout).Append("\n");
      sb.Append("  TimeoutForwardDN: ").Append(TimeoutForwardDN).Append("\n");
      sb.Append("  TimeoutForwardType: ").Append(TimeoutForwardType).Append("\n");
      sb.Append("  UseMSExchange: ").Append(UseMSExchange).Append("\n");
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
