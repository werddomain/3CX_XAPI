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
    public interface ILicenseInfoApi
    {
        /// <summary>
        /// Invoke action EditLicenseInfo 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void EditLicenseInfo (LicenseInfoEditLicenseInfoRequestBody body);
        /// <summary>
        /// Get LicenseInfo 
        /// </summary>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxLicenseInfo</returns>
        PbxLicenseInfo GetLicenseInfo (List<string> select, string expand);
        /// <summary>
        /// Invoke action ReplaceLicenseKey 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void ReplaceLicenseKey (LicenseInfoReplaceLicenseKeyRequestBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LicenseInfoApi : ILicenseInfoApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseInfoApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LicenseInfoApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LicenseInfoApi(String basePath)
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
        /// Invoke action EditLicenseInfo 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void EditLicenseInfo (LicenseInfoEditLicenseInfoRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling EditLicenseInfo");
    
            var path = "/LicenseInfo/Pbx.EditLicenseInfo";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EditLicenseInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditLicenseInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get LicenseInfo 
        /// </summary>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxLicenseInfo</returns>
        public PbxLicenseInfo GetLicenseInfo (List<string> select, string expand)
        {
    
            var path = "/LicenseInfo";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
 if (expand != null) queryParams.Add("$expand", ApiClient.ParameterToString(expand)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLicenseInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLicenseInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxLicenseInfo) ApiClient.Deserialize(response.Content, typeof(PbxLicenseInfo), response.Headers);
        }
    
        /// <summary>
        /// Invoke action ReplaceLicenseKey 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void ReplaceLicenseKey (LicenseInfoReplaceLicenseKeyRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ReplaceLicenseKey");
    
            var path = "/LicenseInfo/Pbx.ReplaceLicenseKey";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceLicenseKey: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReplaceLicenseKey: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
