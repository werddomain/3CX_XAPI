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
  public class PbxContact {
    /// <summary>
    /// Gets or Sets Business
    /// </summary>
    [DataMember(Name="Business", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Business")]
    public string Business { get; set; }

    /// <summary>
    /// Gets or Sets Business2
    /// </summary>
    [DataMember(Name="Business2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Business2")]
    public string Business2 { get; set; }

    /// <summary>
    /// Gets or Sets BusinessFax
    /// </summary>
    [DataMember(Name="BusinessFax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BusinessFax")]
    public string BusinessFax { get; set; }

    /// <summary>
    /// Gets or Sets CompanyName
    /// </summary>
    [DataMember(Name="CompanyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompanyName")]
    public string CompanyName { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="Email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets Home
    /// </summary>
    [DataMember(Name="Home", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Home")]
    public string Home { get; set; }

    /// <summary>
    /// Gets or Sets Home2
    /// </summary>
    [DataMember(Name="Home2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Home2")]
    public string Home2 { get; set; }

    /// <summary>
    /// Gets or Sets HomeFax
    /// </summary>
    [DataMember(Name="HomeFax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HomeFax")]
    public string HomeFax { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Mobile2
    /// </summary>
    [DataMember(Name="Mobile2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Mobile2")]
    public string Mobile2 { get; set; }

    /// <summary>
    /// Gets or Sets Other
    /// </summary>
    [DataMember(Name="Other", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Other")]
    public string Other { get; set; }

    /// <summary>
    /// Gets or Sets Pager
    /// </summary>
    [DataMember(Name="Pager", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Pager")]
    public string Pager { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets Tag
    /// </summary>
    [DataMember(Name="Tag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Tag")]
    public string Tag { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxContact {\n");
      sb.Append("  Business: ").Append(Business).Append("\n");
      sb.Append("  Business2: ").Append(Business2).Append("\n");
      sb.Append("  BusinessFax: ").Append(BusinessFax).Append("\n");
      sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Home: ").Append(Home).Append("\n");
      sb.Append("  Home2: ").Append(Home2).Append("\n");
      sb.Append("  HomeFax: ").Append(HomeFax).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Mobile2: ").Append(Mobile2).Append("\n");
      sb.Append("  Other: ").Append(Other).Append("\n");
      sb.Append("  Pager: ").Append(Pager).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  Tag: ").Append(Tag).Append("\n");
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
