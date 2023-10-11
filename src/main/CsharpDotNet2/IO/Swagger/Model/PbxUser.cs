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
  public class PbxUser {
    /// <summary>
    /// Gets or Sets AccessPassword
    /// </summary>
    [DataMember(Name="AccessPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessPassword")]
    public string AccessPassword { get; set; }

    /// <summary>
    /// Gets or Sets AllowOwnRecordings
    /// </summary>
    [DataMember(Name="AllowOwnRecordings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowOwnRecordings")]
    public bool? AllowOwnRecordings { get; set; }

    /// <summary>
    /// Gets or Sets AuthID
    /// </summary>
    [DataMember(Name="AuthID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthID")]
    public string AuthID { get; set; }

    /// <summary>
    /// Gets or Sets AuthPassword
    /// </summary>
    [DataMember(Name="AuthPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthPassword")]
    public string AuthPassword { get; set; }

    /// <summary>
    /// Gets or Sets Blfs
    /// </summary>
    [DataMember(Name="Blfs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Blfs")]
    public string Blfs { get; set; }

    /// <summary>
    /// Gets or Sets BreakTime
    /// </summary>
    [DataMember(Name="BreakTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BreakTime")]
    public AllOfPbxUserBreakTime BreakTime { get; set; }

    /// <summary>
    /// Gets or Sets CallUsEnableChat
    /// </summary>
    [DataMember(Name="CallUsEnableChat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsEnableChat")]
    public bool? CallUsEnableChat { get; set; }

    /// <summary>
    /// Gets or Sets CallUsEnablePhone
    /// </summary>
    [DataMember(Name="CallUsEnablePhone", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsEnablePhone")]
    public bool? CallUsEnablePhone { get; set; }

    /// <summary>
    /// Gets or Sets CallUsEnableVideo
    /// </summary>
    [DataMember(Name="CallUsEnableVideo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsEnableVideo")]
    public bool? CallUsEnableVideo { get; set; }

    /// <summary>
    /// Gets or Sets CallUsRequirement
    /// </summary>
    [DataMember(Name="CallUsRequirement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CallUsRequirement")]
    public AllOfPbxUserCallUsRequirement CallUsRequirement { get; set; }

    /// <summary>
    /// Gets or Sets ClickToCallId
    /// </summary>
    [DataMember(Name="ClickToCallId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClickToCallId")]
    public string ClickToCallId { get; set; }

    /// <summary>
    /// Gets or Sets ContactImage
    /// </summary>
    [DataMember(Name="ContactImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ContactImage")]
    public string ContactImage { get; set; }

    /// <summary>
    /// Gets or Sets CurrentProfileName
    /// </summary>
    [DataMember(Name="CurrentProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CurrentProfileName")]
    public string CurrentProfileName { get; set; }

    /// <summary>
    /// Gets or Sets DeskphonePassword
    /// </summary>
    [DataMember(Name="DeskphonePassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeskphonePassword")]
    public string DeskphonePassword { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddress
    /// </summary>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name="Enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets FirstName
    /// </summary>
    [DataMember(Name="FirstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Gets or Sets ForwardingExceptions
    /// </summary>
    [DataMember(Name="ForwardingExceptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForwardingExceptions")]
    public List<PbxExtensionRule> ForwardingExceptions { get; set; }

    /// <summary>
    /// Gets or Sets ForwardingProfiles
    /// </summary>
    [DataMember(Name="ForwardingProfiles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ForwardingProfiles")]
    public List<PbxForwardingProfile> ForwardingProfiles { get; set; }

    /// <summary>
    /// Gets or Sets Groups
    /// </summary>
    [DataMember(Name="Groups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Groups")]
    public List<PbxUserGroup> Groups { get; set; }

    /// <summary>
    /// Gets or Sets Hours
    /// </summary>
    [DataMember(Name="Hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hours")]
    public AllOfPbxUserHours Hours { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets _Internal
    /// </summary>
    [DataMember(Name="Internal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Internal")]
    public bool? _Internal { get; set; }

    /// <summary>
    /// Gets or Sets IsRegistered
    /// </summary>
    [DataMember(Name="IsRegistered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRegistered")]
    public bool? IsRegistered { get; set; }

    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [DataMember(Name="Language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets LastName
    /// </summary>
    [DataMember(Name="LastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Gets or Sets Mobile
    /// </summary>
    [DataMember(Name="Mobile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Mobile")]
    public string Mobile { get; set; }

    /// <summary>
    /// Gets or Sets MyPhoneAllowDeleteRecordings
    /// </summary>
    [DataMember(Name="MyPhoneAllowDeleteRecordings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MyPhoneAllowDeleteRecordings")]
    public bool? MyPhoneAllowDeleteRecordings { get; set; }

    /// <summary>
    /// Gets or Sets MyPhoneHideForwardings
    /// </summary>
    [DataMember(Name="MyPhoneHideForwardings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MyPhoneHideForwardings")]
    public bool? MyPhoneHideForwardings { get; set; }

    /// <summary>
    /// Gets or Sets MyPhoneShowRecordings
    /// </summary>
    [DataMember(Name="MyPhoneShowRecordings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MyPhoneShowRecordings")]
    public bool? MyPhoneShowRecordings { get; set; }

    /// <summary>
    /// Gets or Sets Number
    /// </summary>
    [DataMember(Name="Number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets or Sets OfficeHoursProps
    /// </summary>
    [DataMember(Name="OfficeHoursProps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfficeHoursProps")]
    public List<PbxOfficeHoursBits> OfficeHoursProps { get; set; }

    /// <summary>
    /// Gets or Sets OutboundCallerID
    /// </summary>
    [DataMember(Name="OutboundCallerID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OutboundCallerID")]
    public string OutboundCallerID { get; set; }

    /// <summary>
    /// Gets or Sets Phones
    /// </summary>
    [DataMember(Name="Phones", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Phones")]
    public List<PbxPhone> Phones { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryGroupId
    /// </summary>
    [DataMember(Name="PrimaryGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryGroupId")]
    public int? PrimaryGroupId { get; set; }

    /// <summary>
    /// Gets or Sets PromptSet
    /// </summary>
    [DataMember(Name="PromptSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PromptSet")]
    public string PromptSet { get; set; }

    /// <summary>
    /// Gets or Sets ProvFile
    /// </summary>
    [DataMember(Name="ProvFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProvFile")]
    public string ProvFile { get; set; }

    /// <summary>
    /// Gets or Sets RecordCalls
    /// </summary>
    [DataMember(Name="RecordCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordCalls")]
    public bool? RecordCalls { get; set; }

    /// <summary>
    /// Gets or Sets RecordExtenalCallsOnly
    /// </summary>
    [DataMember(Name="RecordExtenalCallsOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordExtenalCallsOnly")]
    public bool? RecordExtenalCallsOnly { get; set; }

    /// <summary>
    /// Gets or Sets SendEmailMissedCalls
    /// </summary>
    [DataMember(Name="SendEmailMissedCalls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SendEmailMissedCalls")]
    public bool? SendEmailMissedCalls { get; set; }

    /// <summary>
    /// Gets or Sets VMEmailOptions
    /// </summary>
    [DataMember(Name="VMEmailOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VMEmailOptions")]
    public AllOfPbxUserVMEmailOptions VMEmailOptions { get; set; }

    /// <summary>
    /// Gets or Sets WebMeetingApproveParticipants
    /// </summary>
    [DataMember(Name="WebMeetingApproveParticipants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebMeetingApproveParticipants")]
    public bool? WebMeetingApproveParticipants { get; set; }

    /// <summary>
    /// Gets or Sets WebMeetingFriendlyName
    /// </summary>
    [DataMember(Name="WebMeetingFriendlyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WebMeetingFriendlyName")]
    public string WebMeetingFriendlyName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxUser {\n");
      sb.Append("  AccessPassword: ").Append(AccessPassword).Append("\n");
      sb.Append("  AllowOwnRecordings: ").Append(AllowOwnRecordings).Append("\n");
      sb.Append("  AuthID: ").Append(AuthID).Append("\n");
      sb.Append("  AuthPassword: ").Append(AuthPassword).Append("\n");
      sb.Append("  Blfs: ").Append(Blfs).Append("\n");
      sb.Append("  BreakTime: ").Append(BreakTime).Append("\n");
      sb.Append("  CallUsEnableChat: ").Append(CallUsEnableChat).Append("\n");
      sb.Append("  CallUsEnablePhone: ").Append(CallUsEnablePhone).Append("\n");
      sb.Append("  CallUsEnableVideo: ").Append(CallUsEnableVideo).Append("\n");
      sb.Append("  CallUsRequirement: ").Append(CallUsRequirement).Append("\n");
      sb.Append("  ClickToCallId: ").Append(ClickToCallId).Append("\n");
      sb.Append("  ContactImage: ").Append(ContactImage).Append("\n");
      sb.Append("  CurrentProfileName: ").Append(CurrentProfileName).Append("\n");
      sb.Append("  DeskphonePassword: ").Append(DeskphonePassword).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  ForwardingExceptions: ").Append(ForwardingExceptions).Append("\n");
      sb.Append("  ForwardingProfiles: ").Append(ForwardingProfiles).Append("\n");
      sb.Append("  Groups: ").Append(Groups).Append("\n");
      sb.Append("  Hours: ").Append(Hours).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  _Internal: ").Append(_Internal).Append("\n");
      sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Mobile: ").Append(Mobile).Append("\n");
      sb.Append("  MyPhoneAllowDeleteRecordings: ").Append(MyPhoneAllowDeleteRecordings).Append("\n");
      sb.Append("  MyPhoneHideForwardings: ").Append(MyPhoneHideForwardings).Append("\n");
      sb.Append("  MyPhoneShowRecordings: ").Append(MyPhoneShowRecordings).Append("\n");
      sb.Append("  Number: ").Append(Number).Append("\n");
      sb.Append("  OfficeHoursProps: ").Append(OfficeHoursProps).Append("\n");
      sb.Append("  OutboundCallerID: ").Append(OutboundCallerID).Append("\n");
      sb.Append("  Phones: ").Append(Phones).Append("\n");
      sb.Append("  PrimaryGroupId: ").Append(PrimaryGroupId).Append("\n");
      sb.Append("  PromptSet: ").Append(PromptSet).Append("\n");
      sb.Append("  ProvFile: ").Append(ProvFile).Append("\n");
      sb.Append("  RecordCalls: ").Append(RecordCalls).Append("\n");
      sb.Append("  RecordExtenalCallsOnly: ").Append(RecordExtenalCallsOnly).Append("\n");
      sb.Append("  SendEmailMissedCalls: ").Append(SendEmailMissedCalls).Append("\n");
      sb.Append("  VMEmailOptions: ").Append(VMEmailOptions).Append("\n");
      sb.Append("  WebMeetingApproveParticipants: ").Append(WebMeetingApproveParticipants).Append("\n");
      sb.Append("  WebMeetingFriendlyName: ").Append(WebMeetingFriendlyName).Append("\n");
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
