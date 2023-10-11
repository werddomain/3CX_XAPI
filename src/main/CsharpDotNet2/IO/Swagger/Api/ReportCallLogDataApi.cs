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
    public interface IReportCallLogDataApi
    {
        /// <summary>
        /// Invoke function DownloadCallLog 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="sourceType">Usage: sourceType&#x3D;{sourceType}</param>
        /// <param name="sourceFilter">Usage: sourceFilter&#x3D;{sourceFilter}</param>
        /// <param name="destinationType">Usage: destinationType&#x3D;{destinationType}</param>
        /// <param name="destinationFilter">Usage: destinationFilter&#x3D;{destinationFilter}</param>
        /// <param name="callsType">Usage: callsType&#x3D;{callsType}</param>
        /// <param name="callTimeFilterType">Usage: callTimeFilterType&#x3D;{callTimeFilterType}</param>
        /// <param name="callTimeFilterFrom">Usage: callTimeFilterFrom&#x3D;{callTimeFilterFrom}</param>
        /// <param name="callTimeFilterTo">Usage: callTimeFilterTo&#x3D;{callTimeFilterTo}</param>
        /// <param name="hidePcalls">Usage: hidePcalls&#x3D;{hidePcalls}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallLogData</returns>
        CollectionOfCallLogData DownloadCallLog (DateTime? periodFrom, DateTime? periodTo, int? sourceType, string sourceFilter, int? destinationType, string destinationFilter, int? callsType, int? callTimeFilterType, string callTimeFilterFrom, string callTimeFilterTo, bool? hidePcalls, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
        /// <summary>
        /// Invoke function GetCallLogData 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="sourceType">Usage: sourceType&#x3D;{sourceType}</param>
        /// <param name="sourceFilter">Usage: sourceFilter&#x3D;{sourceFilter}</param>
        /// <param name="destinationType">Usage: destinationType&#x3D;{destinationType}</param>
        /// <param name="destinationFilter">Usage: destinationFilter&#x3D;{destinationFilter}</param>
        /// <param name="callsType">Usage: callsType&#x3D;{callsType}</param>
        /// <param name="callTimeFilterType">Usage: callTimeFilterType&#x3D;{callTimeFilterType}</param>
        /// <param name="callTimeFilterFrom">Usage: callTimeFilterFrom&#x3D;{callTimeFilterFrom}</param>
        /// <param name="callTimeFilterTo">Usage: callTimeFilterTo&#x3D;{callTimeFilterTo}</param>
        /// <param name="hidePcalls">Usage: hidePcalls&#x3D;{hidePcalls}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallLogData</returns>
        CollectionOfCallLogData GetCallLogData (DateTime? periodFrom, DateTime? periodTo, int? sourceType, string sourceFilter, int? destinationType, string destinationFilter, int? callsType, int? callTimeFilterType, string callTimeFilterFrom, string callTimeFilterTo, bool? hidePcalls, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportCallLogDataApi : IReportCallLogDataApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCallLogDataApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportCallLogDataApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCallLogDataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportCallLogDataApi(String basePath)
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
        /// Invoke function DownloadCallLog 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="sourceType">Usage: sourceType&#x3D;{sourceType}</param>
        /// <param name="sourceFilter">Usage: sourceFilter&#x3D;{sourceFilter}</param>
        /// <param name="destinationType">Usage: destinationType&#x3D;{destinationType}</param>
        /// <param name="destinationFilter">Usage: destinationFilter&#x3D;{destinationFilter}</param>
        /// <param name="callsType">Usage: callsType&#x3D;{callsType}</param>
        /// <param name="callTimeFilterType">Usage: callTimeFilterType&#x3D;{callTimeFilterType}</param>
        /// <param name="callTimeFilterFrom">Usage: callTimeFilterFrom&#x3D;{callTimeFilterFrom}</param>
        /// <param name="callTimeFilterTo">Usage: callTimeFilterTo&#x3D;{callTimeFilterTo}</param>
        /// <param name="hidePcalls">Usage: hidePcalls&#x3D;{hidePcalls}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallLogData</returns>
        public CollectionOfCallLogData DownloadCallLog (DateTime? periodFrom, DateTime? periodTo, int? sourceType, string sourceFilter, int? destinationType, string destinationFilter, int? callsType, int? callTimeFilterType, string callTimeFilterFrom, string callTimeFilterTo, bool? hidePcalls, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'periodFrom' is set
            if (periodFrom == null) throw new ApiException(400, "Missing required parameter 'periodFrom' when calling DownloadCallLog");
            // verify the required parameter 'periodTo' is set
            if (periodTo == null) throw new ApiException(400, "Missing required parameter 'periodTo' when calling DownloadCallLog");
            // verify the required parameter 'sourceType' is set
            if (sourceType == null) throw new ApiException(400, "Missing required parameter 'sourceType' when calling DownloadCallLog");
            // verify the required parameter 'sourceFilter' is set
            if (sourceFilter == null) throw new ApiException(400, "Missing required parameter 'sourceFilter' when calling DownloadCallLog");
            // verify the required parameter 'destinationType' is set
            if (destinationType == null) throw new ApiException(400, "Missing required parameter 'destinationType' when calling DownloadCallLog");
            // verify the required parameter 'destinationFilter' is set
            if (destinationFilter == null) throw new ApiException(400, "Missing required parameter 'destinationFilter' when calling DownloadCallLog");
            // verify the required parameter 'callsType' is set
            if (callsType == null) throw new ApiException(400, "Missing required parameter 'callsType' when calling DownloadCallLog");
            // verify the required parameter 'callTimeFilterType' is set
            if (callTimeFilterType == null) throw new ApiException(400, "Missing required parameter 'callTimeFilterType' when calling DownloadCallLog");
            // verify the required parameter 'callTimeFilterFrom' is set
            if (callTimeFilterFrom == null) throw new ApiException(400, "Missing required parameter 'callTimeFilterFrom' when calling DownloadCallLog");
            // verify the required parameter 'callTimeFilterTo' is set
            if (callTimeFilterTo == null) throw new ApiException(400, "Missing required parameter 'callTimeFilterTo' when calling DownloadCallLog");
            // verify the required parameter 'hidePcalls' is set
            if (hidePcalls == null) throw new ApiException(400, "Missing required parameter 'hidePcalls' when calling DownloadCallLog");
            // verify the required parameter 'clientTimeZone' is set
            if (clientTimeZone == null) throw new ApiException(400, "Missing required parameter 'clientTimeZone' when calling DownloadCallLog");
    
            var path = "/ReportCallLogData/Pbx.DownloadCallLog(periodFrom={periodFrom},periodTo={periodTo},sourceType={sourceType},sourceFilter={sourceFilter},destinationType={destinationType},destinationFilter={destinationFilter},callsType={callsType},callTimeFilterType={callTimeFilterType},callTimeFilterFrom={callTimeFilterFrom},callTimeFilterTo={callTimeFilterTo},hidePcalls={hidePcalls},clientTimeZone={clientTimeZone})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "periodFrom" + "}", ApiClient.ParameterToString(periodFrom));
path = path.Replace("{" + "periodTo" + "}", ApiClient.ParameterToString(periodTo));
path = path.Replace("{" + "sourceType" + "}", ApiClient.ParameterToString(sourceType));
path = path.Replace("{" + "sourceFilter" + "}", ApiClient.ParameterToString(sourceFilter));
path = path.Replace("{" + "destinationType" + "}", ApiClient.ParameterToString(destinationType));
path = path.Replace("{" + "destinationFilter" + "}", ApiClient.ParameterToString(destinationFilter));
path = path.Replace("{" + "callsType" + "}", ApiClient.ParameterToString(callsType));
path = path.Replace("{" + "callTimeFilterType" + "}", ApiClient.ParameterToString(callTimeFilterType));
path = path.Replace("{" + "callTimeFilterFrom" + "}", ApiClient.ParameterToString(callTimeFilterFrom));
path = path.Replace("{" + "callTimeFilterTo" + "}", ApiClient.ParameterToString(callTimeFilterTo));
path = path.Replace("{" + "hidePcalls" + "}", ApiClient.ParameterToString(hidePcalls));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadCallLog: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadCallLog: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfCallLogData) ApiClient.Deserialize(response.Content, typeof(CollectionOfCallLogData), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetCallLogData 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="sourceType">Usage: sourceType&#x3D;{sourceType}</param>
        /// <param name="sourceFilter">Usage: sourceFilter&#x3D;{sourceFilter}</param>
        /// <param name="destinationType">Usage: destinationType&#x3D;{destinationType}</param>
        /// <param name="destinationFilter">Usage: destinationFilter&#x3D;{destinationFilter}</param>
        /// <param name="callsType">Usage: callsType&#x3D;{callsType}</param>
        /// <param name="callTimeFilterType">Usage: callTimeFilterType&#x3D;{callTimeFilterType}</param>
        /// <param name="callTimeFilterFrom">Usage: callTimeFilterFrom&#x3D;{callTimeFilterFrom}</param>
        /// <param name="callTimeFilterTo">Usage: callTimeFilterTo&#x3D;{callTimeFilterTo}</param>
        /// <param name="hidePcalls">Usage: hidePcalls&#x3D;{hidePcalls}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallLogData</returns>
        public CollectionOfCallLogData GetCallLogData (DateTime? periodFrom, DateTime? periodTo, int? sourceType, string sourceFilter, int? destinationType, string destinationFilter, int? callsType, int? callTimeFilterType, string callTimeFilterFrom, string callTimeFilterTo, bool? hidePcalls, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'periodFrom' is set
            if (periodFrom == null) throw new ApiException(400, "Missing required parameter 'periodFrom' when calling GetCallLogData");
            // verify the required parameter 'periodTo' is set
            if (periodTo == null) throw new ApiException(400, "Missing required parameter 'periodTo' when calling GetCallLogData");
            // verify the required parameter 'sourceType' is set
            if (sourceType == null) throw new ApiException(400, "Missing required parameter 'sourceType' when calling GetCallLogData");
            // verify the required parameter 'sourceFilter' is set
            if (sourceFilter == null) throw new ApiException(400, "Missing required parameter 'sourceFilter' when calling GetCallLogData");
            // verify the required parameter 'destinationType' is set
            if (destinationType == null) throw new ApiException(400, "Missing required parameter 'destinationType' when calling GetCallLogData");
            // verify the required parameter 'destinationFilter' is set
            if (destinationFilter == null) throw new ApiException(400, "Missing required parameter 'destinationFilter' when calling GetCallLogData");
            // verify the required parameter 'callsType' is set
            if (callsType == null) throw new ApiException(400, "Missing required parameter 'callsType' when calling GetCallLogData");
            // verify the required parameter 'callTimeFilterType' is set
            if (callTimeFilterType == null) throw new ApiException(400, "Missing required parameter 'callTimeFilterType' when calling GetCallLogData");
            // verify the required parameter 'callTimeFilterFrom' is set
            if (callTimeFilterFrom == null) throw new ApiException(400, "Missing required parameter 'callTimeFilterFrom' when calling GetCallLogData");
            // verify the required parameter 'callTimeFilterTo' is set
            if (callTimeFilterTo == null) throw new ApiException(400, "Missing required parameter 'callTimeFilterTo' when calling GetCallLogData");
            // verify the required parameter 'hidePcalls' is set
            if (hidePcalls == null) throw new ApiException(400, "Missing required parameter 'hidePcalls' when calling GetCallLogData");
    
            var path = "/ReportCallLogData/Pbx.GetCallLogData(periodFrom={periodFrom},periodTo={periodTo},sourceType={sourceType},sourceFilter={sourceFilter},destinationType={destinationType},destinationFilter={destinationFilter},callsType={callsType},callTimeFilterType={callTimeFilterType},callTimeFilterFrom={callTimeFilterFrom},callTimeFilterTo={callTimeFilterTo},hidePcalls={hidePcalls})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "periodFrom" + "}", ApiClient.ParameterToString(periodFrom));
path = path.Replace("{" + "periodTo" + "}", ApiClient.ParameterToString(periodTo));
path = path.Replace("{" + "sourceType" + "}", ApiClient.ParameterToString(sourceType));
path = path.Replace("{" + "sourceFilter" + "}", ApiClient.ParameterToString(sourceFilter));
path = path.Replace("{" + "destinationType" + "}", ApiClient.ParameterToString(destinationType));
path = path.Replace("{" + "destinationFilter" + "}", ApiClient.ParameterToString(destinationFilter));
path = path.Replace("{" + "callsType" + "}", ApiClient.ParameterToString(callsType));
path = path.Replace("{" + "callTimeFilterType" + "}", ApiClient.ParameterToString(callTimeFilterType));
path = path.Replace("{" + "callTimeFilterFrom" + "}", ApiClient.ParameterToString(callTimeFilterFrom));
path = path.Replace("{" + "callTimeFilterTo" + "}", ApiClient.ParameterToString(callTimeFilterTo));
path = path.Replace("{" + "hidePcalls" + "}", ApiClient.ParameterToString(hidePcalls));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCallLogData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCallLogData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfCallLogData) ApiClient.Deserialize(response.Content, typeof(CollectionOfCallLogData), response.Headers);
        }
    
    }
}
