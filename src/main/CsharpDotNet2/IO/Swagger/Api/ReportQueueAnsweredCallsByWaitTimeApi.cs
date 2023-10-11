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
    public interface IReportQueueAnsweredCallsByWaitTimeApi
    {
        /// <summary>
        /// Invoke function DownloadQueueAnsweredCallsByWaitTime 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="answerInterval">Usage: answerInterval&#x3D;{answerInterval}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfQueueAnsweredCallsByWaitTime</returns>
        CollectionOfQueueAnsweredCallsByWaitTime DownloadQueueAnsweredCallsByWaitTime (string queueDnStr, DateTime? startDt, DateTime? endDt, string answerInterval, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
        /// <summary>
        /// Invoke function GetQueueAnsweredCallsByWaitTimeData 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="answerInterval">Usage: answerInterval&#x3D;{answerInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfQueueAnsweredCallsByWaitTime</returns>
        CollectionOfQueueAnsweredCallsByWaitTime GetQueueAnsweredCallsByWaitTimeData (string queueDnStr, DateTime? startDt, DateTime? endDt, string answerInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportQueueAnsweredCallsByWaitTimeApi : IReportQueueAnsweredCallsByWaitTimeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportQueueAnsweredCallsByWaitTimeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportQueueAnsweredCallsByWaitTimeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportQueueAnsweredCallsByWaitTimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportQueueAnsweredCallsByWaitTimeApi(String basePath)
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
        /// Invoke function DownloadQueueAnsweredCallsByWaitTime 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="answerInterval">Usage: answerInterval&#x3D;{answerInterval}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfQueueAnsweredCallsByWaitTime</returns>
        public CollectionOfQueueAnsweredCallsByWaitTime DownloadQueueAnsweredCallsByWaitTime (string queueDnStr, DateTime? startDt, DateTime? endDt, string answerInterval, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'queueDnStr' is set
            if (queueDnStr == null) throw new ApiException(400, "Missing required parameter 'queueDnStr' when calling DownloadQueueAnsweredCallsByWaitTime");
            // verify the required parameter 'startDt' is set
            if (startDt == null) throw new ApiException(400, "Missing required parameter 'startDt' when calling DownloadQueueAnsweredCallsByWaitTime");
            // verify the required parameter 'endDt' is set
            if (endDt == null) throw new ApiException(400, "Missing required parameter 'endDt' when calling DownloadQueueAnsweredCallsByWaitTime");
            // verify the required parameter 'answerInterval' is set
            if (answerInterval == null) throw new ApiException(400, "Missing required parameter 'answerInterval' when calling DownloadQueueAnsweredCallsByWaitTime");
            // verify the required parameter 'clientTimeZone' is set
            if (clientTimeZone == null) throw new ApiException(400, "Missing required parameter 'clientTimeZone' when calling DownloadQueueAnsweredCallsByWaitTime");
    
            var path = "/ReportQueueAnsweredCallsByWaitTime/Pbx.DownloadQueueAnsweredCallsByWaitTime(queueDnStr={queueDnStr},startDt={startDt},endDt={endDt},answerInterval={answerInterval},clientTimeZone={clientTimeZone})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "queueDnStr" + "}", ApiClient.ParameterToString(queueDnStr));
path = path.Replace("{" + "startDt" + "}", ApiClient.ParameterToString(startDt));
path = path.Replace("{" + "endDt" + "}", ApiClient.ParameterToString(endDt));
path = path.Replace("{" + "answerInterval" + "}", ApiClient.ParameterToString(answerInterval));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadQueueAnsweredCallsByWaitTime: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadQueueAnsweredCallsByWaitTime: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfQueueAnsweredCallsByWaitTime) ApiClient.Deserialize(response.Content, typeof(CollectionOfQueueAnsweredCallsByWaitTime), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetQueueAnsweredCallsByWaitTimeData 
        /// </summary>
        /// <param name="queueDnStr">Usage: queueDnStr&#x3D;{queueDnStr}</param>
        /// <param name="startDt">Usage: startDt&#x3D;{startDt}</param>
        /// <param name="endDt">Usage: endDt&#x3D;{endDt}</param>
        /// <param name="answerInterval">Usage: answerInterval&#x3D;{answerInterval}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfQueueAnsweredCallsByWaitTime</returns>
        public CollectionOfQueueAnsweredCallsByWaitTime GetQueueAnsweredCallsByWaitTimeData (string queueDnStr, DateTime? startDt, DateTime? endDt, string answerInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'queueDnStr' is set
            if (queueDnStr == null) throw new ApiException(400, "Missing required parameter 'queueDnStr' when calling GetQueueAnsweredCallsByWaitTimeData");
            // verify the required parameter 'startDt' is set
            if (startDt == null) throw new ApiException(400, "Missing required parameter 'startDt' when calling GetQueueAnsweredCallsByWaitTimeData");
            // verify the required parameter 'endDt' is set
            if (endDt == null) throw new ApiException(400, "Missing required parameter 'endDt' when calling GetQueueAnsweredCallsByWaitTimeData");
            // verify the required parameter 'answerInterval' is set
            if (answerInterval == null) throw new ApiException(400, "Missing required parameter 'answerInterval' when calling GetQueueAnsweredCallsByWaitTimeData");
    
            var path = "/ReportQueueAnsweredCallsByWaitTime/Pbx.GetQueueAnsweredCallsByWaitTimeData(queueDnStr={queueDnStr},startDt={startDt},endDt={endDt},answerInterval={answerInterval})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "queueDnStr" + "}", ApiClient.ParameterToString(queueDnStr));
path = path.Replace("{" + "startDt" + "}", ApiClient.ParameterToString(startDt));
path = path.Replace("{" + "endDt" + "}", ApiClient.ParameterToString(endDt));
path = path.Replace("{" + "answerInterval" + "}", ApiClient.ParameterToString(answerInterval));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetQueueAnsweredCallsByWaitTimeData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetQueueAnsweredCallsByWaitTimeData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfQueueAnsweredCallsByWaitTime) ApiClient.Deserialize(response.Content, typeof(CollectionOfQueueAnsweredCallsByWaitTime), response.Headers);
        }
    
    }
}
