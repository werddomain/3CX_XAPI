# IO.Swagger.Api.ReportExtensionStatisticsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadExtensionStatistics**](ReportExtensionStatisticsApi.md#downloadextensionstatistics) | **GET** /ReportExtensionStatistics/Pbx.DownloadExtensionStatistics(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},extensionFilter&#x3D;{extensionFilter},callArea&#x3D;{callArea}) | Invoke function DownloadExtensionStatistics
[**GetExtensionStatisticsData**](ReportExtensionStatisticsApi.md#getextensionstatisticsdata) | **GET** /ReportExtensionStatistics/Pbx.GetExtensionStatisticsData(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},extensionFilter&#x3D;{extensionFilter},callArea&#x3D;{callArea}) | Invoke function GetExtensionStatisticsData

<a name="downloadextensionstatistics"></a>
# **DownloadExtensionStatistics**
> CollectionOfExtensionStatistics DownloadExtensionStatistics (DateTime? periodFrom, DateTime? periodTo, string extensionFilter, int? callArea, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadExtensionStatistics

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadExtensionStatisticsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportExtensionStatisticsApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var extensionFilter = extensionFilter_example;  // string | Usage: extensionFilter={extensionFilter}
            var callArea = 56;  // int? | Usage: callArea={callArea}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function DownloadExtensionStatistics
                CollectionOfExtensionStatistics result = apiInstance.DownloadExtensionStatistics(periodFrom, periodTo, extensionFilter, callArea, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportExtensionStatisticsApi.DownloadExtensionStatistics: " + e.Message );
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
 **extensionFilter** | **string**| Usage: extensionFilter&#x3D;{extensionFilter} | 
 **callArea** | **int?**| Usage: callArea&#x3D;{callArea} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfExtensionStatistics**](CollectionOfExtensionStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getextensionstatisticsdata"></a>
# **GetExtensionStatisticsData**
> CollectionOfExtensionStatistics GetExtensionStatisticsData (DateTime? periodFrom, DateTime? periodTo, string extensionFilter, int? callArea, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetExtensionStatisticsData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExtensionStatisticsDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportExtensionStatisticsApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var extensionFilter = extensionFilter_example;  // string | Usage: extensionFilter={extensionFilter}
            var callArea = 56;  // int? | Usage: callArea={callArea}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetExtensionStatisticsData
                CollectionOfExtensionStatistics result = apiInstance.GetExtensionStatisticsData(periodFrom, periodTo, extensionFilter, callArea, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportExtensionStatisticsApi.GetExtensionStatisticsData: " + e.Message );
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
 **extensionFilter** | **string**| Usage: extensionFilter&#x3D;{extensionFilter} | 
 **callArea** | **int?**| Usage: callArea&#x3D;{callArea} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfExtensionStatistics**](CollectionOfExtensionStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

