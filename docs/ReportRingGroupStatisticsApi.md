# IO.Swagger.Api.ReportRingGroupStatisticsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadRingGroupStatistics**](ReportRingGroupStatisticsApi.md#downloadringgroupstatistics) | **GET** /ReportRingGroupStatistics/Pbx.DownloadRingGroupStatistics(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},ringGroupDns&#x3D;{ringGroupDns}) | Invoke function DownloadRingGroupStatistics
[**GetRingGroupStatisticsData**](ReportRingGroupStatisticsApi.md#getringgroupstatisticsdata) | **GET** /ReportRingGroupStatistics/Pbx.GetRingGroupStatisticsData(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},ringGroupDns&#x3D;{ringGroupDns}) | Invoke function GetRingGroupStatisticsData
[**GetRingGroupStatisticsDataPost**](ReportRingGroupStatisticsApi.md#getringgroupstatisticsdatapost) | **POST** /ReportRingGroupStatistics/Pbx.GetRingGroupStatisticsDataPost | Invoke action GetRingGroupStatisticsDataPost

<a name="downloadringgroupstatistics"></a>
# **DownloadRingGroupStatistics**
> CollectionOfRingGroupStatistics DownloadRingGroupStatistics (DateTime? periodFrom, DateTime? periodTo, string ringGroupDns, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadRingGroupStatistics

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadRingGroupStatisticsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportRingGroupStatisticsApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var ringGroupDns = ringGroupDns_example;  // string | Usage: ringGroupDns={ringGroupDns}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function DownloadRingGroupStatistics
                CollectionOfRingGroupStatistics result = apiInstance.DownloadRingGroupStatistics(periodFrom, periodTo, ringGroupDns, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportRingGroupStatisticsApi.DownloadRingGroupStatistics: " + e.Message );
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
 **ringGroupDns** | **string**| Usage: ringGroupDns&#x3D;{ringGroupDns} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfRingGroupStatistics**](CollectionOfRingGroupStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getringgroupstatisticsdata"></a>
# **GetRingGroupStatisticsData**
> CollectionOfRingGroupStatistics GetRingGroupStatisticsData (DateTime? periodFrom, DateTime? periodTo, string ringGroupDns, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetRingGroupStatisticsData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRingGroupStatisticsDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportRingGroupStatisticsApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var ringGroupDns = ringGroupDns_example;  // string | Usage: ringGroupDns={ringGroupDns}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetRingGroupStatisticsData
                CollectionOfRingGroupStatistics result = apiInstance.GetRingGroupStatisticsData(periodFrom, periodTo, ringGroupDns, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportRingGroupStatisticsApi.GetRingGroupStatisticsData: " + e.Message );
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
 **ringGroupDns** | **string**| Usage: ringGroupDns&#x3D;{ringGroupDns} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfRingGroupStatistics**](CollectionOfRingGroupStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getringgroupstatisticsdatapost"></a>
# **GetRingGroupStatisticsDataPost**
> CollectionOfRingGroupStatistics GetRingGroupStatisticsDataPost (ReportRingGroupStatisticsGetRingGroupStatisticsDataPostRequestBody body)

Invoke action GetRingGroupStatisticsDataPost

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRingGroupStatisticsDataPostExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportRingGroupStatisticsApi();
            var body = new ReportRingGroupStatisticsGetRingGroupStatisticsDataPostRequestBody(); // ReportRingGroupStatisticsGetRingGroupStatisticsDataPostRequestBody | Action parameters

            try
            {
                // Invoke action GetRingGroupStatisticsDataPost
                CollectionOfRingGroupStatistics result = apiInstance.GetRingGroupStatisticsDataPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportRingGroupStatisticsApi.GetRingGroupStatisticsDataPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportRingGroupStatisticsGetRingGroupStatisticsDataPostRequestBody**](ReportRingGroupStatisticsGetRingGroupStatisticsDataPostRequestBody.md)| Action parameters | 

### Return type

[**CollectionOfRingGroupStatistics**](CollectionOfRingGroupStatistics.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

