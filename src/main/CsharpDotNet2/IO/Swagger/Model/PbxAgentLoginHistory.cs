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
  public class PbxAgentLoginHistory {
    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [DataMember(Name="Agent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Agent")]
    public string Agent { get; set; }

    /// <summary>
    /// Gets or Sets AgentNo
    /// </summary>
    [DataMember(Name="AgentNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AgentNo")]
    public string AgentNo { get; set; }

    /// <summary>
    /// Gets or Sets Day
    /// </summary>
    [DataMember(Name="Day", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Day")]
    public DateTime? Day { get; set; }

    /// <summary>
    /// Gets or Sets LoggedInDayInterval
    /// </summary>
    [DataMember(Name="LoggedInDayInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LoggedInDayInterval")]
    public string LoggedInDayInterval { get; set; }

    /// <summary>
    /// Gets or Sets LoggedInDt
    /// </summary>
    [DataMember(Name="loggedInDt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loggedInDt")]
    public DateTime? LoggedInDt { get; set; }

    /// <summary>
    /// Gets or Sets LoggedInInterval
    /// </summary>
    [DataMember(Name="LoggedInInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LoggedInInterval")]
    public string LoggedInInterval { get; set; }

    /// <summary>
    /// Gets or Sets LoggedInTotalInterval
    /// </summary>
    [DataMember(Name="LoggedInTotalInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LoggedInTotalInterval")]
    public string LoggedInTotalInterval { get; set; }

    /// <summary>
    /// Gets or Sets LoggedOutDt
    /// </summary>
    [DataMember(Name="LoggedOutDt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LoggedOutDt")]
    public DateTime? LoggedOutDt { get; set; }

    /// <summary>
    /// Gets or Sets QueueNo
    /// </summary>
    [DataMember(Name="QueueNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueNo")]
    public string QueueNo { get; set; }

    /// <summary>
    /// Gets or Sets TalkingDayInterval
    /// </summary>
    [DataMember(Name="TalkingDayInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TalkingDayInterval")]
    public string TalkingDayInterval { get; set; }

    /// <summary>
    /// Gets or Sets TalkingInterval
    /// </summary>
    [DataMember(Name="TalkingInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TalkingInterval")]
    public string TalkingInterval { get; set; }

    /// <summary>
    /// Gets or Sets TalkingTotalInterval
    /// </summary>
    [DataMember(Name="TalkingTotalInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TalkingTotalInterval")]
    public string TalkingTotalInterval { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxAgentLoginHistory {\n");
      sb.Append("  Agent: ").Append(Agent).Append("\n");
      sb.Append("  AgentNo: ").Append(AgentNo).Append("\n");
      sb.Append("  Day: ").Append(Day).Append("\n");
      sb.Append("  LoggedInDayInterval: ").Append(LoggedInDayInterval).Append("\n");
      sb.Append("  LoggedInDt: ").Append(LoggedInDt).Append("\n");
      sb.Append("  LoggedInInterval: ").Append(LoggedInInterval).Append("\n");
      sb.Append("  LoggedInTotalInterval: ").Append(LoggedInTotalInterval).Append("\n");
      sb.Append("  LoggedOutDt: ").Append(LoggedOutDt).Append("\n");
      sb.Append("  QueueNo: ").Append(QueueNo).Append("\n");
      sb.Append("  TalkingDayInterval: ").Append(TalkingDayInterval).Append("\n");
      sb.Append("  TalkingInterval: ").Append(TalkingInterval).Append("\n");
      sb.Append("  TalkingTotalInterval: ").Append(TalkingTotalInterval).Append("\n");
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
