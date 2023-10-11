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
  public class PbxForwardingProfile {
    /// <summary>
    /// Gets or Sets AcceptMultipleCalls
    /// </summary>
    [DataMember(Name="AcceptMultipleCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AcceptMultipleCalls")]
    public bool? AcceptMultipleCalls { get; set; }

    /// <summary>
    /// Gets or Sets AvailableRoute
    /// </summary>
    [DataMember(Name="AvailableRoute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AvailableRoute")]
    public AllOfPbxForwardingProfileAvailableRoute AvailableRoute { get; set; }

    /// <summary>
    /// Gets or Sets AwayRoute
    /// </summary>
    [DataMember(Name="AwayRoute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AwayRoute")]
    public AllOfPbxForwardingProfileAwayRoute AwayRoute { get; set; }

    /// <summary>
    /// Gets or Sets BlockPushCalls
    /// </summary>
    [DataMember(Name="BlockPushCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BlockPushCalls")]
    public bool? BlockPushCalls { get; set; }

    /// <summary>
    /// Gets or Sets CustomMessage
    /// </summary>
    [DataMember(Name="CustomMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomMessage")]
    public string CustomMessage { get; set; }

    /// <summary>
    /// Gets or Sets CustomName
    /// </summary>
    [DataMember(Name="CustomName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomName")]
    public string CustomName { get; set; }

    /// <summary>
    /// Gets or Sets DisableRingGroupCalls
    /// </summary>
    [DataMember(Name="DisableRingGroupCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisableRingGroupCalls")]
    public bool? DisableRingGroupCalls { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NoAnswerTimeout
    /// </summary>
    [DataMember(Name="NoAnswerTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NoAnswerTimeout")]
    public int? NoAnswerTimeout { get; set; }

    /// <summary>
    /// Gets or Sets OfficeHoursAutoQueueLogOut
    /// </summary>
    [DataMember(Name="OfficeHoursAutoQueueLogOut", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfficeHoursAutoQueueLogOut")]
    public bool? OfficeHoursAutoQueueLogOut { get; set; }

    /// <summary>
    /// Gets or Sets RingMyMobile
    /// </summary>
    [DataMember(Name="RingMyMobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingMyMobile")]
    public bool? RingMyMobile { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxForwardingProfile {\n");
      sb.Append("  AcceptMultipleCalls: ").Append(AcceptMultipleCalls).Append("\n");
      sb.Append("  AvailableRoute: ").Append(AvailableRoute).Append("\n");
      sb.Append("  AwayRoute: ").Append(AwayRoute).Append("\n");
      sb.Append("  BlockPushCalls: ").Append(BlockPushCalls).Append("\n");
      sb.Append("  CustomMessage: ").Append(CustomMessage).Append("\n");
      sb.Append("  CustomName: ").Append(CustomName).Append("\n");
      sb.Append("  DisableRingGroupCalls: ").Append(DisableRingGroupCalls).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NoAnswerTimeout: ").Append(NoAnswerTimeout).Append("\n");
      sb.Append("  OfficeHoursAutoQueueLogOut: ").Append(OfficeHoursAutoQueueLogOut).Append("\n");
      sb.Append("  RingMyMobile: ").Append(RingMyMobile).Append("\n");
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
