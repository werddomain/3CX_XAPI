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
  public class PbxPrompt {
    /// <summary>
    /// Gets or Sets Filename
    /// </summary>
    [DataMember(Name="Filename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Filename")]
    public string Filename { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Transcription
    /// </summary>
    [DataMember(Name="Transcription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Transcription")]
    public string Transcription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PbxPrompt {\n");
      sb.Append("  Filename: ").Append(Filename).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Transcription: ").Append(Transcription).Append("\n");
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
