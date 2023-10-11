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
  public class PbxCountry {
    /// <summary>
    /// Gets or Sets Continent
    /// </summary>
    [DataMember(Name="Continent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Continent")]
    public string Continent { get; set; }

    /// <summary>
    /// Gets or Sets CountryCode
    /// </summary>
    [DataMember(Name="CountryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or Sets CountryCodes
    /// </summary>
    [DataMember(Name="CountryCodes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CountryCodes")]
    public List<string> CountryCodes { get; set; }

    /// <summary>
    /// Gets or Sets DownloadUrl
    /// </summary>
    [DataMember(Name="DownloadUrl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DownloadUrl")]
    public string DownloadUrl { get; set; }

    /// <summary>
    /// Gets or Sets ErpCode
    /// </summary>
    [DataMember(Name="ErpCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErpCode")]
    public string ErpCode { get; set; }

    /// <summary>
    /// Gets or Sets ExitCode
    /// </summary>
    [DataMember(Name="ExitCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExitCode")]
    public string ExitCode { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ParentErpCode
    /// </summary>
    [DataMember(Name="ParentErpCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentErpCode")]
    public string ParentErpCode { get; set; }

    /// <summary>
    /// Gets or Sets StunServer
    /// </summary>
    [DataMember(Name="StunServer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StunServer")]
    public string StunServer { get; set; }

    /// <summary>
    /// Gets or Sets VoicemailNo
    /// </summary>
    [DataMember(Name="VoicemailNo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VoicemailNo")]
    public string VoicemailNo { get; set; }

    /// <summary>
    /// Gets or Sets WebMeetingZone
    /// </summary>
    [DataMember(Name="WebMeetingZone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebMeetingZone")]
    public string WebMeetingZone { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxCountry {\n");
      sb.Append("  Continent: ").Append(Continent).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  CountryCodes: ").Append(CountryCodes).Append("\n");
      sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
      sb.Append("  ErpCode: ").Append(ErpCode).Append("\n");
      sb.Append("  ExitCode: ").Append(ExitCode).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ParentErpCode: ").Append(ParentErpCode).Append("\n");
      sb.Append("  StunServer: ").Append(StunServer).Append("\n");
      sb.Append("  VoicemailNo: ").Append(VoicemailNo).Append("\n");
      sb.Append("  WebMeetingZone: ").Append(WebMeetingZone).Append("\n");
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
