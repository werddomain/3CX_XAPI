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
  public class PbxBackupContents {
    /// <summary>
    /// Gets or Sets CallHistory
    /// </summary>
    [DataMember(Name="CallHistory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallHistory")]
    public bool? CallHistory { get; set; }

    /// <summary>
    /// Gets or Sets EncryptBackup
    /// </summary>
    [DataMember(Name="EncryptBackup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EncryptBackup")]
    public bool? EncryptBackup { get; set; }

    /// <summary>
    /// Gets or Sets EncryptBackupPassword
    /// </summary>
    [DataMember(Name="EncryptBackupPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EncryptBackupPassword")]
    public string EncryptBackupPassword { get; set; }

    /// <summary>
    /// Gets or Sets FQDN
    /// </summary>
    [DataMember(Name="FQDN", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FQDN")]
    public bool? FQDN { get; set; }

    /// <summary>
    /// Gets or Sets License
    /// </summary>
    [DataMember(Name="License", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "License")]
    public bool? License { get; set; }

    /// <summary>
    /// Gets or Sets PhoneProvisioning
    /// </summary>
    [DataMember(Name="PhoneProvisioning", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PhoneProvisioning")]
    public bool? PhoneProvisioning { get; set; }

    /// <summary>
    /// Gets or Sets Prompts
    /// </summary>
    [DataMember(Name="Prompts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Prompts")]
    public bool? Prompts { get; set; }

    /// <summary>
    /// Gets or Sets Recordings
    /// </summary>
    [DataMember(Name="Recordings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Recordings")]
    public bool? Recordings { get; set; }

    /// <summary>
    /// Gets or Sets VoiceMails
    /// </summary>
    [DataMember(Name="VoiceMails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VoiceMails")]
    public bool? VoiceMails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxBackupContents {\n");
      sb.Append("  CallHistory: ").Append(CallHistory).Append("\n");
      sb.Append("  EncryptBackup: ").Append(EncryptBackup).Append("\n");
      sb.Append("  EncryptBackupPassword: ").Append(EncryptBackupPassword).Append("\n");
      sb.Append("  FQDN: ").Append(FQDN).Append("\n");
      sb.Append("  License: ").Append(License).Append("\n");
      sb.Append("  PhoneProvisioning: ").Append(PhoneProvisioning).Append("\n");
      sb.Append("  Prompts: ").Append(Prompts).Append("\n");
      sb.Append("  Recordings: ").Append(Recordings).Append("\n");
      sb.Append("  VoiceMails: ").Append(VoiceMails).Append("\n");
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
