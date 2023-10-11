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
  public class PbxFxsTemplate {
    /// <summary>
    /// Gets or Sets AllowedNetConfigs
    /// </summary>
    [DataMember(Name="AllowedNetConfigs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowedNetConfigs")]
    public List<string> AllowedNetConfigs { get; set; }

    /// <summary>
    /// Gets or Sets Brand
    /// </summary>
    [DataMember(Name="Brand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Gets or Sets DeviceType
    /// </summary>
    [DataMember(Name="DeviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeviceType")]
    public PbxDeviceType DeviceType { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Languages
    /// </summary>
    [DataMember(Name="Languages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Languages")]
    public List<string> Languages { get; set; }

    /// <summary>
    /// Gets or Sets Models
    /// </summary>
    [DataMember(Name="Models", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Models")]
    public List<PbxFxsModel> Models { get; set; }

    /// <summary>
    /// Gets or Sets NumberOfExtensions
    /// </summary>
    [DataMember(Name="NumberOfExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NumberOfExtensions")]
    public int? NumberOfExtensions { get; set; }

    /// <summary>
    /// Gets or Sets ProviderType
    /// </summary>
    [DataMember(Name="ProviderType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProviderType")]
    public PbxProviderType ProviderType { get; set; }

    /// <summary>
    /// Gets or Sets TimeZones
    /// </summary>
    [DataMember(Name="TimeZones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZones")]
    public List<string> TimeZones { get; set; }

    /// <summary>
    /// Gets or Sets URL
    /// </summary>
    [DataMember(Name="URL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "URL")]
    public string URL { get; set; }

    /// <summary>
    /// Gets or Sets Variables
    /// </summary>
    [DataMember(Name="Variables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Variables")]
    public List<PbxFxsVariable> Variables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxFxsTemplate {\n");
      sb.Append("  AllowedNetConfigs: ").Append(AllowedNetConfigs).Append("\n");
      sb.Append("  Brand: ").Append(Brand).Append("\n");
      sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Languages: ").Append(Languages).Append("\n");
      sb.Append("  Models: ").Append(Models).Append("\n");
      sb.Append("  NumberOfExtensions: ").Append(NumberOfExtensions).Append("\n");
      sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
      sb.Append("  TimeZones: ").Append(TimeZones).Append("\n");
      sb.Append("  URL: ").Append(URL).Append("\n");
      sb.Append("  Variables: ").Append(Variables).Append("\n");
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
