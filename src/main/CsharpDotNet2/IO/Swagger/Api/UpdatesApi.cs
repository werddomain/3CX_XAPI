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
    public interface IUpdatesApi
    {
        /// <summary>
        /// Invoke functionImport GetClientCrmUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        PbxUpdateList GetClientCrmUpdates ();
        /// <summary>
        /// Invoke functionImport GetPromptSetUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        PbxUpdateList GetPromptSetUpdates ();
        /// <summary>
        /// Invoke functionImport GetServerCrmUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        PbxUpdateList GetServerCrmUpdates ();
        /// <summary>
        /// Invoke functionImport GetUpdateSettings 
        /// </summary>
        /// <returns>PbxUpdateSettings</returns>
        PbxUpdateSettings GetUpdateSettings ();
        /// <summary>
        /// Invoke functionImport GetUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        PbxUpdateList GetUpdates ();
        /// <summary>
        /// Invoke functionImport GetUpdatesStats 
        /// </summary>
        /// <returns>PbxUpdatesStats</returns>
        PbxUpdatesStats GetUpdatesStats ();
        /// <summary>
        /// Invoke functionImport HasDebianUpgrade 
        /// </summary>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 HasDebianUpgrade ();
        /// <summary>
        /// Invoke actionImport InstallUpdates 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void InstallUpdates (ActionImportInstallUpdatesRequestBody body);
        /// <summary>
        /// Invoke actionImport SetUpdateSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void SetUpdateSettings (ActionImportSetUpdateSettingsRequestBody body);
        /// <summary>
        /// Invoke actionImport UpgradeDebian 
        /// </summary>
        /// <returns></returns>
        void UpgradeDebian ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UpdatesApi : IUpdatesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UpdatesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UpdatesApi(String basePath)
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
        /// Invoke functionImport GetClientCrmUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        public PbxUpdateList GetClientCrmUpdates ()
        {
    
            var path = "/GetClientCrmUpdates()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientCrmUpdates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetClientCrmUpdates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUpdateList) ApiClient.Deserialize(response.Content, typeof(PbxUpdateList), response.Headers);
        }
    
        /// <summary>
        /// Invoke functionImport GetPromptSetUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        public PbxUpdateList GetPromptSetUpdates ()
        {
    
            var path = "/GetPromptSetUpdates()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPromptSetUpdates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPromptSetUpdates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUpdateList) ApiClient.Deserialize(response.Content, typeof(PbxUpdateList), response.Headers);
        }
    
        /// <summary>
        /// Invoke functionImport GetServerCrmUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        public PbxUpdateList GetServerCrmUpdates ()
        {
    
            var path = "/GetServerCrmUpdates()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetServerCrmUpdates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetServerCrmUpdates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUpdateList) ApiClient.Deserialize(response.Content, typeof(PbxUpdateList), response.Headers);
        }
    
        /// <summary>
        /// Invoke functionImport GetUpdateSettings 
        /// </summary>
        /// <returns>PbxUpdateSettings</returns>
        public PbxUpdateSettings GetUpdateSettings ()
        {
    
            var path = "/GetUpdateSettings()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUpdateSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUpdateSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUpdateSettings) ApiClient.Deserialize(response.Content, typeof(PbxUpdateSettings), response.Headers);
        }
    
        /// <summary>
        /// Invoke functionImport GetUpdates 
        /// </summary>
        /// <returns>PbxUpdateList</returns>
        public PbxUpdateList GetUpdates ()
        {
    
            var path = "/GetUpdates()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUpdates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUpdates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUpdateList) ApiClient.Deserialize(response.Content, typeof(PbxUpdateList), response.Headers);
        }
    
        /// <summary>
        /// Invoke functionImport GetUpdatesStats 
        /// </summary>
        /// <returns>PbxUpdatesStats</returns>
        public PbxUpdatesStats GetUpdatesStats ()
        {
    
            var path = "/GetUpdatesStats()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUpdatesStats: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUpdatesStats: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUpdatesStats) ApiClient.Deserialize(response.Content, typeof(PbxUpdatesStats), response.Headers);
        }
    
        /// <summary>
        /// Invoke functionImport HasDebianUpgrade 
        /// </summary>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 HasDebianUpgrade ()
        {
    
            var path = "/HasDebianUpgrade()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HasDebianUpgrade: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HasDebianUpgrade: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Invoke actionImport InstallUpdates 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void InstallUpdates (ActionImportInstallUpdatesRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling InstallUpdates");
    
            var path = "/InstallUpdates";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InstallUpdates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InstallUpdates: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke actionImport SetUpdateSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void SetUpdateSettings (ActionImportSetUpdateSettingsRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetUpdateSettings");
    
            var path = "/SetUpdateSettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetUpdateSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetUpdateSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke actionImport UpgradeDebian 
        /// </summary>
        /// <returns></returns>
        public void UpgradeDebian ()
        {
    
            var path = "/UpgradeDebian";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpgradeDebian: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpgradeDebian: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
