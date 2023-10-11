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
  public class PbxQueue {
    /// <summary>
    /// Gets or Sets Agents
    /// </summary>
    [DataMember(Name="Agents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Agents")]
    public List<PbxQueueAgent> Agents { get; set; }

    /// <summary>
    /// Gets or Sets AnnounceQueuePosition
    /// </summary>
    [DataMember(Name="AnnounceQueuePosition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AnnounceQueuePosition")]
    public bool? AnnounceQueuePosition { get; set; }

    /// <summary>
    /// Gets or Sets CallbackEnableTime
    /// </summary>
    [DataMember(Name="CallbackEnableTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallbackEnableTime")]
    public int? CallbackEnableTime { get; set; }

    /// <summary>
    /// Gets or Sets CallbackPrefix
    /// </summary>
    [DataMember(Name="CallbackPrefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallbackPrefix")]
    public string CallbackPrefix { get; set; }

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
    public AllOfPbxQueueCallUsRequirement CallUsRequirement { get; set; }

    /// <summary>
    /// Gets or Sets ClickToCallId
    /// </summary>
    [DataMember(Name="ClickToCallId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClickToCallId")]
    public string ClickToCallId { get; set; }

    /// <summary>
    /// Gets or Sets EnableIntro
    /// </summary>
    [DataMember(Name="EnableIntro", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnableIntro")]
    public bool? EnableIntro { get; set; }

    /// <summary>
    /// Gets or Sets ForwardNoAnswer
    /// </summary>
    [DataMember(Name="ForwardNoAnswer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForwardNoAnswer")]
    public AllOfPbxQueueForwardNoAnswer ForwardNoAnswer { get; set; }

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
    /// Gets or Sets IntroFile
    /// </summary>
    [DataMember(Name="IntroFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IntroFile")]
    public string IntroFile { get; set; }

    /// <summary>
    /// Gets or Sets IsRegistered
    /// </summary>
    [DataMember(Name="IsRegistered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRegistered")]
    public bool? IsRegistered { get; set; }

    /// <summary>
    /// Gets or Sets Managers
    /// </summary>
    [DataMember(Name="Managers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Managers")]
    public List<PbxQueueManager> Managers { get; set; }

    /// <summary>
    /// Gets or Sets MasterTimeout
    /// </summary>
    [DataMember(Name="MasterTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MasterTimeout")]
    public int? MasterTimeout { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NotifyCodes
    /// </summary>
    [DataMember(Name="NotifyCodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotifyCodes")]
    public List<PbxQueueNotifyCode> NotifyCodes { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets OnHoldFile
    /// </summary>
    [DataMember(Name="OnHoldFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OnHoldFile")]
    public string OnHoldFile { get; set; }

    /// <summary>
    /// Gets or Sets PlayFullPrompt
    /// </summary>
    [DataMember(Name="PlayFullPrompt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlayFullPrompt")]
    public bool? PlayFullPrompt { get; set; }

    /// <summary>
    /// Gets or Sets PollingStrategy
    /// </summary>
    [DataMember(Name="PollingStrategy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PollingStrategy")]
    public AllOfPbxQueuePollingStrategy PollingStrategy { get; set; }

    /// <summary>
    /// Gets or Sets PromptSet
    /// </summary>
    [DataMember(Name="PromptSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptSet")]
    public string PromptSet { get; set; }

    /// <summary>
    /// Gets or Sets Recording
    /// </summary>
    [DataMember(Name="Recording", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Recording")]
    public AllOfPbxQueueRecording Recording { get; set; }

    /// <summary>
    /// Gets or Sets RingTimeout
    /// </summary>
    [DataMember(Name="RingTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingTimeout")]
    public int? RingTimeout { get; set; }

    /// <summary>
    /// Gets or Sets SLATime
    /// </summary>
    [DataMember(Name="SLATime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SLATime")]
    public int? SLATime { get; set; }

    /// <summary>
    /// Gets or Sets TypeOfChatOwnershipType
    /// </summary>
    [DataMember(Name="TypeOfChatOwnershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TypeOfChatOwnershipType")]
    public AllOfPbxQueueTypeOfChatOwnershipType TypeOfChatOwnershipType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxQueue {\n");
      sb.Append("  Agents: ").Append(Agents).Append("\n");
      sb.Append("  AnnounceQueuePosition: ").Append(AnnounceQueuePosition).Append("\n");
      sb.Append("  CallbackEnableTime: ").Append(CallbackEnableTime).Append("\n");
      sb.Append("  CallbackPrefix: ").Append(CallbackPrefix).Append("\n");
      sb.Append("  CallUsEnableChat: ").Append(CallUsEnableChat).Append("\n");
      sb.Append("  CallUsEnablePhone: ").Append(CallUsEnablePhone).Append("\n");
      sb.Append("  CallUsEnableVideo: ").Append(CallUsEnableVideo).Append("\n");
      sb.Append("  CallUsRequirement: ").Append(CallUsRequirement).Append("\n");
      sb.Append("  ClickToCallId: ").Append(ClickToCallId).Append("\n");
      sb.Append("  EnableIntro: ").Append(EnableIntro).Append("\n");
      sb.Append("  ForwardNoAnswer: ").Append(ForwardNoAnswer).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IntroFile: ").Append(IntroFile).Append("\n");
      sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
      sb.Append("  Managers: ").Append(Managers).Append("\n");
      sb.Append("  MasterTimeout: ").Append(MasterTimeout).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NotifyCodes: ").Append(NotifyCodes).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  OnHoldFile: ").Append(OnHoldFile).Append("\n");
      sb.Append("  PlayFullPrompt: ").Append(PlayFullPrompt).Append("\n");
      sb.Append("  PollingStrategy: ").Append(PollingStrategy).Append("\n");
      sb.Append("  PromptSet: ").Append(PromptSet).Append("\n");
      sb.Append("  Recording: ").Append(Recording).Append("\n");
      sb.Append("  RingTimeout: ").Append(RingTimeout).Append("\n");
      sb.Append("  SLATime: ").Append(SLATime).Append("\n");
      sb.Append("  TypeOfChatOwnershipType: ").Append(TypeOfChatOwnershipType).Append("\n");
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
