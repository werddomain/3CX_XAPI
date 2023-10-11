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
    public interface IReportAbandonedQueueCallsApi
    {
        /// <summary>
        /// Invoke function DownloadAbandonedQueueCalls 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="queueDns">Usage: queueDns&#x3D;{queueDns}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAbandonedQueueCalls</returns>
        CollectionOfAbandonedQueueCalls DownloadAbandonedQueueCalls (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
        /// <summary>
        /// Invoke function GetAbandonedQueueCallsData 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="queueDns">Usage: queueDns&#x3D;{queueDns}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAbandonedQueueCalls</returns>
        CollectionOfAbandonedQueueCalls GetAbandonedQueueCallsData (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportAbandonedQueueCallsApi : IReportAbandonedQueueCallsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAbandonedQueueCallsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportAbandonedQueueCallsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportAbandonedQueueCallsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportAbandonedQueueCallsApi(String basePath)
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
        /// Invoke function DownloadAbandonedQueueCalls 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="queueDns">Usage: queueDns&#x3D;{queueDns}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAbandonedQueueCalls</returns>
        public CollectionOfAbandonedQueueCalls DownloadAbandonedQueueCalls (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'periodFrom' is set
            if (periodFrom == null) throw new ApiException(400, "Missing required parameter 'periodFrom' when calling DownloadAbandonedQueueCalls");
            // verify the required parameter 'periodTo' is set
            if (periodTo == null) throw new ApiException(400, "Missing required parameter 'periodTo' when calling DownloadAbandonedQueueCalls");
            // verify the required parameter 'queueDns' is set
            if (queueDns == null) throw new ApiException(400, "Missing required parameter 'queueDns' when calling DownloadAbandonedQueueCalls");
            // verify the required parameter 'waitInterval' is set
            if (waitInterval == null) throw new ApiException(400, "Missing required parameter 'waitInterval' when calling DownloadAbandonedQueueCalls");
            // verify the required parameter 'clientTimeZone' is set
            if (clientTimeZone == null) throw new ApiException(400, "Missing required parameter 'clientTimeZone' when calling DownloadAbandonedQueueCalls");
    
            var path = "/ReportAbandonedQueueCalls/Pbx.DownloadAbandonedQueueCalls(periodFrom={periodFrom},periodTo={periodTo},queueDns={queueDns},waitInterval={waitInterval},clientTimeZone={clientTimeZone})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "periodFrom" + "}", ApiClient.ParameterToString(periodFrom));
path = path.Replace("{" + "periodTo" + "}", ApiClient.ParameterToString(periodTo));
path = path.Replace("{" + "queueDns" + "}", ApiClient.ParameterToString(queueDns));
path = path.Replace("{" + "waitInterval" + "}", ApiClient.ParameterToString(waitInterval));
path = path.Replace("{" + "clientTimeZone" + "}", ApiClient.ParameterToString(clientTimeZone));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadAbandonedQueueCalls: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadAbandonedQueueCalls: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfAbandonedQueueCalls) ApiClient.Deserialize(response.Content, typeof(CollectionOfAbandonedQueueCalls), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetAbandonedQueueCallsData 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="queueDns">Usage: queueDns&#x3D;{queueDns}</param>
        /// <param name="waitInterval">Usage: waitInterval&#x3D;{waitInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfAbandonedQueueCalls</returns>
        public CollectionOfAbandonedQueueCalls GetAbandonedQueueCallsData (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'periodFrom' is set
            if (periodFrom == null) throw new ApiException(400, "Missing required parameter 'periodFrom' when calling GetAbandonedQueueCallsData");
            // verify the required parameter 'periodTo' is set
            if (periodTo == null) throw new ApiException(400, "Missing required parameter 'periodTo' when calling GetAbandonedQueueCallsData");
            // verify the required parameter 'queueDns' is set
            if (queueDns == null) throw new ApiException(400, "Missing required parameter 'queueDns' when calling GetAbandonedQueueCallsData");
            // verify the required parameter 'waitInterval' is set
            if (waitInterval == null) throw new ApiException(400, "Missing required parameter 'waitInterval' when calling GetAbandonedQueueCallsData");
    
            var path = "/ReportAbandonedQueueCalls/Pbx.GetAbandonedQueueCallsData(periodFrom={periodFrom},periodTo={periodTo},queueDns={queueDns},waitInterval={waitInterval})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "periodFrom" + "}", ApiClient.ParameterToString(periodFrom));
path = path.Replace("{" + "periodTo" + "}", ApiClient.ParameterToString(periodTo));
path = path.Replace("{" + "queueDns" + "}", ApiClient.ParameterToString(queueDns));
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetAbandonedQueueCallsData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAbandonedQueueCallsData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfAbandonedQueueCalls) ApiClient.Deserialize(response.Content, typeof(CollectionOfAbandonedQueueCalls), response.Headers);
        }
    
    }
}
