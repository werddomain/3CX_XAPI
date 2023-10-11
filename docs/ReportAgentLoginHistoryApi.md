# IO.Swagger.Api.ReportAgentLoginHistoryApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadAgentLoginHistory**](ReportAgentLoginHistoryApi.md#downloadagentloginhistory) | **GET** /ReportAgentLoginHistory/Pbx.DownloadAgentLoginHistory(clientTimeZone&#x3D;{clientTimeZone},startDt&#x3D;{startDt},endDt&#x3D;{endDt},queueDnStr&#x3D;{queueDnStr},agentDnStr&#x3D;{agentDnStr}) | Invoke function DownloadAgentLoginHistory
[**GetAgentLoginHistoryData**](ReportAgentLoginHistoryApi.md#getagentloginhistorydata) | **GET** /ReportAgentLoginHistory/Pbx.GetAgentLoginHistoryData(clientTimeZone&#x3D;{clientTimeZone},startDt&#x3D;{startDt},endDt&#x3D;{endDt},queueDnStr&#x3D;{queueDnStr},agentDnStr&#x3D;{agentDnStr}) | Invoke function GetAgentLoginHistoryData

<a name="downloadagentloginhistory"></a>
# **DownloadAgentLoginHistory**
> CollectionOfAgentLoginHistory DownloadAgentLoginHistory (string clientTimeZone, DateTime? startDt, DateTime? endDt, string queueDnStr, string agentDnStr, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadAgentLoginHistory

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadAgentLoginHistoryExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportAgentLoginHistoryApi();
            var clientTimeZone = clientTimeZone_example;  // string | Usage: clientTimeZone={clientTimeZone}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var agentDnStr = agentDnStr_example;  // string | Usage: agentDnStr={agentDnStr}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function DownloadAgentLoginHistory
                CollectionOfAgentLoginHistory result = apiInstance.DownloadAgentLoginHistory(clientTimeZone, startDt, endDt, queueDnStr, agentDnStr, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportAgentLoginHistoryApi.DownloadAgentLoginHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientTimeZone** | **string**| Usage: clientTimeZone&#x3D;{clientTimeZone} | 
 **startDt** | **DateTime?**| Usage: startDt&#x3D;{startDt} | 
 **endDt** | **DateTime?**| Usage: endDt&#x3D;{endDt} | 
 **queueDnStr** | **string**| Usage: queueDnStr&#x3D;{queueDnStr} | 
 **agentDnStr** | **string**| Usage: agentDnStr&#x3D;{agentDnStr} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfAgentLoginHistory**](CollectionOfAgentLoginHistory.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getagentloginhistorydata"></a>
# **GetAgentLoginHistoryData**
> CollectionOfAgentLoginHistory GetAgentLoginHistoryData (string clientTimeZone, DateTime? startDt, DateTime? endDt, string queueDnStr, string agentDnStr, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetAgentLoginHistoryData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetAgentLoginHistoryDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportAgentLoginHistoryApi();
            var clientTimeZone = clientTimeZone_example;  // string | Usage: clientTimeZone={clientTimeZone}
            var startDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: startDt={startDt}
            var endDt = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: endDt={endDt}
            var queueDnStr = queueDnStr_example;  // string | Usage: queueDnStr={queueDnStr}
            var agentDnStr = agentDnStr_example;  // string | Usage: agentDnStr={agentDnStr}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetAgentLoginHistoryData
                CollectionOfAgentLoginHistory result = apiInstance.GetAgentLoginHistoryData(clientTimeZone, startDt, endDt, queueDnStr, agentDnStr, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportAgentLoginHistoryApi.GetAgentLoginHistoryData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientTimeZone** | **string**| Usage: clientTimeZone&#x3D;{clientTimeZone} | 
 **startDt** | **DateTime?**| Usage: startDt&#x3D;{startDt} | 
 **endDt** | **DateTime?**| Usage: endDt&#x3D;{endDt} | 
 **queueDnStr** | **string**| Usage: queueDnStr&#x3D;{queueDnStr} | 
 **agentDnStr** | **string**| Usage: agentDnStr&#x3D;{agentDnStr} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfAgentLoginHistory**](CollectionOfAgentLoginHistory.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

