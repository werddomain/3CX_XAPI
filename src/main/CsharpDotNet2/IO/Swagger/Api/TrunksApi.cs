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
    public interface ITrunksApi
    {
        /// <summary>
        /// Add new entity to Trunks 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxTrunk</returns>
        PbxTrunk CreateTrunk (PbxTrunk body);
        /// <summary>
        /// Delete entity from Trunks 
        /// </summary>
        /// <param name="id">The unique identifier of Trunk</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        void DeleteTrunk (int? id, string ifMatch);
        /// <summary>
        /// Get entity from Trunks by key 
        /// </summary>
        /// <param name="id">The unique identifier of Trunk</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxTrunk</returns>
        PbxTrunk GetTrunk (int? id, List<string> select, string expand);
        /// <summary>
        /// Invoke function GetTrunkByNumber 
        /// </summary>
        /// <param name="number">Usage: number&#x3D;{number}</param>
        /// <returns>PbxTrunk</returns>
        PbxTrunk GetTrunkByNumber (string number);
        /// <summary>
        /// Invoke function InitMasterBridge 
        /// </summary>
        /// <returns>PbxTrunk</returns>
        PbxTrunk InitMasterBridge ();
        /// <summary>
        /// Invoke function InitSlaveBridge 
        /// </summary>
        /// <returns>PbxTrunk</returns>
        PbxTrunk InitSlaveBridge ();
        /// <summary>
        /// Invoke function InitTrunk 
        /// </summary>
        /// <param name="template">Usage: template&#x3D;{template}</param>
        /// <returns>PbxTrunk</returns>
        PbxTrunk InitTrunk (string template);
        /// <summary>
        /// Get entities from Trunks 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxTrunkCollectionResponse</returns>
        PbxTrunkCollectionResponse ListTrunk (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Invoke action SetRoutes 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void SetRoutes (TrunksSetRoutesRequestBody body);
        /// <summary>
        /// Invoke action TelegramSession 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns>PbxXTelegramAuth</returns>
        PbxXTelegramAuth TelegramSession (TrunksTelegramSessionRequestBody body);
        /// <summary>
        /// Update entity in Trunks 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="id">The unique identifier of Trunk</param>
        /// <returns></returns>
        void UpdateTrunk (PbxTrunk body, int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TrunksApi : ITrunksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TrunksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TrunksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TrunksApi(String basePath)
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
        /// Add new entity to Trunks 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxTrunk</returns>
        public PbxTrunk CreateTrunk (PbxTrunk body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateTrunk");
    
            var path = "/Trunks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTrunk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateTrunk: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxTrunk) ApiClient.Deserialize(response.Content, typeof(PbxTrunk), response.Headers);
        }
    
        /// <summary>
        /// Delete entity from Trunks 
        /// </summary>
        /// <param name="id">The unique identifier of Trunk</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        public void DeleteTrunk (int? id, string ifMatch)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTrunk");
    
            var path = "/Trunks({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTrunk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTrunk: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get entity from Trunks by key 
        /// </summary>
        /// <param name="id">The unique identifier of Trunk</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxTrunk</returns>
        public PbxTrunk GetTrunk (int? id, List<string> select, string expand)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTrunk");
    
            var path = "/Trunks({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTrunk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTrunk: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxTrunk) ApiClient.Deserialize(response.Content, typeof(PbxTrunk), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetTrunkByNumber 
        /// </summary>
        /// <param name="number">Usage: number&#x3D;{number}</param>
        /// <returns>PbxTrunk</returns>
        public PbxTrunk GetTrunkByNumber (string number)
        {
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling GetTrunkByNumber");
    
            var path = "/Trunks/Pbx.GetTrunkByNumber(number={number})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "number" + "}", ApiClient.ParameterToString(number));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetTrunkByNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTrunkByNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxTrunk) ApiClient.Deserialize(response.Content, typeof(PbxTrunk), response.Headers);
        }
    
        /// <summary>
        /// Invoke function InitMasterBridge 
        /// </summary>
        /// <returns>PbxTrunk</returns>
        public PbxTrunk InitMasterBridge ()
        {
    
            var path = "/Trunks/Pbx.InitMasterBridge()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InitMasterBridge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InitMasterBridge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxTrunk) ApiClient.Deserialize(response.Content, typeof(PbxTrunk), response.Headers);
        }
    
        /// <summary>
        /// Invoke function InitSlaveBridge 
        /// </summary>
        /// <returns>PbxTrunk</returns>
        public PbxTrunk InitSlaveBridge ()
        {
    
            var path = "/Trunks/Pbx.InitSlaveBridge()";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InitSlaveBridge: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InitSlaveBridge: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxTrunk) ApiClient.Deserialize(response.Content, typeof(PbxTrunk), response.Headers);
        }
    
        /// <summary>
        /// Invoke function InitTrunk 
        /// </summary>
        /// <param name="template">Usage: template&#x3D;{template}</param>
        /// <returns>PbxTrunk</returns>
        public PbxTrunk InitTrunk (string template)
        {
            // verify the required parameter 'template' is set
            if (template == null) throw new ApiException(400, "Missing required parameter 'template' when calling InitTrunk");
    
            var path = "/Trunks/Pbx.InitTrunk(template={template})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "template" + "}", ApiClient.ParameterToString(template));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling InitTrunk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InitTrunk: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxTrunk) ApiClient.Deserialize(response.Content, typeof(PbxTrunk), response.Headers);
        }
    
        /// <summary>
        /// Get entities from Trunks 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxTrunkCollectionResponse</returns>
        public PbxTrunkCollectionResponse ListTrunk (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
    
            var path = "/Trunks";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListTrunk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListTrunk: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxTrunkCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxTrunkCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Invoke action SetRoutes 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void SetRoutes (TrunksSetRoutesRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SetRoutes");
    
            var path = "/Trunks/Pbx.SetRoutes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SetRoutes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetRoutes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action TelegramSession 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns>PbxXTelegramAuth</returns>
        public PbxXTelegramAuth TelegramSession (TrunksTelegramSessionRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TelegramSession");
    
            var path = "/Trunks/Pbx.TelegramSession";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TelegramSession: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TelegramSession: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxXTelegramAuth) ApiClient.Deserialize(response.Content, typeof(PbxXTelegramAuth), response.Headers);
        }
    
        /// <summary>
        /// Update entity in Trunks 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="id">The unique identifier of Trunk</param>
        /// <returns></returns>
        public void UpdateTrunk (PbxTrunk body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateTrunk");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateTrunk");
    
            var path = "/Trunks({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTrunk: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateTrunk: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
