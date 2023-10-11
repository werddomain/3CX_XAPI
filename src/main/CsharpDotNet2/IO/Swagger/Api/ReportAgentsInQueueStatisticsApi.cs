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
    public interface IReportAgentsInQueueStatisticsApi
    {
        /// <summary>
        /// Invoke function DownloadAgentsInQueueStatistics 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentsInQueueStatistics</returns>
        CollectionOfAgentsInQueueStatistics DownloadAgentsInQueueStatistics (string queueDnStr, DateTime? startDt, DateTime? endDt, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
        /// <summary>
        /// Invoke function GetAgentsInQueueStatisticsData 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentsInQueueStatistics</returns>
        CollectionOfAgentsInQueueStatistics GetAgentsInQueueStatisticsData (string queueDnStr, DateTime? startDt, DateTime? endDt, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportAgentsInQueueStatisticsApi : IReportAgentsInQueueStatisticsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAgentsInQueueStatisticsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportAgentsInQueueStatisticsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAgentsInQueueStatisticsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportAgentsInQueueStatisticsApi(String basePath)
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
        /// Invoke function DownloadAgentsInQueueStatistics 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentsInQueueStatistics</returns>
        public CollectionOfAgentsInQueueStatistics DownloadAgentsInQueueStatistics (string queueDnStr, DateTime? startDt, DateTime? endDt, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'queueDnStr' is set
            if (queueDnStr == null) throw new ApiException(400, "Missing required parameter 'queueDnStr' when calling DownloadAgentsInQueueStatistics");
            // verify the required parameter 'startDt' is set
            if (startDt == null) throw new ApiException(400, "Missing required parameter 'startDt' when calling DownloadAgentsInQueueStatistics");
            // verify the required parameter 'endDt' is set
            if (endDt == null) throw new ApiException(400, "Missing required parameter 'endDt' when calling DownloadAgentsInQueueStatistics");
            // verify the required parameter 'waitInterval' is set
            if (waitInterval == null) throw new ApiException(400, "Missing required parameter 'waitInterval' when calling DownloadAgentsInQueueStatistics");
    
            var path = "/ReportAgentsInQueueStatistics/Pbx.DownloadAgentsInQueueStatistics(queueDnStr={queueDnStr},startDt={startDt},endDt={endDt},waitInterval={waitInterval})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "queueDnStr" + "}", ApiClient.ParameterToString(queueDnStr));
path = path.Replace("{" + "startDt" + "}", ApiClient.ParameterToString(startDt));
path = path.Replace("{" + "endDt" + "}", ApiClient.ParameterToString(endDt));
path = path.Replace("{" + "waitInterval" + "}", ApiClient.ParameterToString(waitInterval));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadAgentsInQueueStatistics: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadAgentsInQueueStatistics: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfAgentsInQueueStatistics) ApiClient.Deserialize(response.Content, typeof(CollectionOfAgentsInQueueStatistics), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetAgentsInQueueStatisticsData 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAgentsInQueueStatistics</returns>
        public CollectionOfAgentsInQueueStatistics GetAgentsInQueueStatisticsData (string queueDnStr, DateTime? startDt, DateTime? endDt, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'queueDnStr' is set
            if (queueDnStr == null) throw new ApiException(400, "Missing required parameter 'queueDnStr' when calling GetAgentsInQueueStatisticsData");
            // verify the required parameter 'startDt' is set
            if (startDt == null) throw new ApiException(400, "Missing required parameter 'startDt' when calling GetAgentsInQueueStatisticsData");
            // verify the required parameter 'endDt' is set
            if (endDt == null) throw new ApiException(400, "Missing required parameter 'endDt' when calling GetAgentsInQueueStatisticsData");
            // verify the required parameter 'waitInterval' is set
            if (waitInterval == null) throw new ApiException(400, "Missing required parameter 'waitInterval' when calling GetAgentsInQueueStatisticsData");
    
            var path = "/ReportAgentsInQueueStatistics/Pbx.GetAgentsInQueueStatisticsData(queueDnStr={queueDnStr},startDt={startDt},endDt={endDt},waitInterval={waitInterval})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "queueDnStr" + "}", ApiClient.ParameterToString(queueDnStr));
path = path.Replace("{" + "startDt" + "}", ApiClient.ParameterToString(startDt));
path = path.Replace("{" + "endDt" + "}", ApiClient.ParameterToString(endDt));
path = path.Replace("{" + "waitInterval" + "}", ApiClient.ParameterToString(waitInterval));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgentsInQueueStatisticsData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAgentsInQueueStatisticsData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfAgentsInQueueStatistics) ApiClient.Deserialize(response.Content, typeof(CollectionOfAgentsInQueueStatistics), response.Headers);
        }
    
    }
}
