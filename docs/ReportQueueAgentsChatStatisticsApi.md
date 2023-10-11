# IO.Swagger.Api.ReportQueueAgentsChatStatisticsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadQueueAgentsChatStatistics**](ReportQueueAgentsChatStatisticsApi.md#downloadqueueagentschatstatistics) | **GET** /ReportQueueAgentsChatStatistics/Pbx.DownloadQueueAgentsChatStatistics(queueDnStr&#x3D;{queueDnStr},startDt&#x3D;{startDt},endDt&#x3D;{endDt},participantType&#x3D;{participantType}) | Invoke function DownloadQueueAgentsChatStatistics
[**GetQueueAgentsChatStatisticsData**](ReportQueueAgentsChatStatisticsApi.md#getqueueagentschatstatisticsdata) | **GET** /ReportQueueAgentsChatStatistics/Pbx.GetQueueAgentsChatStatisticsData(queueDnStr&#x3D;{queueDnStr},startDt&#x3D;{startDt},endDt&#x3D;{endDt},participantType&#x3D;{participantType}) | Invoke function GetQueueAgentsChatStatisticsData

<a name="downloadqueueagentschatstatistics"></a>
# **DownloadQueueAgentsChatStatistics**
> CollectionOfQueueAgentsChatStatistics DownloadQueueAgentsChatStatistics (string queueDnStr, DateTime? startDt, DateTime? endDt, int? participantType, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadQueueAgentsChatStatistics

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadQueueAgentsChatStatisticsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportQueueAgentsChatStatisticsApi();
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var participantType = 56;  // int? | Usage: participantType={participantType}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function DownloadQueueAgentsChatStatistics
                CollectionOfQueueAgentsChatStatistics result = apiInstance.DownloadQueueAgentsChatStatistics(queueDnStr, startDt, endDt, participantType, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportQueueAgentsChatStatisticsApi.DownloadQueueAgentsChatStatistics: " + e.Message );
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
 **participantType** | **int?**| Usage: participantType&#x3D;{participantType} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfQueueAgentsChatStatistics**](CollectionOfQueueAgentsChatStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueueagentschatstatisticsdata"></a>
# **GetQueueAgentsChatStatisticsData**
> CollectionOfQueueAgentsChatStatistics GetQueueAgentsChatStatisticsData (string queueDnStr, DateTime? startDt, DateTime? endDt, int? participantType, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetQueueAgentsChatStatisticsData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueueAgentsChatStatisticsDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportQueueAgentsChatStatisticsApi();
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var participantType = 56;  // int? | Usage: participantType={participantType}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetQueueAgentsChatStatisticsData
                CollectionOfQueueAgentsChatStatistics result = apiInstance.GetQueueAgentsChatStatisticsData(queueDnStr, startDt, endDt, participantType, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportQueueAgentsChatStatisticsApi.GetQueueAgentsChatStatisticsData: " + e.Message );
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
 **participantType** | **int?**| Usage: participantType&#x3D;{participantType} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfQueueAgentsChatStatistics**](CollectionOfQueueAgentsChatStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

