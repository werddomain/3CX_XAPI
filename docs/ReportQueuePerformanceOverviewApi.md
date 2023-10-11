# IO.Swagger.Api.ReportQueuePerformanceOverviewApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadQueuePerformanceOverview**](ReportQueuePerformanceOverviewApi.md#downloadqueueperformanceoverview) | **GET** /ReportQueuePerformanceOverview/Pbx.DownloadQueuePerformanceOverview(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},queueDns&#x3D;{queueDns},waitInterval&#x3D;{waitInterval}) | Invoke function DownloadQueuePerformanceOverview
[**GetQueuePerformanceOverviewData**](ReportQueuePerformanceOverviewApi.md#getqueueperformanceoverviewdata) | **GET** /ReportQueuePerformanceOverview/Pbx.GetQueuePerformanceOverviewData(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},queueDns&#x3D;{queueDns},waitInterval&#x3D;{waitInterval}) | Invoke function GetQueuePerformanceOverviewData

<a name="downloadqueueperformanceoverview"></a>
# **DownloadQueuePerformanceOverview**
> CollectionOfQueuePerformanceOverview DownloadQueuePerformanceOverview (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadQueuePerformanceOverview

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadQueuePerformanceOverviewExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportQueuePerformanceOverviewApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var queueDns = queueDns_example;  // string | Usage: queueDns={queueDns}
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
                // Invoke function DownloadQueuePerformanceOverview
                CollectionOfQueuePerformanceOverview result = apiInstance.DownloadQueuePerformanceOverview(periodFrom, periodTo, queueDns, waitInterval, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportQueuePerformanceOverviewApi.DownloadQueuePerformanceOverview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **periodFrom** | **DateTime?**| Usage: periodFrom&#x3D;{periodFrom} | 
 **periodTo** | **DateTime?**| Usage: periodTo&#x3D;{periodTo} | 
 **queueDns** | **string**| Usage: queueDns&#x3D;{queueDns} | 
 **waitInterval** | **string**| Usage: waitInterval&#x3D;{waitInterval} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfQueuePerformanceOverview**](CollectionOfQueuePerformanceOverview.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueueperformanceoverviewdata"></a>
# **GetQueuePerformanceOverviewData**
> CollectionOfQueuePerformanceOverview GetQueuePerformanceOverviewData (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetQueuePerformanceOverviewData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueuePerformanceOverviewDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportQueuePerformanceOverviewApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var queueDns = queueDns_example;  // string | Usage: queueDns={queueDns}
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
                // Invoke function GetQueuePerformanceOverviewData
                CollectionOfQueuePerformanceOverview result = apiInstance.GetQueuePerformanceOverviewData(periodFrom, periodTo, queueDns, waitInterval, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportQueuePerformanceOverviewApi.GetQueuePerformanceOverviewData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **periodFrom** | **DateTime?**| Usage: periodFrom&#x3D;{periodFrom} | 
 **periodTo** | **DateTime?**| Usage: periodTo&#x3D;{periodTo} | 
 **queueDns** | **string**| Usage: queueDns&#x3D;{queueDns} | 
 **waitInterval** | **string**| Usage: waitInterval&#x3D;{waitInterval} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfQueuePerformanceOverview**](CollectionOfQueuePerformanceOverview.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

