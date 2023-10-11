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
  public class PbxChatMessagesHistoryView {
    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name="ConversationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConversationId")]
    public int? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets IsExternal
    /// </summary>
    [DataMember(Name="IsExternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsExternal")]
    public bool? IsExternal { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets MessageId
    /// </summary>
    [DataMember(Name="MessageId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MessageId")]
    public int? MessageId { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantsGroupsArray
    /// </summary>
    [DataMember(Name="ParticipantsGroupsArray", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantsGroupsArray")]
    public List<string> ParticipantsGroupsArray { get; set; }

    /// <summary>
    /// Gets or Sets QueueNumber
    /// </summary>
    [DataMember(Name="QueueNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueNumber")]
    public string QueueNumber { get; set; }

    /// <summary>
    /// Gets or Sets Recipients
    /// </summary>
    [DataMember(Name="Recipients", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Recipients")]
    public string Recipients { get; set; }

    /// <summary>
    /// Gets or Sets SenderParticipantEmail
    /// </summary>
    [DataMember(Name="SenderParticipantEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderParticipantEmail")]
    public string SenderParticipantEmail { get; set; }

    /// <summary>
    /// Gets or Sets SenderParticipantIp
    /// </summary>
    [DataMember(Name="SenderParticipantIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderParticipantIp")]
    public string SenderParticipantIp { get; set; }

    /// <summary>
    /// Gets or Sets SenderParticipantName
    /// </summary>
    [DataMember(Name="SenderParticipantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderParticipantName")]
    public string SenderParticipantName { get; set; }

    /// <summary>
    /// Gets or Sets SenderParticipantNo
    /// </summary>
    [DataMember(Name="SenderParticipantNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderParticipantNo")]
    public string SenderParticipantNo { get; set; }

    /// <summary>
    /// Gets or Sets SenderParticipantPbx
    /// </summary>
    [DataMember(Name="SenderParticipantPbx", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderParticipantPbx")]
    public string SenderParticipantPbx { get; set; }

    /// <summary>
    /// Gets or Sets SenderParticipantPhone
    /// </summary>
    [DataMember(Name="SenderParticipantPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SenderParticipantPhone")]
    public string SenderParticipantPhone { get; set; }

    /// <summary>
    /// Gets or Sets TimeSent
    /// </summary>
    [DataMember(Name="TimeSent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeSent")]
    public DateTime? TimeSent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxChatMessagesHistoryView {\n");
      sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
      sb.Append("  IsExternal: ").Append(IsExternal).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  MessageId: ").Append(MessageId).Append("\n");
      sb.Append("  ParticipantsGroupsArray: ").Append(ParticipantsGroupsArray).Append("\n");
      sb.Append("  QueueNumber: ").Append(QueueNumber).Append("\n");
      sb.Append("  Recipients: ").Append(Recipients).Append("\n");
      sb.Append("  SenderParticipantEmail: ").Append(SenderParticipantEmail).Append("\n");
      sb.Append("  SenderParticipantIp: ").Append(SenderParticipantIp).Append("\n");
      sb.Append("  SenderParticipantName: ").Append(SenderParticipantName).Append("\n");
      sb.Append("  SenderParticipantNo: ").Append(SenderParticipantNo).Append("\n");
      sb.Append("  SenderParticipantPbx: ").Append(SenderParticipantPbx).Append("\n");
      sb.Append("  SenderParticipantPhone: ").Append(SenderParticipantPhone).Append("\n");
      sb.Append("  TimeSent: ").Append(TimeSent).Append("\n");
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
