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
    public interface IFxsApi
    {
        /// <summary>
        /// Add new entity to Fxs 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxFxs</returns>
        PbxFxs CreateFxs (PbxFxs body);
        /// <summary>
        /// Delete entity from Fxs 
        /// </summary>
        /// <param name="macAddress">The unique identifier of Fxs</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        void DeleteFxs (string macAddress, string ifMatch);
        /// <summary>
        /// Get entity from Fxs by key 
        /// </summary>
        /// <param name="macAddress">The unique identifier of Fxs</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxFxs</returns>
        PbxFxs GetFxs (string macAddress, List<string> select, string expand);
        /// <summary>
        /// Get entities from Fxs 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxFxsCollectionResponse</returns>
        PbxFxsCollectionResponse ListFxs (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Update entity in Fxs 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="macAddress">The unique identifier of Fxs</param>
        /// <returns></returns>
        void UpdateFxs (PbxFxs body, string macAddress);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FxsApi : IFxsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FxsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FxsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FxsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FxsApi(String basePath)
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
        /// Add new entity to Fxs 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxFxs</returns>
        public PbxFxs CreateFxs (PbxFxs body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateFxs");
    
            var path = "/Fxs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateFxs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateFxs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxFxs) ApiClient.Deserialize(response.Content, typeof(PbxFxs), response.Headers);
        }
    
        /// <summary>
        /// Delete entity from Fxs 
        /// </summary>
        /// <param name="macAddress">The unique identifier of Fxs</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        public void DeleteFxs (string macAddress, string ifMatch)
        {
            // verify the required parameter 'macAddress' is set
            if (macAddress == null) throw new ApiException(400, "Missing required parameter 'macAddress' when calling DeleteFxs");
    
            var path = "/Fxs({MacAddress})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "MacAddress" + "}", ApiClient.ParameterToString(macAddress));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFxs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteFxs: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get entity from Fxs by key 
        /// </summary>
        /// <param name="macAddress">The unique identifier of Fxs</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxFxs</returns>
        public PbxFxs GetFxs (string macAddress, List<string> select, string expand)
        {
            // verify the required parameter 'macAddress' is set
            if (macAddress == null) throw new ApiException(400, "Missing required parameter 'macAddress' when calling GetFxs");
    
            var path = "/Fxs({MacAddress})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "MacAddress" + "}", ApiClient.ParameterToString(macAddress));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetFxs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetFxs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxFxs) ApiClient.Deserialize(response.Content, typeof(PbxFxs), response.Headers);
        }
    
        /// <summary>
        /// Get entities from Fxs 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxFxsCollectionResponse</returns>
        public PbxFxsCollectionResponse ListFxs (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
    
            var path = "/Fxs";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListFxs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFxs: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxFxsCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxFxsCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Update entity in Fxs 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="macAddress">The unique identifier of Fxs</param>
        /// <returns></returns>
        public void UpdateFxs (PbxFxs body, string macAddress)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateFxs");
            // verify the required parameter 'macAddress' is set
            if (macAddress == null) throw new ApiException(400, "Missing required parameter 'macAddress' when calling UpdateFxs");
    
            var path = "/Fxs({MacAddress})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "MacAddress" + "}", ApiClient.ParameterToString(macAddress));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateFxs: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateFxs: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
