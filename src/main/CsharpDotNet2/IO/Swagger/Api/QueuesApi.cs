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
    public interface IQueuesApi
    {
        /// <summary>
        /// Add new entity to Queues 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxQueue</returns>
        PbxQueue CreateQueue (PbxQueue body);
        /// <summary>
        /// Delete entity from Queues 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        void DeleteQueue (int? id, string ifMatch);
        /// <summary>
        /// Get entity from Queues by key 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueue</returns>
        PbxQueue GetQueue (int? id, List<string> select, string expand);
        /// <summary>
        /// Invoke function GetByNumber 
        /// </summary>
        /// <param name="number">Usage: number&#x3D;{number}</param>
        /// <returns>PbxQueue</returns>
        PbxQueue GetQueueByNumber (string number);
        /// <summary>
        /// Get Agents from Queues 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueueAgentCollectionResponse</returns>
        PbxQueueAgentCollectionResponse ListAgents (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Get Managers from Queues 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueueManagerCollectionResponse</returns>
        PbxQueueManagerCollectionResponse ListManagers (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Get entities from Queues 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueueCollectionResponse</returns>
        PbxQueueCollectionResponse ListQueue (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Update entity in Queues 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="id">The unique identifier of Queue</param>
        /// <returns></returns>
        void UpdateQueue (PbxQueue body, int? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QueuesApi : IQueuesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueuesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public QueuesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QueuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QueuesApi(String basePath)
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
        /// Add new entity to Queues 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxQueue</returns>
        public PbxQueue CreateQueue (PbxQueue body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateQueue");
    
            var path = "/Queues";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateQueue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateQueue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxQueue) ApiClient.Deserialize(response.Content, typeof(PbxQueue), response.Headers);
        }
    
        /// <summary>
        /// Delete entity from Queues 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        public void DeleteQueue (int? id, string ifMatch)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteQueue");
    
            var path = "/Queues({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQueue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteQueue: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get entity from Queues by key 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueue</returns>
        public PbxQueue GetQueue (int? id, List<string> select, string expand)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetQueue");
    
            var path = "/Queues({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetQueue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQueue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxQueue) ApiClient.Deserialize(response.Content, typeof(PbxQueue), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetByNumber 
        /// </summary>
        /// <param name="number">Usage: number&#x3D;{number}</param>
        /// <returns>PbxQueue</returns>
        public PbxQueue GetQueueByNumber (string number)
        {
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling GetQueueByNumber");
    
            var path = "/Queues/Pbx.GetByNumber(number={number})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetQueueByNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQueueByNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxQueue) ApiClient.Deserialize(response.Content, typeof(PbxQueue), response.Headers);
        }
    
        /// <summary>
        /// Get Agents from Queues 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueueAgentCollectionResponse</returns>
        public PbxQueueAgentCollectionResponse ListAgents (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListAgents");
    
            var path = "/Queues({Id})/Agents";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListAgents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListAgents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxQueueAgentCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxQueueAgentCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Managers from Queues 
        /// </summary>
        /// <param name="id">The unique identifier of Queue</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueueManagerCollectionResponse</returns>
        public PbxQueueManagerCollectionResponse ListManagers (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListManagers");
    
            var path = "/Queues({Id})/Managers";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListManagers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListManagers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxQueueManagerCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxQueueManagerCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Get entities from Queues 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxQueueCollectionResponse</returns>
        public PbxQueueCollectionResponse ListQueue (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
    
            var path = "/Queues";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListQueue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListQueue: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxQueueCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxQueueCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Update entity in Queues 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="id">The unique identifier of Queue</param>
        /// <returns></returns>
        public void UpdateQueue (PbxQueue body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateQueue");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateQueue");
    
            var path = "/Queues({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQueue: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateQueue: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
