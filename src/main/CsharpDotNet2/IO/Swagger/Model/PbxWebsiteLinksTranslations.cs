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
  public class PbxWebsiteLinksTranslations {
    /// <summary>
    /// Gets or Sets AuthenticationMessage
    /// </summary>
    [DataMember(Name="AuthenticationMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthenticationMessage")]
    public string AuthenticationMessage { get; set; }

    /// <summary>
    /// Gets or Sets EndingMessage
    /// </summary>
    [DataMember(Name="EndingMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndingMessage")]
    public string EndingMessage { get; set; }

    /// <summary>
    /// Gets or Sets FirstResponseMessage
    /// </summary>
    [DataMember(Name="FirstResponseMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FirstResponseMessage")]
    public string FirstResponseMessage { get; set; }

    /// <summary>
    /// Gets or Sets GdprMessage
    /// </summary>
    [DataMember(Name="GdprMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GdprMessage")]
    public string GdprMessage { get; set; }

    /// <summary>
    /// Gets or Sets GreetingMessage
    /// </summary>
    [DataMember(Name="GreetingMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GreetingMessage")]
    public string GreetingMessage { get; set; }

    /// <summary>
    /// Gets or Sets GreetingOfflineMessage
    /// </summary>
    [DataMember(Name="GreetingOfflineMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GreetingOfflineMessage")]
    public string GreetingOfflineMessage { get; set; }

    /// <summary>
    /// Gets or Sets InviteMessage
    /// </summary>
    [DataMember(Name="InviteMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InviteMessage")]
    public string InviteMessage { get; set; }

    /// <summary>
    /// Gets or Sets OfflineEmailMessage
    /// </summary>
    [DataMember(Name="OfflineEmailMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineEmailMessage")]
    public string OfflineEmailMessage { get; set; }

    /// <summary>
    /// Gets or Sets OfflineFinishMessage
    /// </summary>
    [DataMember(Name="OfflineFinishMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineFinishMessage")]
    public string OfflineFinishMessage { get; set; }

    /// <summary>
    /// Gets or Sets OfflineFormInvalidEmail
    /// </summary>
    [DataMember(Name="OfflineFormInvalidEmail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineFormInvalidEmail")]
    public string OfflineFormInvalidEmail { get; set; }

    /// <summary>
    /// Gets or Sets OfflineFormInvalidName
    /// </summary>
    [DataMember(Name="OfflineFormInvalidName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineFormInvalidName")]
    public string OfflineFormInvalidName { get; set; }

    /// <summary>
    /// Gets or Sets OfflineFormMaximumCharactersReached
    /// </summary>
    [DataMember(Name="OfflineFormMaximumCharactersReached", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineFormMaximumCharactersReached")]
    public string OfflineFormMaximumCharactersReached { get; set; }

    /// <summary>
    /// Gets or Sets OfflineNameMessage
    /// </summary>
    [DataMember(Name="OfflineNameMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineNameMessage")]
    public string OfflineNameMessage { get; set; }

    /// <summary>
    /// Gets or Sets StartChatButtonText
    /// </summary>
    [DataMember(Name="StartChatButtonText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartChatButtonText")]
    public string StartChatButtonText { get; set; }

    /// <summary>
    /// Gets or Sets UnavailableMessage
    /// </summary>
    [DataMember(Name="UnavailableMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UnavailableMessage")]
    public string UnavailableMessage { get; set; }

    /// <summary>
    /// Gets or Sets WindowTitle
    /// </summary>
    [DataMember(Name="WindowTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WindowTitle")]
    public string WindowTitle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxWebsiteLinksTranslations {\n");
      sb.Append("  AuthenticationMessage: ").Append(AuthenticationMessage).Append("\n");
      sb.Append("  EndingMessage: ").Append(EndingMessage).Append("\n");
      sb.Append("  FirstResponseMessage: ").Append(FirstResponseMessage).Append("\n");
      sb.Append("  GdprMessage: ").Append(GdprMessage).Append("\n");
      sb.Append("  GreetingMessage: ").Append(GreetingMessage).Append("\n");
      sb.Append("  GreetingOfflineMessage: ").Append(GreetingOfflineMessage).Append("\n");
      sb.Append("  InviteMessage: ").Append(InviteMessage).Append("\n");
      sb.Append("  OfflineEmailMessage: ").Append(OfflineEmailMessage).Append("\n");
      sb.Append("  OfflineFinishMessage: ").Append(OfflineFinishMessage).Append("\n");
      sb.Append("  OfflineFormInvalidEmail: ").Append(OfflineFormInvalidEmail).Append("\n");
      sb.Append("  OfflineFormInvalidName: ").Append(OfflineFormInvalidName).Append("\n");
      sb.Append("  OfflineFormMaximumCharactersReached: ").Append(OfflineFormMaximumCharactersReached).Append("\n");
      sb.Append("  OfflineNameMessage: ").Append(OfflineNameMessage).Append("\n");
      sb.Append("  StartChatButtonText: ").Append(StartChatButtonText).Append("\n");
      sb.Append("  UnavailableMessage: ").Append(UnavailableMessage).Append("\n");
      sb.Append("  WindowTitle: ").Append(WindowTitle).Append("\n");
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
