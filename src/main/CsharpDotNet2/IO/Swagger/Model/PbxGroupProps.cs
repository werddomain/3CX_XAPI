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
  public class PbxGroupProps {
    /// <summary>
    /// Gets or Sets DectMaxCount
    /// </summary>
    [DataMember(Name="DectMaxCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DectMaxCount")]
    public int? DectMaxCount { get; set; }

    /// <summary>
    /// Gets or Sets Fqdn
    /// </summary>
    [DataMember(Name="Fqdn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fqdn")]
    public string Fqdn { get; set; }

    /// <summary>
    /// Gets or Sets LiveChatMaxCount
    /// </summary>
    [DataMember(Name="LiveChatMaxCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LiveChatMaxCount")]
    public int? LiveChatMaxCount { get; set; }

    /// <summary>
    /// Gets or Sets PersonalContactsMaxCount
    /// </summary>
    [DataMember(Name="PersonalContactsMaxCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PersonalContactsMaxCount")]
    public int? PersonalContactsMaxCount { get; set; }

    /// <summary>
    /// Gets or Sets PromptsMaxCount
    /// </summary>
    [DataMember(Name="PromptsMaxCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptsMaxCount")]
    public int? PromptsMaxCount { get; set; }

    /// <summary>
    /// Gets or Sets ResellerId
    /// </summary>
    [DataMember(Name="ResellerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResellerId")]
    public string ResellerId { get; set; }

    /// <summary>
    /// Gets or Sets ResellerName
    /// </summary>
    [DataMember(Name="ResellerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ResellerName")]
    public string ResellerName { get; set; }

    /// <summary>
    /// Gets or Sets SbcMaxCount
    /// </summary>
    [DataMember(Name="SbcMaxCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SbcMaxCount")]
    public int? SbcMaxCount { get; set; }

    /// <summary>
    /// Gets or Sets StartupLicense
    /// </summary>
    [DataMember(Name="StartupLicense", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartupLicense")]
    public AllOfPbxGroupPropsStartupLicense StartupLicense { get; set; }

    /// <summary>
    /// Gets or Sets StartupOwnerEmail
    /// </summary>
    [DataMember(Name="StartupOwnerEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartupOwnerEmail")]
    public string StartupOwnerEmail { get; set; }

    /// <summary>
    /// Gets or Sets SubcriptionExpireDate
    /// </summary>
    [DataMember(Name="SubcriptionExpireDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubcriptionExpireDate")]
    public DateTime? SubcriptionExpireDate { get; set; }

    /// <summary>
    /// Gets or Sets Subscription
    /// </summary>
    [DataMember(Name="Subscription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subscription")]
    public string Subscription { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionType
    /// </summary>
    [DataMember(Name="SubscriptionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionType")]
    public string SubscriptionType { get; set; }

    /// <summary>
    /// Gets or Sets SystemNumberFrom
    /// </summary>
    [DataMember(Name="SystemNumberFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SystemNumberFrom")]
    public string SystemNumberFrom { get; set; }

    /// <summary>
    /// Gets or Sets SystemNumberTo
    /// </summary>
    [DataMember(Name="SystemNumberTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SystemNumberTo")]
    public string SystemNumberTo { get; set; }

    /// <summary>
    /// Gets or Sets TrunkNumberFrom
    /// </summary>
    [DataMember(Name="TrunkNumberFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TrunkNumberFrom")]
    public string TrunkNumberFrom { get; set; }

    /// <summary>
    /// Gets or Sets TrunkNumberTo
    /// </summary>
    [DataMember(Name="TrunkNumberTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TrunkNumberTo")]
    public string TrunkNumberTo { get; set; }

    /// <summary>
    /// Gets or Sets UserNumberFrom
    /// </summary>
    [DataMember(Name="UserNumberFrom", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserNumberFrom")]
    public string UserNumberFrom { get; set; }

    /// <summary>
    /// Gets or Sets UserNumberTo
    /// </summary>
    [DataMember(Name="UserNumberTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserNumberTo")]
    public string UserNumberTo { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxGroupProps {\n");
      sb.Append("  DectMaxCount: ").Append(DectMaxCount).Append("\n");
      sb.Append("  Fqdn: ").Append(Fqdn).Append("\n");
      sb.Append("  LiveChatMaxCount: ").Append(LiveChatMaxCount).Append("\n");
      sb.Append("  PersonalContactsMaxCount: ").Append(PersonalContactsMaxCount).Append("\n");
      sb.Append("  PromptsMaxCount: ").Append(PromptsMaxCount).Append("\n");
      sb.Append("  ResellerId: ").Append(ResellerId).Append("\n");
      sb.Append("  ResellerName: ").Append(ResellerName).Append("\n");
      sb.Append("  SbcMaxCount: ").Append(SbcMaxCount).Append("\n");
      sb.Append("  StartupLicense: ").Append(StartupLicense).Append("\n");
      sb.Append("  StartupOwnerEmail: ").Append(StartupOwnerEmail).Append("\n");
      sb.Append("  SubcriptionExpireDate: ").Append(SubcriptionExpireDate).Append("\n");
      sb.Append("  Subscription: ").Append(Subscription).Append("\n");
      sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
      sb.Append("  SystemNumberFrom: ").Append(SystemNumberFrom).Append("\n");
      sb.Append("  SystemNumberTo: ").Append(SystemNumberTo).Append("\n");
      sb.Append("  TrunkNumberFrom: ").Append(TrunkNumberFrom).Append("\n");
      sb.Append("  TrunkNumberTo: ").Append(TrunkNumberTo).Append("\n");
      sb.Append("  UserNumberFrom: ").Append(UserNumberFrom).Append("\n");
      sb.Append("  UserNumberTo: ").Append(UserNumberTo).Append("\n");
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
