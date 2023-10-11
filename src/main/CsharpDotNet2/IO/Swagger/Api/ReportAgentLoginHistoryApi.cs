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
    public interface IReportAgentLoginHistoryApi
    {
        /// <summary>
        /// Invoke function DownloadAgentLoginHistory 
        /// </summary>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="agentDnStr">Usage: agentDnStr&#x3D;{agentDnStr}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentLoginHistory</returns>
        CollectionOfAgentLoginHistory DownloadAgentLoginHistory (string clientTimeZone, DateTime? startDt, DateTime? endDt, string queueDnStr, string agentDnStr, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
        /// <summary>
        /// Invoke function GetAgentLoginHistoryData 
        /// </summary>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="agentDnStr">Usage: agentDnStr&#x3D;{agentDnStr}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentLoginHistory</returns>
        CollectionOfAgentLoginHistory GetAgentLoginHistoryData (string clientTimeZone, DateTime? startDt, DateTime? endDt, string queueDnStr, string agentDnStr, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportAgentLoginHistoryApi : IReportAgentLoginHistoryApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAgentLoginHistoryApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportAgentLoginHistoryApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAgentLoginHistoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportAgentLoginHistoryApi(String basePath)
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
        /// Invoke function DownloadAgentLoginHistory 
        /// </summary>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="agentDnStr">Usage: agentDnStr&#x3D;{agentDnStr}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentLoginHistory</returns>
        public CollectionOfAgentLoginHistory DownloadAgentLoginHistory (string clientTimeZone, DateTime? startDt, DateTime? endDt, string queueDnStr, string agentDnStr, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'clientTimeZone' is set
            if (clientTimeZone == null) throw new ApiException(400, "Missing required parameter 'clientTimeZone' when calling DownloadAgentLoginHistory");
            // verify the required parameter 'startDt' is set
            if (startDt == null) throw new ApiException(400, "Missing required parameter 'startDt' when calling DownloadAgentLoginHistory");
            // verify the required parameter 'endDt' is set
            if (endDt == null) throw new ApiException(400, "Missing required parameter 'endDt' when calling DownloadAgentLoginHistory");
            // verify the required parameter 'queueDnStr' is set
            if (queueDnStr == null) throw new ApiException(400, "Missing required parameter 'queueDnStr' when calling DownloadAgentLoginHistory");
            // verify the required parameter 'agentDnStr' is set
            if (agentDnStr == null) throw new ApiException(400, "Missing required parameter 'agentDnStr' when calling DownloadAgentLoginHistory");
    
            var path = "/ReportAgentLoginHistory/Pbx.DownloadAgentLoginHistory(clientTimeZone={clientTimeZone},startDt={startDt},endDt={endDt},queueDnStr={queueDnStr},agentDnStr={agentDnStr})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clientTimeZone" + "}", ApiClient.ParameterToString(clientTimeZone));
path = path.Replace("{" + "startDt" + "}", ApiClient.ParameterToString(startDt));
path = path.Replace("{" + "endDt" + "}", ApiClient.ParameterToString(endDt));
path = path.Replace("{" + "queueDnStr" + "}", ApiClient.ParameterToString(queueDnStr));
path = path.Replace("{" + "agentDnStr" + "}", ApiClient.ParameterToString(agentDnStr));
    
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
 if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
 if (orderby != null) queryParams.Add("$orderby", ApiClient.ParameterToString(orderby)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadAgentLoginHistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadAgentLoginHistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfAgentLoginHistory) ApiClient.Deserialize(response.Content, typeof(CollectionOfAgentLoginHistory), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetAgentLoginHistoryData 
        /// </summary>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="agentDnStr">Usage: agentDnStr&#x3D;{agentDnStr}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentLoginHistory</returns>
        public CollectionOfAgentLoginHistory GetAgentLoginHistoryData (string clientTimeZone, DateTime? startDt, DateTime? endDt, string queueDnStr, string agentDnStr, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'clientTimeZone' is set
            if (clientTimeZone == null) throw new ApiException(400, "Missing required parameter 'clientTimeZone' when calling GetAgentLoginHistoryData");
            // verify the required parameter 'startDt' is set
            if (startDt == null) throw new ApiException(400, "Missing required parameter 'startDt' when calling GetAgentLoginHistoryData");
            // verify the required parameter 'endDt' is set
            if (endDt == null) throw new ApiException(400, "Missing required parameter 'endDt' when calling GetAgentLoginHistoryData");
            // verify the required parameter 'queueDnStr' is set
            if (queueDnStr == null) throw new ApiException(400, "Missing required parameter 'queueDnStr' when calling GetAgentLoginHistoryData");
            // verify the required parameter 'agentDnStr' is set
            if (agentDnStr == null) throw new ApiException(400, "Missing required parameter 'agentDnStr' when calling GetAgentLoginHistoryData");
    
            var path = "/ReportAgentLoginHistory/Pbx.GetAgentLoginHistoryData(clientTimeZone={clientTimeZone},startDt={startDt},endDt={endDt},queueDnStr={queueDnStr},agentDnStr={agentDnStr})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "clientTimeZone" + "}", ApiClient.ParameterToString(clientTimeZone));
path = path.Replace("{" + "startDt" + "}", ApiClient.ParameterToString(startDt));
path = path.Replace("{" + "endDt" + "}", ApiClient.ParameterToString(endDt));
path = path.Replace("{" + "queueDnStr" + "}", ApiClient.ParameterToString(queueDnStr));
path = path.Replace("{" + "agentDnStr" + "}", ApiClient.ParameterToString(agentDnStr));
    
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
 if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
 if (orderby != null) queryParams.Add("$orderby", ApiClient.ParameterToString(orderby)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "Application" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgentLoginHistoryData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgentLoginHistoryData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfAgentLoginHistory) ApiClient.Deserialize(response.Content, typeof(CollectionOfAgentLoginHistory), response.Headers);
        }
    
    }
}
