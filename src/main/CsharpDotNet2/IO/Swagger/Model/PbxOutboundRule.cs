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
  public class PbxOutboundRule {
    /// <summary>
    /// Gets or Sets DNRanges
    /// </summary>
    [DataMember(Name="DNRanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DNRanges")]
    public List<AllOfPbxOutboundRuleDNRangesItems> DNRanges { get; set; }

    /// <summary>
    /// Gets or Sets GroupIds
    /// </summary>
    [DataMember(Name="GroupIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupIds")]
    public List<int?> GroupIds { get; set; }

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
    /// Gets or Sets NumberLengthRanges
    /// </summary>
    [DataMember(Name="NumberLengthRanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberLengthRanges")]
    public string NumberLengthRanges { get; set; }

    /// <summary>
    /// Gets or Sets Prefix
    /// </summary>
    [DataMember(Name="Prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Prefix")]
    public string Prefix { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="Priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets Routes
    /// </summary>
    [DataMember(Name="Routes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Routes")]
    public List<AllOfPbxOutboundRuleRoutesItems> Routes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxOutboundRule {\n");
      sb.Append("  DNRanges: ").Append(DNRanges).Append("\n");
      sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NumberLengthRanges: ").Append(NumberLengthRanges).Append("\n");
      sb.Append("  Prefix: ").Append(Prefix).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Routes: ").Append(Routes).Append("\n");
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
