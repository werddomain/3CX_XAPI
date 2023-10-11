# IO.Swagger.Api.ReportExtensionsStatisticsByRingGroupsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadExtensionsStatisticsByRingGroups**](ReportExtensionsStatisticsByRingGroupsApi.md#downloadextensionsstatisticsbyringgroups) | **GET** /ReportExtensionsStatisticsByRingGroups/Pbx.DownloadExtensionsStatisticsByRingGroups(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},ringGroupDns&#x3D;{ringGroupDns}) | Invoke function DownloadExtensionsStatisticsByRingGroups
[**GetExtensionsStatisticsByRingGroupsData**](ReportExtensionsStatisticsByRingGroupsApi.md#getextensionsstatisticsbyringgroupsdata) | **GET** /ReportExtensionsStatisticsByRingGroups/Pbx.GetExtensionsStatisticsByRingGroupsData(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},ringGroupDns&#x3D;{ringGroupDns}) | Invoke function GetExtensionsStatisticsByRingGroupsData

<a name="downloadextensionsstatisticsbyringgroups"></a>
# **DownloadExtensionsStatisticsByRingGroups**
> CollectionOfExtensionsStatisticsByRingGroups DownloadExtensionsStatisticsByRingGroups (DateTime? periodFrom, DateTime? periodTo, string ringGroupDns, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadExtensionsStatisticsByRingGroups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadExtensionsStatisticsByRingGroupsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportExtensionsStatisticsByRingGroupsApi();
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
                // Invoke function DownloadExtensionsStatisticsByRingGroups
                CollectionOfExtensionsStatisticsByRingGroups result = apiInstance.DownloadExtensionsStatisticsByRingGroups(periodFrom, periodTo, ringGroupDns, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportExtensionsStatisticsByRingGroupsApi.DownloadExtensionsStatisticsByRingGroups: " + e.Message );
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

[**CollectionOfExtensionsStatisticsByRingGroups**](CollectionOfExtensionsStatisticsByRingGroups.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getextensionsstatisticsbyringgroupsdata"></a>
# **GetExtensionsStatisticsByRingGroupsData**
> CollectionOfExtensionsStatisticsByRingGroups GetExtensionsStatisticsByRingGroupsData (DateTime? periodFrom, DateTime? periodTo, string ringGroupDns, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetExtensionsStatisticsByRingGroupsData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExtensionsStatisticsByRingGroupsDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportExtensionsStatisticsByRingGroupsApi();
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
                // Invoke function GetExtensionsStatisticsByRingGroupsData
                CollectionOfExtensionsStatisticsByRingGroups result = apiInstance.GetExtensionsStatisticsByRingGroupsData(periodFrom, periodTo, ringGroupDns, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportExtensionsStatisticsByRingGroupsApi.GetExtensionsStatisticsByRingGroupsData: " + e.Message );
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

[**CollectionOfExtensionsStatisticsByRingGroups**](CollectionOfExtensionsStatisticsByRingGroups.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

