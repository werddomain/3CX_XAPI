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
  public class PbxPhoneSettings {
    /// <summary>
    /// Gets or Sets Backlight
    /// </summary>
    [DataMember(Name="Backlight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Backlight")]
    public string Backlight { get; set; }

    /// <summary>
    /// Gets or Sets Codecs
    /// </summary>
    [DataMember(Name="Codecs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Codecs")]
    public List<string> Codecs { get; set; }

    /// <summary>
    /// Gets or Sets DateFormat
    /// </summary>
    [DataMember(Name="DateFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DateFormat")]
    public string DateFormat { get; set; }

    /// <summary>
    /// Gets or Sets Firmware
    /// </summary>
    [DataMember(Name="Firmware", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Firmware")]
    public string Firmware { get; set; }

    /// <summary>
    /// Gets or Sets FirmwareLang
    /// </summary>
    [DataMember(Name="FirmwareLang", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirmwareLang")]
    public string FirmwareLang { get; set; }

    /// <summary>
    /// Gets or Sets IsSBC
    /// </summary>
    [DataMember(Name="IsSBC", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSBC")]
    public bool? IsSBC { get; set; }

    /// <summary>
    /// Gets or Sets LocalRTPPortEnd
    /// </summary>
    [DataMember(Name="LocalRTPPortEnd", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalRTPPortEnd")]
    public int? LocalRTPPortEnd { get; set; }

    /// <summary>
    /// Gets or Sets LocalRTPPortStart
    /// </summary>
    [DataMember(Name="LocalRTPPortStart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalRTPPortStart")]
    public int? LocalRTPPortStart { get; set; }

    /// <summary>
    /// Gets or Sets LocalSipPort
    /// </summary>
    [DataMember(Name="LocalSipPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalSipPort")]
    public int? LocalSipPort { get; set; }

    /// <summary>
    /// Gets or Sets OwnBlfs
    /// </summary>
    [DataMember(Name="OwnBlfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnBlfs")]
    public bool? OwnBlfs { get; set; }

    /// <summary>
    /// Gets or Sets PhoneLanguage
    /// </summary>
    [DataMember(Name="PhoneLanguage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneLanguage")]
    public string PhoneLanguage { get; set; }

    /// <summary>
    /// Gets or Sets PowerLed
    /// </summary>
    [DataMember(Name="PowerLed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PowerLed")]
    public string PowerLed { get; set; }

    /// <summary>
    /// Gets or Sets ProvisionExtendedData
    /// </summary>
    [DataMember(Name="ProvisionExtendedData", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProvisionExtendedData")]
    public string ProvisionExtendedData { get; set; }

    /// <summary>
    /// Gets or Sets ProvisionType
    /// </summary>
    [DataMember(Name="ProvisionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProvisionType")]
    public AllOfPbxPhoneSettingsProvisionType ProvisionType { get; set; }

    /// <summary>
    /// Gets or Sets QueueRingTone
    /// </summary>
    [DataMember(Name="QueueRingTone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "QueueRingTone")]
    public string QueueRingTone { get; set; }

    /// <summary>
    /// Gets or Sets RemoteSpmHost
    /// </summary>
    [DataMember(Name="RemoteSpmHost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemoteSpmHost")]
    public string RemoteSpmHost { get; set; }

    /// <summary>
    /// Gets or Sets RemoteSpmPort
    /// </summary>
    [DataMember(Name="RemoteSpmPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemoteSpmPort")]
    public int? RemoteSpmPort { get; set; }

    /// <summary>
    /// Gets or Sets RingTone
    /// </summary>
    [DataMember(Name="RingTone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RingTone")]
    public string RingTone { get; set; }

    /// <summary>
    /// Gets or Sets SbcName
    /// </summary>
    [DataMember(Name="SbcName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SbcName")]
    public string SbcName { get; set; }

    /// <summary>
    /// Gets or Sets ScreenSaver
    /// </summary>
    [DataMember(Name="ScreenSaver", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScreenSaver")]
    public string ScreenSaver { get; set; }

    /// <summary>
    /// Gets or Sets Secret
    /// </summary>
    [DataMember(Name="Secret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Secret")]
    public string Secret { get; set; }

    /// <summary>
    /// Gets or Sets Srtp
    /// </summary>
    [DataMember(Name="Srtp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Srtp")]
    public string Srtp { get; set; }

    /// <summary>
    /// Gets or Sets TimeFormat
    /// </summary>
    [DataMember(Name="TimeFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeFormat")]
    public string TimeFormat { get; set; }

    /// <summary>
    /// Gets or Sets TimeZone
    /// </summary>
    [DataMember(Name="TimeZone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeZone")]
    public string TimeZone { get; set; }

    /// <summary>
    /// Gets or Sets XferType
    /// </summary>
    [DataMember(Name="XferType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "XferType")]
    public AllOfPbxPhoneSettingsXferType XferType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxPhoneSettings {\n");
      sb.Append("  Backlight: ").Append(Backlight).Append("\n");
      sb.Append("  Codecs: ").Append(Codecs).Append("\n");
      sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
      sb.Append("  Firmware: ").Append(Firmware).Append("\n");
      sb.Append("  FirmwareLang: ").Append(FirmwareLang).Append("\n");
      sb.Append("  IsSBC: ").Append(IsSBC).Append("\n");
      sb.Append("  LocalRTPPortEnd: ").Append(LocalRTPPortEnd).Append("\n");
      sb.Append("  LocalRTPPortStart: ").Append(LocalRTPPortStart).Append("\n");
      sb.Append("  LocalSipPort: ").Append(LocalSipPort).Append("\n");
      sb.Append("  OwnBlfs: ").Append(OwnBlfs).Append("\n");
      sb.Append("  PhoneLanguage: ").Append(PhoneLanguage).Append("\n");
      sb.Append("  PowerLed: ").Append(PowerLed).Append("\n");
      sb.Append("  ProvisionExtendedData: ").Append(ProvisionExtendedData).Append("\n");
      sb.Append("  ProvisionType: ").Append(ProvisionType).Append("\n");
      sb.Append("  QueueRingTone: ").Append(QueueRingTone).Append("\n");
      sb.Append("  RemoteSpmHost: ").Append(RemoteSpmHost).Append("\n");
      sb.Append("  RemoteSpmPort: ").Append(RemoteSpmPort).Append("\n");
      sb.Append("  RingTone: ").Append(RingTone).Append("\n");
      sb.Append("  SbcName: ").Append(SbcName).Append("\n");
      sb.Append("  ScreenSaver: ").Append(ScreenSaver).Append("\n");
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      sb.Append("  Srtp: ").Append(Srtp).Append("\n");
      sb.Append("  TimeFormat: ").Append(TimeFormat).Append("\n");
      sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
      sb.Append("  XferType: ").Append(XferType).Append("\n");
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
