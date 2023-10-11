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
  public class PbxAbandonedChatsStatistics {
    /// <summary>
    /// Gets or Sets ChatId
    /// </summary>
    [DataMember(Name="ChatId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChatId")]
    public int? ChatId { get; set; }

    /// <summary>
    /// Gets or Sets DateOfRequest
    /// </summary>
    [DataMember(Name="DateOfRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateOfRequest")]
    public DateTime? DateOfRequest { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantEmail
    /// </summary>
    [DataMember(Name="ParticipantEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantEmail")]
    public string ParticipantEmail { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantMessage
    /// </summary>
    [DataMember(Name="ParticipantMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantMessage")]
    public string ParticipantMessage { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantName
    /// </summary>
    [DataMember(Name="ParticipantName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantName")]
    public string ParticipantName { get; set; }

    /// <summary>
    /// Gets or Sets ParticipantNumber
    /// </summary>
    [DataMember(Name="ParticipantNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParticipantNumber")]
    public string ParticipantNumber { get; set; }

    /// <summary>
    /// Gets or Sets QueueDisplayName
    /// </summary>
    [DataMember(Name="QueueDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueDisplayName")]
    public string QueueDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets QueueNo
    /// </summary>
    [DataMember(Name="QueueNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueNo")]
    public string QueueNo { get; set; }

    /// <summary>
    /// Gets or Sets ReasonForAbandoned
    /// </summary>
    [DataMember(Name="ReasonForAbandoned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonForAbandoned")]
    public string ReasonForAbandoned { get; set; }

    /// <summary>
    /// Gets or Sets ReasonForDealtWith
    /// </summary>
    [DataMember(Name="ReasonForDealtWith", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonForDealtWith")]
    public string ReasonForDealtWith { get; set; }

    /// <summary>
    /// Gets or Sets Source
    /// </summary>
    [DataMember(Name="Source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Source")]
    public string Source { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxAbandonedChatsStatistics {\n");
      sb.Append("  ChatId: ").Append(ChatId).Append("\n");
      sb.Append("  DateOfRequest: ").Append(DateOfRequest).Append("\n");
      sb.Append("  ParticipantEmail: ").Append(ParticipantEmail).Append("\n");
      sb.Append("  ParticipantMessage: ").Append(ParticipantMessage).Append("\n");
      sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
      sb.Append("  ParticipantNumber: ").Append(ParticipantNumber).Append("\n");
      sb.Append("  QueueDisplayName: ").Append(QueueDisplayName).Append("\n");
      sb.Append("  QueueNo: ").Append(QueueNo).Append("\n");
      sb.Append("  ReasonForAbandoned: ").Append(ReasonForAbandoned).Append("\n");
      sb.Append("  ReasonForDealtWith: ").Append(ReasonForDealtWith).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
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
