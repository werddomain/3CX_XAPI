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
  public class ReferenceUpdate {
    /// <summary>
    /// Gets or Sets OdataId
    /// </summary>
    [DataMember(Name="@odata.id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@odata.id")]
    public string OdataId { get; set; }

    /// <summary>
    /// Gets or Sets OdataType
    /// </summary>
    [DataMember(Name="@odata.type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "@odata.type")]
    public string OdataType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReferenceUpdate {\n");
      sb.Append("  OdataId: ").Append(OdataId).Append("\n");
      sb.Append("  OdataType: ").Append(OdataType).Append("\n");
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
