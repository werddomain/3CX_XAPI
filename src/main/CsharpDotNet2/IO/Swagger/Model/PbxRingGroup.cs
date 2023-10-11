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
  public class PbxRingGroup {
    /// <summary>
    /// Gets or Sets CallUsEnableChat
    /// </summary>
    [DataMember(Name="CallUsEnableChat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsEnableChat")]
    public bool? CallUsEnableChat { get; set; }

    /// <summary>
    /// Gets or Sets CallUsEnablePhone
    /// </summary>
    [DataMember(Name="CallUsEnablePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsEnablePhone")]
    public bool? CallUsEnablePhone { get; set; }

    /// <summary>
    /// Gets or Sets CallUsEnableVideo
    /// </summary>
    [DataMember(Name="CallUsEnableVideo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsEnableVideo")]
    public bool? CallUsEnableVideo { get; set; }

    /// <summary>
    /// Gets or Sets CallUsRequirement
    /// </summary>
    [DataMember(Name="CallUsRequirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsRequirement")]
    public AllOfPbxRingGroupCallUsRequirement CallUsRequirement { get; set; }

    /// <summary>
    /// Gets or Sets ClickToCallId
    /// </summary>
    [DataMember(Name="ClickToCallId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClickToCallId")]
    public string ClickToCallId { get; set; }

    /// <summary>
    /// Gets or Sets ForwardNoAnswer
    /// </summary>
    [DataMember(Name="ForwardNoAnswer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForwardNoAnswer")]
    public AllOfPbxRingGroupForwardNoAnswer ForwardNoAnswer { get; set; }

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
    /// Gets or Sets IsRegistered
    /// </summary>
    [DataMember(Name="IsRegistered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRegistered")]
    public bool? IsRegistered { get; set; }

    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name="Members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Members")]
    public List<PbxRingGroupMember> Members { get; set; }

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
    /// Gets or Sets RingStrategy
    /// </summary>
    [DataMember(Name="RingStrategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingStrategy")]
    public AllOfPbxRingGroupRingStrategy RingStrategy { get; set; }

    /// <summary>
    /// Gets or Sets RingTime
    /// </summary>
    [DataMember(Name="RingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingTime")]
    public int? RingTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxRingGroup {\n");
      sb.Append("  CallUsEnableChat: ").Append(CallUsEnableChat).Append("\n");
      sb.Append("  CallUsEnablePhone: ").Append(CallUsEnablePhone).Append("\n");
      sb.Append("  CallUsEnableVideo: ").Append(CallUsEnableVideo).Append("\n");
      sb.Append("  CallUsRequirement: ").Append(CallUsRequirement).Append("\n");
      sb.Append("  ClickToCallId: ").Append(ClickToCallId).Append("\n");
      sb.Append("  ForwardNoAnswer: ").Append(ForwardNoAnswer).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  RingStrategy: ").Append(RingStrategy).Append("\n");
      sb.Append("  RingTime: ").Append(RingTime).Append("\n");
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
