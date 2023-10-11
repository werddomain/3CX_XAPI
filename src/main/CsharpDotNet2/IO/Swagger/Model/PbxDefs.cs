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
  public class PbxDefs {
    /// <summary>
    /// Gets or Sets Codecs
    /// </summary>
    [DataMember(Name="Codecs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Codecs")]
    public List<PbxCodec> Codecs { get; set; }

    /// <summary>
    /// Gets or Sets GatewayParameters
    /// </summary>
    [DataMember(Name="GatewayParameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayParameters")]
    public List<PbxGatewayParameter> GatewayParameters { get; set; }

    /// <summary>
    /// Gets or Sets GatewayParameterValues
    /// </summary>
    [DataMember(Name="GatewayParameterValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GatewayParameterValues")]
    public List<PbxGatewayParameterValue> GatewayParameterValues { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets TimeZones
    /// </summary>
    [DataMember(Name="TimeZones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZones")]
    public List<PbxTimeZone> TimeZones { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxDefs {\n");
      sb.Append("  Codecs: ").Append(Codecs).Append("\n");
      sb.Append("  GatewayParameters: ").Append(GatewayParameters).Append("\n");
      sb.Append("  GatewayParameterValues: ").Append(GatewayParameterValues).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TimeZones: ").Append(TimeZones).Append("\n");
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
