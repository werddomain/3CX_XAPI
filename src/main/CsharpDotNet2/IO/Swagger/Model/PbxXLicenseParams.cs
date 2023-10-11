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
  public class PbxXLicenseParams {
    /// <summary>
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or Sets ContactName
    /// </summary>
    [DataMember(Name="ContactName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactName")]
    public string ContactName { get; set; }

    /// <summary>
    /// Gets or Sets Country
    /// </summary>
    [DataMember(Name="Country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets Phone
    /// </summary>
    [DataMember(Name="Phone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phone")]
    public string Phone { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxXLicenseParams {\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  ContactName: ").Append(ContactName).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Phone: ").Append(Phone).Append("\n");
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
