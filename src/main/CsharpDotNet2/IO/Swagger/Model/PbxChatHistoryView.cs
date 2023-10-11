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
  public class PbxChatHistoryView {
    /// <summary>
    /// Gets or Sets ChatName
    /// </summary>
    [DataMember(Name="ChatName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChatName")]
    public string ChatName { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name="ConversationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConversationId")]
    public int? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets FromName
    /// </summary>
    [DataMember(Name="FromName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FromName")]
    public string FromName { get; set; }

    /// <summary>
    /// Gets or Sets FromNo
    /// </summary>
    [DataMember(Name="FromNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FromNo")]
    public string FromNo { get; set; }

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
    /// Gets or Sets ParticipantEmail
    /// </summary>
    [DataMember(Name="ParticipantEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantEmail")]
    public string ParticipantEmail { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantIp
    /// </summary>
    [DataMember(Name="ParticipantIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantIp")]
    public string ParticipantIp { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantPhone
    /// </summary>
    [DataMember(Name="ParticipantPhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantPhone")]
    public string ParticipantPhone { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantsGroupsArray
    /// </summary>
    [DataMember(Name="ParticipantsGroupsArray", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantsGroupsArray")]
    public List<string> ParticipantsGroupsArray { get; set; }

    /// <summary>
    /// Gets or Sets ProviderName
    /// </summary>
    [DataMember(Name="ProviderName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProviderName")]
    public string ProviderName { get; set; }

    /// <summary>
    /// Gets or Sets ProviderType
    /// </summary>
    [DataMember(Name="ProviderType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProviderType")]
    public AllOfPbxChatHistoryViewProviderType ProviderType { get; set; }

    /// <summary>
    /// Gets or Sets QueueNumber
    /// </summary>
    [DataMember(Name="QueueNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueNumber")]
    public string QueueNumber { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="Source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Source")]
    public string Source { get; set; }

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
      sb.Append("class PbxChatHistoryView {\n");
      sb.Append("  ChatName: ").Append(ChatName).Append("\n");
      sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
      sb.Append("  FromName: ").Append(FromName).Append("\n");
      sb.Append("  FromNo: ").Append(FromNo).Append("\n");
      sb.Append("  IsExternal: ").Append(IsExternal).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  ParticipantEmail: ").Append(ParticipantEmail).Append("\n");
      sb.Append("  ParticipantIp: ").Append(ParticipantIp).Append("\n");
      sb.Append("  ParticipantPhone: ").Append(ParticipantPhone).Append("\n");
      sb.Append("  ParticipantsGroupsArray: ").Append(ParticipantsGroupsArray).Append("\n");
      sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
      sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
      sb.Append("  QueueNumber: ").Append(QueueNumber).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
