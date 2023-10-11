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
    public interface IUsersApi
    {
        /// <summary>
        /// Add new entity to Users 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxUser</returns>
        PbxUser CreateUser (PbxUser body);
        /// <summary>
        /// Delete entity from Users 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        void DeleteUser (int? id, string ifMatch);
        /// <summary>
        /// Invoke function GetPhoneRegistrar 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="mac">Usage: mac&#x3D;{mac}</param>
        /// <returns>PbxPhoneRegistrar</returns>
        PbxPhoneRegistrar GetPhoneRegistrar (int? id, string mac);
        /// <summary>
        /// Invoke action GetPhoneRegistrars 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetPhoneRegistrars (UsersGetPhoneRegistrarsRequestBody body);
        /// <summary>
        /// Invoke function GetPhoneSecret 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetPhoneSecret (int? id);
        /// <summary>
        /// Get entity from Users by key 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxUser</returns>
        PbxUser GetUser (int? id, List<string> select, string expand);
        /// <summary>
        /// Invoke function GetByNumber 
        /// </summary>
        /// <param name="number">Usage: number&#x3D;{number}</param>
        /// <returns>PbxUser</returns>
        PbxUser GetUserByNumber (string number);
        /// <summary>
        /// Get ForwardingProfiles from Users 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxForwardingProfileCollectionResponse</returns>
        PbxForwardingProfileCollectionResponse ListForwardingProfiles (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Get Groups from Users 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxUserGroupCollectionResponse</returns>
        PbxUserGroupCollectionResponse ListGroups (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Get entities from Users 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxUserCollectionResponse</returns>
        PbxUserCollectionResponse ListUser (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand);
        /// <summary>
        /// Invoke action RebootPhone 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void RebootPhone (int? id, RebootPhoneRequestBody body);
        /// <summary>
        /// Invoke action Regenerate 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void Regenerate (int? id, RegenerateRequestBody body);
        /// <summary>
        /// Invoke action RegenerateAll 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        void RegenerateAll (UsersRegenerateAllRequestBody body);
        /// <summary>
        /// Invoke action RegisterInRps 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void RegisterInRps (int? id, RegisterInRpsRequestBody body);
        /// <summary>
        /// Invoke action ReprovisionPhone 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ReprovisionPhone (int? id, ReprovisionPhoneRequestBody body);
        /// <summary>
        /// Invoke action SendWelcomeEmail 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <returns></returns>
        void SendWelcomeEmail (int? id);
        /// <summary>
        /// Update entity in Users 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="id">The unique identifier of User</param>
        /// <returns></returns>
        void UpdateUser (PbxUser body, int? id);
        /// <summary>
        /// Invoke action UpgradePhone 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void UpgradePhone (int? id, UpgradePhoneRequestBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UsersApi : IUsersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public UsersApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(String basePath)
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
        /// Add new entity to Users 
        /// </summary>
        /// <param name="body">New entity</param>
        /// <returns>PbxUser</returns>
        public PbxUser CreateUser (PbxUser body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CreateUser");
    
            var path = "/Users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CreateUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUser) ApiClient.Deserialize(response.Content, typeof(PbxUser), response.Headers);
        }
    
        /// <summary>
        /// Delete entity from Users 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="ifMatch">ETag</param>
        /// <returns></returns>
        public void DeleteUser (int? id, string ifMatch)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUser");
    
            var path = "/Users({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke function GetPhoneRegistrar 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="mac">Usage: mac&#x3D;{mac}</param>
        /// <returns>PbxPhoneRegistrar</returns>
        public PbxPhoneRegistrar GetPhoneRegistrar (int? id, string mac)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPhoneRegistrar");
            // verify the required parameter 'mac' is set
            if (mac == null) throw new ApiException(400, "Missing required parameter 'mac' when calling GetPhoneRegistrar");
    
            var path = "/Users({Id})/Pbx.GetPhoneRegistrar(mac={mac})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "mac" + "}", ApiClient.ParameterToString(mac));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPhoneRegistrar: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPhoneRegistrar: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxPhoneRegistrar) ApiClient.Deserialize(response.Content, typeof(PbxPhoneRegistrar), response.Headers);
        }
    
        /// <summary>
        /// Invoke action GetPhoneRegistrars 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 GetPhoneRegistrars (UsersGetPhoneRegistrarsRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetPhoneRegistrars");
    
            var path = "/Users/Pbx.GetPhoneRegistrars";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPhoneRegistrars: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPhoneRegistrars: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2003) ApiClient.Deserialize(response.Content, typeof(InlineResponse2003), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetPhoneSecret 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 GetPhoneSecret (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetPhoneSecret");
    
            var path = "/Users({Id})/Pbx.GetPhoneSecret()";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetPhoneSecret: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetPhoneSecret: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// Get entity from Users by key 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxUser</returns>
        public PbxUser GetUser (int? id, List<string> select, string expand)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUser");
    
            var path = "/Users({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUser) ApiClient.Deserialize(response.Content, typeof(PbxUser), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetByNumber 
        /// </summary>
        /// <param name="number">Usage: number&#x3D;{number}</param>
        /// <returns>PbxUser</returns>
        public PbxUser GetUserByNumber (string number)
        {
            // verify the required parameter 'number' is set
            if (number == null) throw new ApiException(400, "Missing required parameter 'number' when calling GetUserByNumber");
    
            var path = "/Users/Pbx.GetByNumber(number={number})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserByNumber: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserByNumber: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUser) ApiClient.Deserialize(response.Content, typeof(PbxUser), response.Headers);
        }
    
        /// <summary>
        /// Get ForwardingProfiles from Users 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxForwardingProfileCollectionResponse</returns>
        public PbxForwardingProfileCollectionResponse ListForwardingProfiles (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListForwardingProfiles");
    
            var path = "/Users({Id})/ForwardingProfiles";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListForwardingProfiles: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListForwardingProfiles: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxForwardingProfileCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxForwardingProfileCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Groups from Users 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxUserGroupCollectionResponse</returns>
        public PbxUserGroupCollectionResponse ListGroups (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListGroups");
    
            var path = "/Users({Id})/Groups";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListGroups: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListGroups: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUserGroupCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxUserGroupCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Get entities from Users 
        /// </summary>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="orderby">Order items by property values</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="expand">Expand related entities</param>
        /// <returns>PbxUserCollectionResponse</returns>
        public PbxUserCollectionResponse ListUser (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)
        {
    
            var path = "/Users";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ListUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PbxUserCollectionResponse) ApiClient.Deserialize(response.Content, typeof(PbxUserCollectionResponse), response.Headers);
        }
    
        /// <summary>
        /// Invoke action RebootPhone 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void RebootPhone (int? id, RebootPhoneRequestBody body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RebootPhone");
    
            var path = "/Users({Id})/Pbx.RebootPhone";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RebootPhone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RebootPhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action Regenerate 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void Regenerate (int? id, RegenerateRequestBody body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Regenerate");
    
            var path = "/Users({Id})/Pbx.Regenerate";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling Regenerate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling Regenerate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action RegenerateAll 
        /// </summary>
        /// <param name="body">Action parameters</param>
        /// <returns></returns>
        public void RegenerateAll (UsersRegenerateAllRequestBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling RegenerateAll");
    
            var path = "/Users/Pbx.RegenerateAll";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RegenerateAll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegenerateAll: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action RegisterInRps 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void RegisterInRps (int? id, RegisterInRpsRequestBody body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RegisterInRps");
    
            var path = "/Users({Id})/Pbx.RegisterInRps";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterInRps: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RegisterInRps: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action ReprovisionPhone 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void ReprovisionPhone (int? id, ReprovisionPhoneRequestBody body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ReprovisionPhone");
    
            var path = "/Users({Id})/Pbx.ReprovisionPhone";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReprovisionPhone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReprovisionPhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action SendWelcomeEmail 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <returns></returns>
        public void SendWelcomeEmail (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SendWelcomeEmail");
    
            var path = "/Users({Id})/Pbx.SendWelcomeEmail";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling SendWelcomeEmail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SendWelcomeEmail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update entity in Users 
        /// </summary>
        /// <param name="body">New property values</param>
        /// <param name="id">The unique identifier of User</param>
        /// <returns></returns>
        public void UpdateUser (PbxUser body, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateUser");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateUser");
    
            var path = "/Users({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Invoke action UpgradePhone 
        /// </summary>
        /// <param name="id">The unique identifier of User</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public void UpgradePhone (int? id, UpgradePhoneRequestBody body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpgradePhone");
    
            var path = "/Users({Id})/Pbx.UpgradePhone";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpgradePhone: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpgradePhone: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
