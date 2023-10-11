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
  public class PbxLocationSettings {
    /// <summary>
    /// Gets or Sets FileSystemType
    /// </summary>
    [DataMember(Name="FileSystemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FileSystemType")]
    public AllOfPbxLocationSettingsFileSystemType FileSystemType { get; set; }

    /// <summary>
    /// Gets or Sets FtpPassword
    /// </summary>
    [DataMember(Name="FtpPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FtpPassword")]
    public string FtpPassword { get; set; }

    /// <summary>
    /// Gets or Sets FtpPath
    /// </summary>
    [DataMember(Name="FtpPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FtpPath")]
    public string FtpPath { get; set; }

    /// <summary>
    /// Gets or Sets FtpUser
    /// </summary>
    [DataMember(Name="FtpUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FtpUser")]
    public string FtpUser { get; set; }

    /// <summary>
    /// Gets or Sets GbJson
    /// </summary>
    [DataMember(Name="GbJson", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GbJson")]
    public string GbJson { get; set; }

    /// <summary>
    /// Gets or Sets GbJsonFileName
    /// </summary>
    [DataMember(Name="GbJsonFileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GbJsonFileName")]
    public string GbJsonFileName { get; set; }

    /// <summary>
    /// Gets or Sets GbPath
    /// </summary>
    [DataMember(Name="GbPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GbPath")]
    public string GbPath { get; set; }

    /// <summary>
    /// Gets or Sets LocalPath
    /// </summary>
    [DataMember(Name="LocalPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LocalPath")]
    public string LocalPath { get; set; }

    /// <summary>
    /// Gets or Sets NsDomain
    /// </summary>
    [DataMember(Name="NsDomain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NsDomain")]
    public string NsDomain { get; set; }

    /// <summary>
    /// Gets or Sets NsPassword
    /// </summary>
    [DataMember(Name="NsPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NsPassword")]
    public string NsPassword { get; set; }

    /// <summary>
    /// Gets or Sets NsPath
    /// </summary>
    [DataMember(Name="NsPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NsPath")]
    public string NsPath { get; set; }

    /// <summary>
    /// Gets or Sets NsUser
    /// </summary>
    [DataMember(Name="NsUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NsUser")]
    public string NsUser { get; set; }

    /// <summary>
    /// Gets or Sets SftpPassword
    /// </summary>
    [DataMember(Name="SftpPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SftpPassword")]
    public string SftpPassword { get; set; }

    /// <summary>
    /// Gets or Sets SftpPath
    /// </summary>
    [DataMember(Name="SftpPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SftpPath")]
    public string SftpPath { get; set; }

    /// <summary>
    /// Gets or Sets SftpPrivateKey
    /// </summary>
    [DataMember(Name="SftpPrivateKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SftpPrivateKey")]
    public string SftpPrivateKey { get; set; }

    /// <summary>
    /// Gets or Sets SftpPrivateKeyName
    /// </summary>
    [DataMember(Name="SftpPrivateKeyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SftpPrivateKeyName")]
    public string SftpPrivateKeyName { get; set; }

    /// <summary>
    /// Gets or Sets SftpUser
    /// </summary>
    [DataMember(Name="SftpUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SftpUser")]
    public string SftpUser { get; set; }

    /// <summary>
    /// Gets or Sets SharePointPath
    /// </summary>
    [DataMember(Name="SharePointPath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SharePointPath")]
    public string SharePointPath { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxLocationSettings {\n");
      sb.Append("  FileSystemType: ").Append(FileSystemType).Append("\n");
      sb.Append("  FtpPassword: ").Append(FtpPassword).Append("\n");
      sb.Append("  FtpPath: ").Append(FtpPath).Append("\n");
      sb.Append("  FtpUser: ").Append(FtpUser).Append("\n");
      sb.Append("  GbJson: ").Append(GbJson).Append("\n");
      sb.Append("  GbJsonFileName: ").Append(GbJsonFileName).Append("\n");
      sb.Append("  GbPath: ").Append(GbPath).Append("\n");
      sb.Append("  LocalPath: ").Append(LocalPath).Append("\n");
      sb.Append("  NsDomain: ").Append(NsDomain).Append("\n");
      sb.Append("  NsPassword: ").Append(NsPassword).Append("\n");
      sb.Append("  NsPath: ").Append(NsPath).Append("\n");
      sb.Append("  NsUser: ").Append(NsUser).Append("\n");
      sb.Append("  SftpPassword: ").Append(SftpPassword).Append("\n");
      sb.Append("  SftpPath: ").Append(SftpPath).Append("\n");
      sb.Append("  SftpPrivateKey: ").Append(SftpPrivateKey).Append("\n");
      sb.Append("  SftpPrivateKeyName: ").Append(SftpPrivateKeyName).Append("\n");
      sb.Append("  SftpUser: ").Append(SftpUser).Append("\n");
      sb.Append("  SharePointPath: ").Append(SharePointPath).Append("\n");
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
