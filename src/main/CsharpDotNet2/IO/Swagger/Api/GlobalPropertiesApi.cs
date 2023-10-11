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
    public interface IGlobalPropertiesApi
    {
        /// <summary>
        /// Get entity from GlobalProperties by key 
        /// </summary>
        /// <param name="name">The unique identifier of Property</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxProperty</returns>
        PbxProperty GetGlobalProperty (string name, List<string> select, string expand);
        /// <summary>
        /// Get entities from GlobalProperties 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxPropertyCollectionResponse</returns>
        PbxPropertyCollectionResponse ListGlobalProperty (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Update entity in GlobalProperties 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="name">The unique identifier of Property</param>
        /// <returns></returns>
        void UpdateGlobalProperty (PbxProperty body, string name);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class GlobalPropertiesApi : IGlobalPropertiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalPropertiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public GlobalPropertiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalPropertiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public GlobalPropertiesApi(String basePath)
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
        /// Get entity from GlobalProperties by key 
        /// </summary>
        /// <param name="name">The unique identifier of Property</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxProperty</returns>
        public PbxProperty GetGlobalProperty (string name, List<string> select, string expand)
        {
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling GetGlobalProperty");
    
            var path = "/GlobalProperties({Name})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalProperty: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalProperty: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxProperty) ApiClient.Deserialize(response.Content, typeof(PbxProperty), response.Headers);
        }
    
        /// <summary>
        /// Get entities from GlobalProperties 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxPropertyCollectionResponse</returns>
        public PbxPropertyCollectionResponse ListGlobalProperty (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
    
            var path = "/GlobalProperties";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListGlobalProperty: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListGlobalProperty: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxPropertyCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxPropertyCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Update entity in GlobalProperties 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="name">The unique identifier of Property</param>
        /// <returns></returns>
        public void UpdateGlobalProperty (PbxProperty body, string name)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateGlobalProperty");
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling UpdateGlobalProperty");
    
            var path = "/GlobalProperties({Name})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Name" + "}", ApiClient.ParameterToString(name));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGlobalProperty: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateGlobalProperty: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
