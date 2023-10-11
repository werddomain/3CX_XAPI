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
  public class PbxUserGroup {
    /// <summary>
    /// Gets or Sets GroupId
    /// </summary>
    [DataMember(Name="GroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupId")]
    public int? GroupId { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets MemberName
    /// </summary>
    [DataMember(Name="MemberName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemberName")]
    public string MemberName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets Rights
    /// </summary>
    [DataMember(Name="Rights", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Rights")]
    public AllOfPbxUserGroupRights Rights { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public AllOfPbxUserGroupType Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxUserGroup {\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MemberName: ").Append(MemberName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  Rights: ").Append(Rights).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
