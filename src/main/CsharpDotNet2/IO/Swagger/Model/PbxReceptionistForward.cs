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
  public class PbxReceptionistForward {
    /// <summary>
    /// Gets or Sets CustomData
    /// </summary>
    [DataMember(Name="CustomData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomData")]
    public string CustomData { get; set; }

    /// <summary>
    /// Gets or Sets ForwardDN
    /// </summary>
    [DataMember(Name="ForwardDN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForwardDN")]
    public string ForwardDN { get; set; }

    /// <summary>
    /// Gets or Sets ForwardType
    /// </summary>
    [DataMember(Name="ForwardType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForwardType")]
    public PbxIVRForwardType ForwardType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Input
    /// </summary>
    [DataMember(Name="Input", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Input")]
    public string Input { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxReceptionistForward {\n");
      sb.Append("  CustomData: ").Append(CustomData).Append("\n");
      sb.Append("  ForwardDN: ").Append(ForwardDN).Append("\n");
      sb.Append("  ForwardType: ").Append(ForwardType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Input: ").Append(Input).Append("\n");
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
