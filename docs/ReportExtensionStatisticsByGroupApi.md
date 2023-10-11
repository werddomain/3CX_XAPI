# IO.Swagger.Api.ReportExtensionStatisticsByGroupApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadExtensionStatisticsByGroup**](ReportExtensionStatisticsByGroupApi.md#downloadextensionstatisticsbygroup) | **GET** /ReportExtensionStatisticsByGroup/Pbx.DownloadExtensionStatisticsByGroup(groupId&#x3D;{groupId},periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},callArea&#x3D;{callArea}) | Invoke function DownloadExtensionStatisticsByGroup
[**GetExtensionStatisticsByGroupData**](ReportExtensionStatisticsByGroupApi.md#getextensionstatisticsbygroupdata) | **GET** /ReportExtensionStatisticsByGroup/Pbx.GetExtensionStatisticsByGroupData(groupId&#x3D;{groupId},periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},callArea&#x3D;{callArea}) | Invoke function GetExtensionStatisticsByGroupData

<a name="downloadextensionstatisticsbygroup"></a>
# **DownloadExtensionStatisticsByGroup**
> CollectionOfReportExtensionStatisticsByGroup DownloadExtensionStatisticsByGroup (int? groupId, DateTime? periodFrom, DateTime? periodTo, int? callArea, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadExtensionStatisticsByGroup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadExtensionStatisticsByGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportExtensionStatisticsByGroupApi();
            var groupId = 56;  // int? | Usage: groupId={groupId}
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
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
                // Invoke function DownloadExtensionStatisticsByGroup
                CollectionOfReportExtensionStatisticsByGroup result = apiInstance.DownloadExtensionStatisticsByGroup(groupId, periodFrom, periodTo, callArea, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportExtensionStatisticsByGroupApi.DownloadExtensionStatisticsByGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| Usage: groupId&#x3D;{groupId} | 
 **periodFrom** | **DateTime?**| Usage: periodFrom&#x3D;{periodFrom} | 
 **periodTo** | **DateTime?**| Usage: periodTo&#x3D;{periodTo} | 
 **callArea** | **int?**| Usage: callArea&#x3D;{callArea} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfReportExtensionStatisticsByGroup**](CollectionOfReportExtensionStatisticsByGroup.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getextensionstatisticsbygroupdata"></a>
# **GetExtensionStatisticsByGroupData**
> CollectionOfReportExtensionStatisticsByGroup GetExtensionStatisticsByGroupData (int? groupId, DateTime? periodFrom, DateTime? periodTo, int? callArea, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetExtensionStatisticsByGroupData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExtensionStatisticsByGroupDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportExtensionStatisticsByGroupApi();
            var groupId = 56;  // int? | Usage: groupId={groupId}
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
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
                // Invoke function GetExtensionStatisticsByGroupData
                CollectionOfReportExtensionStatisticsByGroup result = apiInstance.GetExtensionStatisticsByGroupData(groupId, periodFrom, periodTo, callArea, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportExtensionStatisticsByGroupApi.GetExtensionStatisticsByGroupData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupId** | **int?**| Usage: groupId&#x3D;{groupId} | 
 **periodFrom** | **DateTime?**| Usage: periodFrom&#x3D;{periodFrom} | 
 **periodTo** | **DateTime?**| Usage: periodTo&#x3D;{periodTo} | 
 **callArea** | **int?**| Usage: callArea&#x3D;{callArea} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfReportExtensionStatisticsByGroup**](CollectionOfReportExtensionStatisticsByGroup.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

