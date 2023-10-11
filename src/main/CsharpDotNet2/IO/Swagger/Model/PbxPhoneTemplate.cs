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
  public class PbxPhoneTemplate {
    /// <summary>
    /// Gets or Sets AddAllowed
    /// </summary>
    [DataMember(Name="AddAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AddAllowed")]
    public bool? AddAllowed { get; set; }

    /// <summary>
    /// Gets or Sets AllowedNetConfigs
    /// </summary>
    [DataMember(Name="AllowedNetConfigs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowedNetConfigs")]
    public List<string> AllowedNetConfigs { get; set; }

    /// <summary>
    /// Gets or Sets Codecs
    /// </summary>
    [DataMember(Name="Codecs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Codecs")]
    public List<string> Codecs { get; set; }

    /// <summary>
    /// Gets or Sets DateFormats
    /// </summary>
    [DataMember(Name="DateFormats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateFormats")]
    public List<string> DateFormats { get; set; }

    /// <summary>
    /// Gets or Sets DefaultQueueRingTone
    /// </summary>
    [DataMember(Name="DefaultQueueRingTone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultQueueRingTone")]
    public string DefaultQueueRingTone { get; set; }

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
    public List<AllOfPbxPhoneTemplateModelsItems> Models { get; set; }

    /// <summary>
    /// Gets or Sets QueueRingTones
    /// </summary>
    [DataMember(Name="QueueRingTones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueRingTones")]
    public List<string> QueueRingTones { get; set; }

    /// <summary>
    /// Gets or Sets RingTones
    /// </summary>
    [DataMember(Name="RingTones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingTones")]
    public List<string> RingTones { get; set; }

    /// <summary>
    /// Gets or Sets RpsEnabled
    /// </summary>
    [DataMember(Name="RpsEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RpsEnabled")]
    public bool? RpsEnabled { get; set; }

    /// <summary>
    /// Gets or Sets TemplateType
    /// </summary>
    [DataMember(Name="TemplateType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TemplateType")]
    public AllOfPbxPhoneTemplateTemplateType TemplateType { get; set; }

    /// <summary>
    /// Gets or Sets TimeFormats
    /// </summary>
    [DataMember(Name="TimeFormats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeFormats")]
    public List<string> TimeFormats { get; set; }

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
    /// Gets or Sets XferTypeEnabled
    /// </summary>
    [DataMember(Name="XferTypeEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "XferTypeEnabled")]
    public bool? XferTypeEnabled { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxPhoneTemplate {\n");
      sb.Append("  AddAllowed: ").Append(AddAllowed).Append("\n");
      sb.Append("  AllowedNetConfigs: ").Append(AllowedNetConfigs).Append("\n");
      sb.Append("  Codecs: ").Append(Codecs).Append("\n");
      sb.Append("  DateFormats: ").Append(DateFormats).Append("\n");
      sb.Append("  DefaultQueueRingTone: ").Append(DefaultQueueRingTone).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Languages: ").Append(Languages).Append("\n");
      sb.Append("  Models: ").Append(Models).Append("\n");
      sb.Append("  QueueRingTones: ").Append(QueueRingTones).Append("\n");
      sb.Append("  RingTones: ").Append(RingTones).Append("\n");
      sb.Append("  RpsEnabled: ").Append(RpsEnabled).Append("\n");
      sb.Append("  TemplateType: ").Append(TemplateType).Append("\n");
      sb.Append("  TimeFormats: ").Append(TimeFormats).Append("\n");
      sb.Append("  TimeZones: ").Append(TimeZones).Append("\n");
      sb.Append("  URL: ").Append(URL).Append("\n");
      sb.Append("  XferTypeEnabled: ").Append(XferTypeEnabled).Append("\n");
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
