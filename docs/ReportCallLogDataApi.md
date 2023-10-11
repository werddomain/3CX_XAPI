# IO.Swagger.Api.ReportCallLogDataApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadCallLog**](ReportCallLogDataApi.md#downloadcalllog) | **GET** /ReportCallLogData/Pbx.DownloadCallLog(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},sourceType&#x3D;{sourceType},sourceFilter&#x3D;{sourceFilter},destinationType&#x3D;{destinationType},destinationFilter&#x3D;{destinationFilter},callsType&#x3D;{callsType},callTimeFilterType&#x3D;{callTimeFilterType},callTimeFilterFrom&#x3D;{callTimeFilterFrom},callTimeFilterTo&#x3D;{callTimeFilterTo},hidePcalls&#x3D;{hidePcalls},clientTimeZone&#x3D;{clientTimeZone}) | Invoke function DownloadCallLog
[**GetCallLogData**](ReportCallLogDataApi.md#getcalllogdata) | **GET** /ReportCallLogData/Pbx.GetCallLogData(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},sourceType&#x3D;{sourceType},sourceFilter&#x3D;{sourceFilter},destinationType&#x3D;{destinationType},destinationFilter&#x3D;{destinationFilter},callsType&#x3D;{callsType},callTimeFilterType&#x3D;{callTimeFilterType},callTimeFilterFrom&#x3D;{callTimeFilterFrom},callTimeFilterTo&#x3D;{callTimeFilterTo},hidePcalls&#x3D;{hidePcalls}) | Invoke function GetCallLogData

<a name="downloadcalllog"></a>
# **DownloadCallLog**
> CollectionOfCallLogData DownloadCallLog (DateTime? periodFrom, DateTime? periodTo, int? sourceType, string sourceFilter, int? destinationType, string destinationFilter, int? callsType, int? callTimeFilterType, string callTimeFilterFrom, string callTimeFilterTo, bool? hidePcalls, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadCallLog

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadCallLogExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportCallLogDataApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var sourceType = 56;  // int? | Usage: sourceType={sourceType}
            var sourceFilter = sourceFilter_example;  // string | Usage: sourceFilter={sourceFilter}
            var destinationType = 56;  // int? | Usage: destinationType={destinationType}
            var destinationFilter = destinationFilter_example;  // string | Usage: destinationFilter={destinationFilter}
            var callsType = 56;  // int? | Usage: callsType={callsType}
            var callTimeFilterType = 56;  // int? | Usage: callTimeFilterType={callTimeFilterType}
            var callTimeFilterFrom = callTimeFilterFrom_example;  // string | Usage: callTimeFilterFrom={callTimeFilterFrom}
            var callTimeFilterTo = callTimeFilterTo_example;  // string | Usage: callTimeFilterTo={callTimeFilterTo}
            var hidePcalls = true;  // bool? | Usage: hidePcalls={hidePcalls}
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
                // Invoke function DownloadCallLog
                CollectionOfCallLogData result = apiInstance.DownloadCallLog(periodFrom, periodTo, sourceType, sourceFilter, destinationType, destinationFilter, callsType, callTimeFilterType, callTimeFilterFrom, callTimeFilterTo, hidePcalls, clientTimeZone, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportCallLogDataApi.DownloadCallLog: " + e.Message );
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
 **sourceType** | **int?**| Usage: sourceType&#x3D;{sourceType} | 
 **sourceFilter** | **string**| Usage: sourceFilter&#x3D;{sourceFilter} | 
 **destinationType** | **int?**| Usage: destinationType&#x3D;{destinationType} | 
 **destinationFilter** | **string**| Usage: destinationFilter&#x3D;{destinationFilter} | 
 **callsType** | **int?**| Usage: callsType&#x3D;{callsType} | 
 **callTimeFilterType** | **int?**| Usage: callTimeFilterType&#x3D;{callTimeFilterType} | 
 **callTimeFilterFrom** | **string**| Usage: callTimeFilterFrom&#x3D;{callTimeFilterFrom} | 
 **callTimeFilterTo** | **string**| Usage: callTimeFilterTo&#x3D;{callTimeFilterTo} | 
 **hidePcalls** | **bool?**| Usage: hidePcalls&#x3D;{hidePcalls} | 
 **clientTimeZone** | **string**| Usage: clientTimeZone&#x3D;{clientTimeZone} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfCallLogData**](CollectionOfCallLogData.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcalllogdata"></a>
# **GetCallLogData**
> CollectionOfCallLogData GetCallLogData (DateTime? periodFrom, DateTime? periodTo, int? sourceType, string sourceFilter, int? destinationType, string destinationFilter, int? callsType, int? callTimeFilterType, string callTimeFilterFrom, string callTimeFilterTo, bool? hidePcalls, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetCallLogData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCallLogDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportCallLogDataApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var sourceType = 56;  // int? | Usage: sourceType={sourceType}
            var sourceFilter = sourceFilter_example;  // string | Usage: sourceFilter={sourceFilter}
            var destinationType = 56;  // int? | Usage: destinationType={destinationType}
            var destinationFilter = destinationFilter_example;  // string | Usage: destinationFilter={destinationFilter}
            var callsType = 56;  // int? | Usage: callsType={callsType}
            var callTimeFilterType = 56;  // int? | Usage: callTimeFilterType={callTimeFilterType}
            var callTimeFilterFrom = callTimeFilterFrom_example;  // string | Usage: callTimeFilterFrom={callTimeFilterFrom}
            var callTimeFilterTo = callTimeFilterTo_example;  // string | Usage: callTimeFilterTo={callTimeFilterTo}
            var hidePcalls = true;  // bool? | Usage: hidePcalls={hidePcalls}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetCallLogData
                CollectionOfCallLogData result = apiInstance.GetCallLogData(periodFrom, periodTo, sourceType, sourceFilter, destinationType, destinationFilter, callsType, callTimeFilterType, callTimeFilterFrom, callTimeFilterTo, hidePcalls, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportCallLogDataApi.GetCallLogData: " + e.Message );
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
 **sourceType** | **int?**| Usage: sourceType&#x3D;{sourceType} | 
 **sourceFilter** | **string**| Usage: sourceFilter&#x3D;{sourceFilter} | 
 **destinationType** | **int?**| Usage: destinationType&#x3D;{destinationType} | 
 **destinationFilter** | **string**| Usage: destinationFilter&#x3D;{destinationFilter} | 
 **callsType** | **int?**| Usage: callsType&#x3D;{callsType} | 
 **callTimeFilterType** | **int?**| Usage: callTimeFilterType&#x3D;{callTimeFilterType} | 
 **callTimeFilterFrom** | **string**| Usage: callTimeFilterFrom&#x3D;{callTimeFilterFrom} | 
 **callTimeFilterTo** | **string**| Usage: callTimeFilterTo&#x3D;{callTimeFilterTo} | 
 **hidePcalls** | **bool?**| Usage: hidePcalls&#x3D;{hidePcalls} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfCallLogData**](CollectionOfCallLogData.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

