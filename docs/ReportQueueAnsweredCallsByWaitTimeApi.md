# IO.Swagger.Api.ReportQueueAnsweredCallsByWaitTimeApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadQueueAnsweredCallsByWaitTime**](ReportQueueAnsweredCallsByWaitTimeApi.md#downloadqueueansweredcallsbywaittime) | **GET** /ReportQueueAnsweredCallsByWaitTime/Pbx.DownloadQueueAnsweredCallsByWaitTime(queueDnStr&#x3D;{queueDnStr},startDt&#x3D;{startDt},endDt&#x3D;{endDt},answerInterval&#x3D;{answerInterval},clientTimeZone&#x3D;{clientTimeZone}) | Invoke function DownloadQueueAnsweredCallsByWaitTime
[**GetQueueAnsweredCallsByWaitTimeData**](ReportQueueAnsweredCallsByWaitTimeApi.md#getqueueansweredcallsbywaittimedata) | **GET** /ReportQueueAnsweredCallsByWaitTime/Pbx.GetQueueAnsweredCallsByWaitTimeData(queueDnStr&#x3D;{queueDnStr},startDt&#x3D;{startDt},endDt&#x3D;{endDt},answerInterval&#x3D;{answerInterval}) | Invoke function GetQueueAnsweredCallsByWaitTimeData

<a name="downloadqueueansweredcallsbywaittime"></a>
# **DownloadQueueAnsweredCallsByWaitTime**
> CollectionOfQueueAnsweredCallsByWaitTime DownloadQueueAnsweredCallsByWaitTime (string queueDnStr, DateTime? startDt, DateTime? endDt, string answerInterval, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadQueueAnsweredCallsByWaitTime

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadQueueAnsweredCallsByWaitTimeExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportQueueAnsweredCallsByWaitTimeApi();
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var answerInterval = answerInterval_example;  // string | Usage: answerInterval={answerInterval}
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
                // Invoke function DownloadQueueAnsweredCallsByWaitTime
                CollectionOfQueueAnsweredCallsByWaitTime result = apiInstance.DownloadQueueAnsweredCallsByWaitTime(queueDnStr, startDt, endDt, answerInterval, clientTimeZone, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportQueueAnsweredCallsByWaitTimeApi.DownloadQueueAnsweredCallsByWaitTime: " + e.Message );
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
 **answerInterval** | **string**| Usage: answerInterval&#x3D;{answerInterval} | 
 **clientTimeZone** | **string**| Usage: clientTimeZone&#x3D;{clientTimeZone} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfQueueAnsweredCallsByWaitTime**](CollectionOfQueueAnsweredCallsByWaitTime.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqueueansweredcallsbywaittimedata"></a>
# **GetQueueAnsweredCallsByWaitTimeData**
> CollectionOfQueueAnsweredCallsByWaitTime GetQueueAnsweredCallsByWaitTimeData (string queueDnStr, DateTime? startDt, DateTime? endDt, string answerInterval, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetQueueAnsweredCallsByWaitTimeData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetQueueAnsweredCallsByWaitTimeDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportQueueAnsweredCallsByWaitTimeApi();
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var answerInterval = answerInterval_example;  // string | Usage: answerInterval={answerInterval}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetQueueAnsweredCallsByWaitTimeData
                CollectionOfQueueAnsweredCallsByWaitTime result = apiInstance.GetQueueAnsweredCallsByWaitTimeData(queueDnStr, startDt, endDt, answerInterval, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportQueueAnsweredCallsByWaitTimeApi.GetQueueAnsweredCallsByWaitTimeData: " + e.Message );
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
 **answerInterval** | **string**| Usage: answerInterval&#x3D;{answerInterval} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfQueueAnsweredCallsByWaitTime**](CollectionOfQueueAnsweredCallsByWaitTime.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

