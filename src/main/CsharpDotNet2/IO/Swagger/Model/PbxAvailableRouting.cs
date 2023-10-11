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
  public class PbxAvailableRouting {
    /// <summary>
    /// Gets or Sets BusyAllCalls
    /// </summary>
    [DataMember(Name="BusyAllCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusyAllCalls")]
    public bool? BusyAllCalls { get; set; }

    /// <summary>
    /// Gets or Sets BusyExternal
    /// </summary>
    [DataMember(Name="BusyExternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusyExternal")]
    public AllOfPbxAvailableRoutingBusyExternal BusyExternal { get; set; }

    /// <summary>
    /// Gets or Sets BusyInternal
    /// </summary>
    [DataMember(Name="BusyInternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusyInternal")]
    public AllOfPbxAvailableRoutingBusyInternal BusyInternal { get; set; }

    /// <summary>
    /// Gets or Sets NoAnswerAllCalls
    /// </summary>
    [DataMember(Name="NoAnswerAllCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NoAnswerAllCalls")]
    public bool? NoAnswerAllCalls { get; set; }

    /// <summary>
    /// Gets or Sets NoAnswerExternal
    /// </summary>
    [DataMember(Name="NoAnswerExternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NoAnswerExternal")]
    public AllOfPbxAvailableRoutingNoAnswerExternal NoAnswerExternal { get; set; }

    /// <summary>
    /// Gets or Sets NoAnswerInternal
    /// </summary>
    [DataMember(Name="NoAnswerInternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NoAnswerInternal")]
    public AllOfPbxAvailableRoutingNoAnswerInternal NoAnswerInternal { get; set; }

    /// <summary>
    /// Gets or Sets NotRegisteredAllCalls
    /// </summary>
    [DataMember(Name="NotRegisteredAllCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotRegisteredAllCalls")]
    public bool? NotRegisteredAllCalls { get; set; }

    /// <summary>
    /// Gets or Sets NotRegisteredExternal
    /// </summary>
    [DataMember(Name="NotRegisteredExternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotRegisteredExternal")]
    public AllOfPbxAvailableRoutingNotRegisteredExternal NotRegisteredExternal { get; set; }

    /// <summary>
    /// Gets or Sets NotRegisteredInternal
    /// </summary>
    [DataMember(Name="NotRegisteredInternal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NotRegisteredInternal")]
    public AllOfPbxAvailableRoutingNotRegisteredInternal NotRegisteredInternal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxAvailableRouting {\n");
      sb.Append("  BusyAllCalls: ").Append(BusyAllCalls).Append("\n");
      sb.Append("  BusyExternal: ").Append(BusyExternal).Append("\n");
      sb.Append("  BusyInternal: ").Append(BusyInternal).Append("\n");
      sb.Append("  NoAnswerAllCalls: ").Append(NoAnswerAllCalls).Append("\n");
      sb.Append("  NoAnswerExternal: ").Append(NoAnswerExternal).Append("\n");
      sb.Append("  NoAnswerInternal: ").Append(NoAnswerInternal).Append("\n");
      sb.Append("  NotRegisteredAllCalls: ").Append(NotRegisteredAllCalls).Append("\n");
      sb.Append("  NotRegisteredExternal: ").Append(NotRegisteredExternal).Append("\n");
      sb.Append("  NotRegisteredInternal: ").Append(NotRegisteredInternal).Append("\n");
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
