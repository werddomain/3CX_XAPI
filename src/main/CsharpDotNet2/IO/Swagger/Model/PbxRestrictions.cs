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
  public class PbxRestrictions {
    /// <summary>
    /// Gets or Sets Dects
    /// </summary>
    [DataMember(Name="Dects", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Dects")]
    public AllOfPbxRestrictionsDects Dects { get; set; }

    /// <summary>
    /// Gets or Sets LiveChats
    /// </summary>
    [DataMember(Name="LiveChats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LiveChats")]
    public AllOfPbxRestrictionsLiveChats LiveChats { get; set; }

    /// <summary>
    /// Gets or Sets MaxPrompts
    /// </summary>
    [DataMember(Name="MaxPrompts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxPrompts")]
    public int? MaxPrompts { get; set; }

    /// <summary>
    /// Gets or Sets Sbcs
    /// </summary>
    [DataMember(Name="Sbcs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Sbcs")]
    public AllOfPbxRestrictionsSbcs Sbcs { get; set; }

    /// <summary>
    /// Gets or Sets System
    /// </summary>
    [DataMember(Name="System", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "System")]
    public AllOfPbxRestrictionsSystem System { get; set; }

    /// <summary>
    /// Gets or Sets Trunks
    /// </summary>
    [DataMember(Name="Trunks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Trunks")]
    public AllOfPbxRestrictionsTrunks Trunks { get; set; }

    /// <summary>
    /// Gets or Sets Users
    /// </summary>
    [DataMember(Name="Users", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Users")]
    public AllOfPbxRestrictionsUsers Users { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxRestrictions {\n");
      sb.Append("  Dects: ").Append(Dects).Append("\n");
      sb.Append("  LiveChats: ").Append(LiveChats).Append("\n");
      sb.Append("  MaxPrompts: ").Append(MaxPrompts).Append("\n");
      sb.Append("  Sbcs: ").Append(Sbcs).Append("\n");
      sb.Append("  System: ").Append(System).Append("\n");
      sb.Append("  Trunks: ").Append(Trunks).Append("\n");
      sb.Append("  Users: ").Append(Users).Append("\n");
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
