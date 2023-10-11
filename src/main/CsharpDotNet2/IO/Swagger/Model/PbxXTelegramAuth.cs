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
  public class PbxXTelegramAuth {
    /// <summary>
    /// Gets or Sets ApiHash
    /// </summary>
    [DataMember(Name="ApiHash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApiHash")]
    public string ApiHash { get; set; }

    /// <summary>
    /// Gets or Sets ApiId
    /// </summary>
    [DataMember(Name="ApiId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApiId")]
    public string ApiId { get; set; }

    /// <summary>
    /// Gets or Sets RequiredFields
    /// </summary>
    [DataMember(Name="RequiredFields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredFields")]
    public List<PbxKeyValuePair2OfStringString> RequiredFields { get; set; }

    /// <summary>
    /// Gets or Sets Session
    /// </summary>
    [DataMember(Name="Session", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Session")]
    public string Session { get; set; }

    /// <summary>
    /// Gets or Sets TrunkNo
    /// </summary>
    [DataMember(Name="TrunkNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TrunkNo")]
    public string TrunkNo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxXTelegramAuth {\n");
      sb.Append("  ApiHash: ").Append(ApiHash).Append("\n");
      sb.Append("  ApiId: ").Append(ApiId).Append("\n");
      sb.Append("  RequiredFields: ").Append(RequiredFields).Append("\n");
      sb.Append("  Session: ").Append(Session).Append("\n");
      sb.Append("  TrunkNo: ").Append(TrunkNo).Append("\n");
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
