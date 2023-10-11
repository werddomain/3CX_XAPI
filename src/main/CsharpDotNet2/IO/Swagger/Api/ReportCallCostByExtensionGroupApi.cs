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
    public interface IReportCallCostByExtensionGroupApi
    {
        /// <summary>
        /// Invoke function DownloadCallCostByExtensionGroup 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="groupFilter">Usage: groupFilter&#x3D;{groupFilter}</param>
        /// <param name="callClass">Usage: callClass&#x3D;{callClass}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallCostByExtensionGroup</returns>
        CollectionOfCallCostByExtensionGroup DownloadCallCostByExtensionGroup (DateTime? periodFrom, DateTime? periodTo, string groupFilter, int? callClass, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
        /// <summary>
        /// Invoke function GetCallCostByExtensionGroupData 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="groupFilter">Usage: groupFilter&#x3D;{groupFilter}</param>
        /// <param name="callClass">Usage: callClass&#x3D;{callClass}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallCostByExtensionGroup</returns>
        CollectionOfCallCostByExtensionGroup GetCallCostByExtensionGroupData (DateTime? periodFrom, DateTime? periodTo, string groupFilter, int? callClass, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReportCallCostByExtensionGroupApi : IReportCallCostByExtensionGroupApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCallCostByExtensionGroupApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReportCallCostByExtensionGroupApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCallCostByExtensionGroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportCallCostByExtensionGroupApi(String basePath)
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
        /// Invoke function DownloadCallCostByExtensionGroup 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="groupFilter">Usage: groupFilter&#x3D;{groupFilter}</param>
        /// <param name="callClass">Usage: callClass&#x3D;{callClass}</param>
        /// <param name="clientTimeZone">Usage: clientTimeZone&#x3D;{clientTimeZone}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallCostByExtensionGroup</returns>
        public CollectionOfCallCostByExtensionGroup DownloadCallCostByExtensionGroup (DateTime? periodFrom, DateTime? periodTo, string groupFilter, int? callClass, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'periodFrom' is set
            if (periodFrom == null) throw new ApiException(400, "Missing required parameter 'periodFrom' when calling DownloadCallCostByExtensionGroup");
            // verify the required parameter 'periodTo' is set
            if (periodTo == null) throw new ApiException(400, "Missing required parameter 'periodTo' when calling DownloadCallCostByExtensionGroup");
            // verify the required parameter 'groupFilter' is set
            if (groupFilter == null) throw new ApiException(400, "Missing required parameter 'groupFilter' when calling DownloadCallCostByExtensionGroup");
            // verify the required parameter 'callClass' is set
            if (callClass == null) throw new ApiException(400, "Missing required parameter 'callClass' when calling DownloadCallCostByExtensionGroup");
            // verify the required parameter 'clientTimeZone' is set
            if (clientTimeZone == null) throw new ApiException(400, "Missing required parameter 'clientTimeZone' when calling DownloadCallCostByExtensionGroup");
    
            var path = "/ReportCallCostByExtensionGroup/Pbx.DownloadCallCostByExtensionGroup(periodFrom={periodFrom},periodTo={periodTo},groupFilter={groupFilter},callClass={callClass},clientTimeZone={clientTimeZone})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "periodFrom" + "}", ApiClient.ParameterToString(periodFrom));
path = path.Replace("{" + "periodTo" + "}", ApiClient.ParameterToString(periodTo));
path = path.Replace("{" + "groupFilter" + "}", ApiClient.ParameterToString(groupFilter));
path = path.Replace("{" + "callClass" + "}", ApiClient.ParameterToString(callClass));
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
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadCallCostByExtensionGroup: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadCallCostByExtensionGroup: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfCallCostByExtensionGroup) ApiClient.Deserialize(response.Content, typeof(CollectionOfCallCostByExtensionGroup), response.Headers);
        }
    
        /// <summary>
        /// Invoke function GetCallCostByExtensionGroupData 
        /// </summary>
        /// <param name="periodFrom">Usage: periodFrom&#x3D;{periodFrom}</param>
        /// <param name="periodTo">Usage: periodTo&#x3D;{periodTo}</param>
        /// <param name="groupFilter">Usage: groupFilter&#x3D;{groupFilter}</param>
        /// <param name="callClass">Usage: callClass&#x3D;{callClass}</param>
        /// <param name="top">Show only the first n items</param>
        /// <param name="skip">Skip the first n items</param>
        /// <param name="search">Search items by search phrases</param>
        /// <param name="filter">Filter items by property values</param>
        /// <param name="count">Include count of items</param>
        /// <param name="select">Select properties to be returned</param>
        /// <param name="orderby">Order items by property values</param>
        /// <returns>CollectionOfCallCostByExtensionGroup</returns>
        public CollectionOfCallCostByExtensionGroup GetCallCostByExtensionGroupData (DateTime? periodFrom, DateTime? periodTo, string groupFilter, int? callClass, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)
        {
            // verify the required parameter 'periodFrom' is set
            if (periodFrom == null) throw new ApiException(400, "Missing required parameter 'periodFrom' when calling GetCallCostByExtensionGroupData");
            // verify the required parameter 'periodTo' is set
            if (periodTo == null) throw new ApiException(400, "Missing required parameter 'periodTo' when calling GetCallCostByExtensionGroupData");
            // verify the required parameter 'groupFilter' is set
            if (groupFilter == null) throw new ApiException(400, "Missing required parameter 'groupFilter' when calling GetCallCostByExtensionGroupData");
            // verify the required parameter 'callClass' is set
            if (callClass == null) throw new ApiException(400, "Missing required parameter 'callClass' when calling GetCallCostByExtensionGroupData");
    
            var path = "/ReportCallCostByExtensionGroup/Pbx.GetCallCostByExtensionGroupData(periodFrom={periodFrom},periodTo={periodTo},groupFilter={groupFilter},callClass={callClass})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "periodFrom" + "}", ApiClient.ParameterToString(periodFrom));
path = path.Replace("{" + "periodTo" + "}", ApiClient.ParameterToString(periodTo));
path = path.Replace("{" + "groupFilter" + "}", ApiClient.ParameterToString(groupFilter));
path = path.Replace("{" + "callClass" + "}", ApiClient.ParameterToString(callClass));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCallCostByExtensionGroupData: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCallCostByExtensionGroupData: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CollectionOfCallCostByExtensionGroup) ApiClient.Deserialize(response.Content, typeof(CollectionOfCallCostByExtensionGroup), response.Headers);
        }
    
    }
}
