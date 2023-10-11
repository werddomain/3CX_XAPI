using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecordingsApi
    {
        /// <summary>
        /// Invoke action Archive 
        /// </summary>
        /// <returns></returns>
        void Archive ();
        /// <summary>
        /// Invoke function DownloadRecording 
        /// </summary>
        /// <param name="recId">Usage: recId&#x3D;{recId}</param>
        /// <returns>PbxIActionResult</returns>
        PbxIActionResult DownloadRecording (int? recId);
        /// <summary>
        /// Invoke function GetRecordingRepositorySettings 
        /// </summary>
        /// <returns>PbxRecordingRepositorySettings</returns>
        PbxRecordingRepositorySettings GetRecordingRepositorySettings ();
        /// <summary>
        /// Invoke function GetRecordingSettings 
        /// </summary>
        /// <returns>PbxRecordingSettings</returns>
        PbxRecordingSettings GetRecordingSettings ();
        /// <summary>
        /// Invoke action PurgeArchive 
        /// </summary>
        /// <returns></returns>
        void PurgeArchive ();
        /// <summary>
        /// Invoke action PurgeLocal 
        /// </summary>
        /// <returns></returns>
        void PurgeLocal ();
        /// <summary>
        /// Invoke action SetRecordingRepositorySettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void SetRecordingRepositorySettings (RecordingsSetRecordingRepositorySettingsRequestBody body);
        /// <summary>
        /// Invoke action SetRecordingSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void SetRecordingSettings (RecordingsSetRecordingSettingsRequestBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RecordingsApi : IRecordingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RecordingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecordingsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Invoke action Archive 
        /// </summary>
        /// <returns></returns>
        public void Archive ()
        {
    
            var path = "/Recordings/Pbx.Archive";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Archive: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Archive: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke function DownloadRecording 
        /// </summary>
        /// <param name="recId">Usage: recId&#x3D;{recId}</param>
        /// <returns>PbxIActionResult</returns>
        public PbxIActionResult DownloadRecording (int? recId)
        {
            // verify the required parameter 'recId' is set
            if (recId == null) throw new ApiException(400, "Missing required parameter 'recId' when calling DownloadRecording");
    
            var path = "/Recordings/Pbx.DownloadRecording(recId={recId})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "recId" + "}", ApiClient.ParameterToString(recId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadRecording: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadRecording: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxIActionResult) ApiClient.Deserialize(response.Content, typeof(PbxIActionResult), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetRecordingRepositorySettings 
        /// </summary>
        /// <returns>PbxRecordingRepositorySettings</returns>
        public PbxRecordingRepositorySettings GetRecordingRepositorySettings ()
        {
    
            var path = "/Recordings/Pbx.GetRecordingRepositorySettings()";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRecordingRepositorySettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRecordingRepositorySettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxRecordingRepositorySettings) ApiClient.Deserialize(response.Content, typeof(PbxRecordingRepositorySettings), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetRecordingSettings 
        /// </summary>
        /// <returns>PbxRecordingSettings</returns>
        public PbxRecordingSettings GetRecordingSettings ()
        {
    
            var path = "/Recordings/Pbx.GetRecordingSettings()";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRecordingSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRecordingSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxRecordingSettings) ApiClient.Deserialize(response.Content, typeof(PbxRecordingSettings), response.Headers);
        }
    
        /// <summary>
        /// Invoke action PurgeArchive 
        /// </summary>
        /// <returns></returns>
        public void PurgeArchive ()
        {
    
            var path = "/Recordings/Pbx.PurgeArchive";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PurgeArchive: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PurgeArchive: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action PurgeLocal 
        /// </summary>
        /// <returns></returns>
        public void PurgeLocal ()
        {
    
            var path = "/Recordings/Pbx.PurgeLocal";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PurgeLocal: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PurgeLocal: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action SetRecordingRepositorySettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void SetRecordingRepositorySettings (RecordingsSetRecordingRepositorySettingsRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetRecordingRepositorySettings");
    
            var path = "/Recordings/Pbx.SetRecordingRepositorySettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetRecordingRepositorySettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetRecordingRepositorySettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action SetRecordingSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void SetRecordingSettings (RecordingsSetRecordingSettingsRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetRecordingSettings");
    
            var path = "/Recordings/Pbx.SetRecordingSettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetRecordingSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetRecordingSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
