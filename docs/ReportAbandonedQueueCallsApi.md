# IO.Swagger.Api.ReportAbandonedQueueCallsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadAbandonedQueueCalls**](ReportAbandonedQueueCallsApi.md#downloadabandonedqueuecalls) | **GET** /ReportAbandonedQueueCalls/Pbx.DownloadAbandonedQueueCalls(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},queueDns&#x3D;{queueDns},waitInterval&#x3D;{waitInterval},clientTimeZone&#x3D;{clientTimeZone}) | Invoke function DownloadAbandonedQueueCalls
[**GetAbandonedQueueCallsData**](ReportAbandonedQueueCallsApi.md#getabandonedqueuecallsdata) | **GET** /ReportAbandonedQueueCalls/Pbx.GetAbandonedQueueCallsData(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},queueDns&#x3D;{queueDns},waitInterval&#x3D;{waitInterval}) | Invoke function GetAbandonedQueueCallsData

<a name="downloadabandonedqueuecalls"></a>
# **DownloadAbandonedQueueCalls**
> CollectionOfAbandonedQueueCalls DownloadAbandonedQueueCalls (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadAbandonedQueueCalls

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadAbandonedQueueCallsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportAbandonedQueueCallsApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var queueDns = queueDns_example;  // string | Usage: queueDns={queueDns}
            var waitInterval = waitInterval_example;  // string | Usage: waitInterval={waitInterval}
            var clientTimeZone = clientTimeZone_example;  // string | Usage: clientTimeZone={clientTimeZone}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function DownloadAbandonedQueueCalls
                CollectionOfAbandonedQueueCalls result = apiInstance.DownloadAbandonedQueueCalls(periodFrom, periodTo, queueDns, waitInterval, clientTimeZone, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportAbandonedQueueCallsApi.DownloadAbandonedQueueCalls: " + e.Message );
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
 **clientTimeZone** | **string**| Usage: clientTimeZone&#x3D;{clientTimeZone} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfAbandonedQueueCalls**](CollectionOfAbandonedQueueCalls.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getabandonedqueuecallsdata"></a>
# **GetAbandonedQueueCallsData**
> CollectionOfAbandonedQueueCalls GetAbandonedQueueCallsData (DateTime? periodFrom, DateTime? periodTo, string queueDns, string waitInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetAbandonedQueueCallsData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAbandonedQueueCallsDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportAbandonedQueueCallsApi();
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
                // Invoke function GetAbandonedQueueCallsData
                CollectionOfAbandonedQueueCalls result = apiInstance.GetAbandonedQueueCallsData(periodFrom, periodTo, queueDns, waitInterval, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportAbandonedQueueCallsApi.GetAbandonedQueueCallsData: " + e.Message );
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

[**CollectionOfAbandonedQueueCalls**](CollectionOfAbandonedQueueCalls.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

