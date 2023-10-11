# IO.Swagger.Api.ReportDetailedQueueStatisticsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadDetailedQueueStatistics**](ReportDetailedQueueStatisticsApi.md#downloaddetailedqueuestatistics) | **GET** /ReportDetailedQueueStatistics/Pbx.DownloadDetailedQueueStatistics(queueDnStr&#x3D;{queueDnStr},startDt&#x3D;{startDt},endDt&#x3D;{endDt},waitInterval&#x3D;{waitInterval}) | Invoke function DownloadDetailedQueueStatistics
[**GetDetailedQueueStatisticsData**](ReportDetailedQueueStatisticsApi.md#getdetailedqueuestatisticsdata) | **GET** /ReportDetailedQueueStatistics/Pbx.GetDetailedQueueStatisticsData(queueDnStr&#x3D;{queueDnStr},startDt&#x3D;{startDt},endDt&#x3D;{endDt},waitInterval&#x3D;{waitInterval}) | Invoke function GetDetailedQueueStatisticsData

<a name="downloaddetailedqueuestatistics"></a>
# **DownloadDetailedQueueStatistics**
> CollectionOfDetailedQueueStatistics DownloadDetailedQueueStatistics (string queueDnStr, DateTime? startDt, DateTime? endDt, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadDetailedQueueStatistics

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadDetailedQueueStatisticsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportDetailedQueueStatisticsApi();
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var waitInterval = waitInterval_example;  // string | Usage: waitInterval={waitInterval}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function DownloadDetailedQueueStatistics
                CollectionOfDetailedQueueStatistics result = apiInstance.DownloadDetailedQueueStatistics(queueDnStr, startDt, endDt, waitInterval, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportDetailedQueueStatisticsApi.DownloadDetailedQueueStatistics: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueDnStr** | **string**| Usage: queueDnStr&#x3D;{queueDnStr} | 
 **startDt** | **DateTime?**| Usage: startDt&#x3D;{startDt} | 
 **endDt** | **DateTime?**| Usage: endDt&#x3D;{endDt} | 
 **waitInterval** | **string**| Usage: waitInterval&#x3D;{waitInterval} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfDetailedQueueStatistics**](CollectionOfDetailedQueueStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdetailedqueuestatisticsdata"></a>
# **GetDetailedQueueStatisticsData**
> CollectionOfDetailedQueueStatistics GetDetailedQueueStatisticsData (string queueDnStr, DateTime? startDt, DateTime? endDt, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetDetailedQueueStatisticsData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDetailedQueueStatisticsDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportDetailedQueueStatisticsApi();
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var waitInterval = waitInterval_example;  // string | Usage: waitInterval={waitInterval}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetDetailedQueueStatisticsData
                CollectionOfDetailedQueueStatistics result = apiInstance.GetDetailedQueueStatisticsData(queueDnStr, startDt, endDt, waitInterval, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportDetailedQueueStatisticsApi.GetDetailedQueueStatisticsData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queueDnStr** | **string**| Usage: queueDnStr&#x3D;{queueDnStr} | 
 **startDt** | **DateTime?**| Usage: startDt&#x3D;{startDt} | 
 **endDt** | **DateTime?**| Usage: endDt&#x3D;{endDt} | 
 **waitInterval** | **string**| Usage: waitInterval&#x3D;{waitInterval} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfDetailedQueueStatistics**](CollectionOfDetailedQueueStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

