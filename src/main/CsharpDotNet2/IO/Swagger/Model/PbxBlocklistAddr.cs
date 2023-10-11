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
  public class PbxBlocklistAddr {
    /// <summary>
    /// Gets or Sets AddedBy
    /// </summary>
    [DataMember(Name="AddedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AddedBy")]
    public AllOfPbxBlocklistAddrAddedBy AddedBy { get; set; }

    /// <summary>
    /// Gets or Sets BlockType
    /// </summary>
    [DataMember(Name="BlockType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BlockType")]
    public AllOfPbxBlocklistAddrBlockType BlockType { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresAt
    /// </summary>
    [DataMember(Name="ExpiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpiresAt")]
    public DateTime? ExpiresAt { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets IPAddrMask
    /// </summary>
    [DataMember(Name="IPAddrMask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IPAddrMask")]
    public string IPAddrMask { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxBlocklistAddr {\n");
      sb.Append("  AddedBy: ").Append(AddedBy).Append("\n");
      sb.Append("  BlockType: ").Append(BlockType).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IPAddrMask: ").Append(IPAddrMask).Append("\n");
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
