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
    public interface IBackupsApi
    {
        /// <summary>
        /// Invoke action Backup 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void Backup (BackupsBackupRequestBody body);
        /// <summary>
        /// Delete entity from Backups 
        /// </summary>
        /// <param name="fileName">The unique identifier of Backup</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        void DeleteBackup (string fileName, string ifMatch);
        /// <summary>
        /// Invoke function GetBackupExtras 
        /// </summary>
        /// <param name="fileName">The unique identifier of Backup</param>
        /// <returns>PbxBackupExtras</returns>
        PbxBackupExtras GetBackupExtras (string fileName);
        /// <summary>
        /// Invoke function GetBackupRepositorySettings 
        /// </summary>
        /// <returns>PbxBackupRepositorySettings</returns>
        PbxBackupRepositorySettings GetBackupRepositorySettings ();
        /// <summary>
        /// Invoke function GetBackupSettings 
        /// </summary>
        /// <returns>PbxBackupSettings</returns>
        PbxBackupSettings GetBackupSettings ();
        /// <summary>
        /// Invoke function GetCanCreateBackup 
        /// </summary>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetCanCreateBackup ();
        /// <summary>
        /// Invoke function GetRestoreSettings 
        /// </summary>
        /// <returns>PbxRestoreSettings</returns>
        PbxRestoreSettings GetRestoreSettings ();
        /// <summary>
        /// Get entities from Backups 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxBackupCollectionResponse</returns>
        PbxBackupCollectionResponse ListBackup (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Invoke action Restore 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <param name="fileName">The unique identifier of Backup</param>
        /// <returns></returns>
        void Restore (BackupsBackupRestoreRequestBody body, string fileName);
        /// <summary>
        /// Invoke action SetBackupRepositorySettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void SetBackupRepositorySettings (BackupsSetBackupRepositorySettingsRequestBody body);
        /// <summary>
        /// Invoke action SetBackupSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void SetBackupSettings (BackupsSetBackupSettingsRequestBody body);
        /// <summary>
        /// Invoke action SetRestoreSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void SetRestoreSettings (BackupsSetRestoreSettingsRequestBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BackupsApi : IBackupsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BackupsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BackupsApi(String basePath)
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
        /// Invoke action Backup 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void Backup (BackupsBackupRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Backup");
    
            var path = "/Backups/Pbx.Backup";
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
                throw new ApiException ((int)response.StatusCode, "Error calling Backup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Backup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete entity from Backups 
        /// </summary>
        /// <param name="fileName">The unique identifier of Backup</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        public void DeleteBackup (string fileName, string ifMatch)
        {
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling DeleteBackup");
    
            var path = "/Backups({FileName})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "FileName" + "}", ApiClient.ParameterToString(fileName));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                         if (ifMatch != null) headerParams.Add("If-Match", ApiClient.ParameterToString(ifMatch)); // header parameter
            
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBackup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteBackup: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke function GetBackupExtras 
        /// </summary>
        /// <param name="fileName">The unique identifier of Backup</param>
        /// <returns>PbxBackupExtras</returns>
        public PbxBackupExtras GetBackupExtras (string fileName)
        {
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling GetBackupExtras");
    
            var path = "/Backups({FileName})/Pbx.GetBackupExtras()";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "FileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBackupExtras: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBackupExtras: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxBackupExtras) ApiClient.Deserialize(response.Content, typeof(PbxBackupExtras), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetBackupRepositorySettings 
        /// </summary>
        /// <returns>PbxBackupRepositorySettings</returns>
        public PbxBackupRepositorySettings GetBackupRepositorySettings ()
        {
    
            var path = "/Backups/Pbx.GetBackupRepositorySettings()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBackupRepositorySettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBackupRepositorySettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxBackupRepositorySettings) ApiClient.Deserialize(response.Content, typeof(PbxBackupRepositorySettings), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetBackupSettings 
        /// </summary>
        /// <returns>PbxBackupSettings</returns>
        public PbxBackupSettings GetBackupSettings ()
        {
    
            var path = "/Backups/Pbx.GetBackupSettings()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetBackupSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetBackupSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxBackupSettings) ApiClient.Deserialize(response.Content, typeof(PbxBackupSettings), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetCanCreateBackup 
        /// </summary>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetCanCreateBackup ()
        {
    
            var path = "/Backups/Pbx.GetCanCreateBackup()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCanCreateBackup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCanCreateBackup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse200) ApiClient.Deserialize(response.Content, typeof(InlineResponse200), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetRestoreSettings 
        /// </summary>
        /// <returns>PbxRestoreSettings</returns>
        public PbxRestoreSettings GetRestoreSettings ()
        {
    
            var path = "/Backups/Pbx.GetRestoreSettings()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetRestoreSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetRestoreSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxRestoreSettings) ApiClient.Deserialize(response.Content, typeof(PbxRestoreSettings), response.Headers);
        }
    
        /// <summary>
        /// Get entities from Backups 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxBackupCollectionResponse</returns>
        public PbxBackupCollectionResponse ListBackup (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
    
            var path = "/Backups";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (top != null) queryParams.Add("$top", ApiClient.ParameterToString(top)); // query parameter
 if (skip != null) queryParams.Add("$skip", ApiClient.ParameterToString(skip)); // query parameter
 if (search != null) queryParams.Add("$search", ApiClient.ParameterToString(search)); // query parameter
 if (filter != null) queryParams.Add("$filter", ApiClient.ParameterToString(filter)); // query parameter
 if (count != null) queryParams.Add("$count", ApiClient.ParameterToString(count)); // query parameter
 if (orderby != null) queryParams.Add("$orderby", ApiClient.ParameterToString(orderby)); // query parameter
 if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
 if (expand != null) queryParams.Add("$expand", ApiClient.ParameterToString(expand)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBackup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListBackup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxBackupCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxBackupCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Invoke action Restore 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <param name="fileName">The unique identifier of Backup</param>
        /// <returns></returns>
        public void Restore (BackupsBackupRestoreRequestBody body, string fileName)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling Restore");
            // verify the required parameter 'fileName' is set
            if (fileName == null) throw new ApiException(400, "Missing required parameter 'fileName' when calling Restore");
    
            var path = "/Backups({FileName})/Pbx.Restore";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "FileName" + "}", ApiClient.ParameterToString(fileName));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling Restore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Restore: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action SetBackupRepositorySettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void SetBackupRepositorySettings (BackupsSetBackupRepositorySettingsRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetBackupRepositorySettings");
    
            var path = "/Backups/Pbx.SetBackupRepositorySettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetBackupRepositorySettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetBackupRepositorySettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action SetBackupSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void SetBackupSettings (BackupsSetBackupSettingsRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetBackupSettings");
    
            var path = "/Backups/Pbx.SetBackupSettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetBackupSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetBackupSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action SetRestoreSettings 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void SetRestoreSettings (BackupsSetRestoreSettingsRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetRestoreSettings");
    
            var path = "/Backups/Pbx.SetRestoreSettings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetRestoreSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetRestoreSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
