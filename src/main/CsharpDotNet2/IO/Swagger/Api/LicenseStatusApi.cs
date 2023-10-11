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
    public interface ILicenseStatusApi
    {
        /// <summary>
        /// Get LicenseStatus 
        /// </summary>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxLicenseStatus</returns>
        PbxLicenseStatus GetLicenseStatus (List<string> select, string expand);
        /// <summary>
        /// Invoke action LinkPartner 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void LinkPartner (LicenseStatusLinkPartnerRequestBody body);
        /// <summary>
        /// Invoke function PartnerInfo 
        /// </summary>
        /// <param name="resellerId">Usage: resellerId&#x3D;{resellerId}</param>
        /// <returns>PbxResellerInfo</returns>
        PbxResellerInfo PartnerInfo (string resellerId);
        /// <summary>
        /// Invoke action RefreshLicenseStatus 
        /// </summary>
        /// <returns></returns>
        void RefreshLicenseStatus ();
        /// <summary>
        /// Invoke action UnlinkPartner 
        /// </summary>
        /// <returns></returns>
        void UnlinkPartner ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LicenseStatusApi : ILicenseStatusApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseStatusApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LicenseStatusApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LicenseStatusApi(String basePath)
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
        /// Get LicenseStatus 
        /// </summary>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxLicenseStatus</returns>
        public PbxLicenseStatus GetLicenseStatus (List<string> select, string expand)
        {
    
            var path = "/LicenseStatus";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetLicenseStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetLicenseStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxLicenseStatus) ApiClient.Deserialize(response.Content, typeof(PbxLicenseStatus), response.Headers);
        }
    
        /// <summary>
        /// Invoke action LinkPartner 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void LinkPartner (LicenseStatusLinkPartnerRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling LinkPartner");
    
            var path = "/LicenseStatus/Pbx.LinkPartner";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LinkPartner: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LinkPartner: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke function PartnerInfo 
        /// </summary>
        /// <param name="resellerId">Usage: resellerId&#x3D;{resellerId}</param>
        /// <returns>PbxResellerInfo</returns>
        public PbxResellerInfo PartnerInfo (string resellerId)
        {
            // verify the required parameter 'resellerId' is set
            if (resellerId == null) throw new ApiException(400, "Missing required parameter 'resellerId' when calling PartnerInfo");
    
            var path = "/LicenseStatus/Pbx.PartnerInfo(resellerId={resellerId})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "resellerId" + "}", ApiClient.ParameterToString(resellerId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PartnerInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PartnerInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxResellerInfo) ApiClient.Deserialize(response.Content, typeof(PbxResellerInfo), response.Headers);
        }
    
        /// <summary>
        /// Invoke action RefreshLicenseStatus 
        /// </summary>
        /// <returns></returns>
        public void RefreshLicenseStatus ()
        {
    
            var path = "/LicenseStatus/Pbx.RefreshLicenseStatus";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshLicenseStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RefreshLicenseStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action UnlinkPartner 
        /// </summary>
        /// <returns></returns>
        public void UnlinkPartner ()
        {
    
            var path = "/LicenseStatus/Pbx.UnlinkPartner";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UnlinkPartner: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UnlinkPartner: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
