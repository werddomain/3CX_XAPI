# IO.Swagger.Api.ReportCallCostByExtensionGroupApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadCallCostByExtensionGroup**](ReportCallCostByExtensionGroupApi.md#downloadcallcostbyextensiongroup) | **GET** /ReportCallCostByExtensionGroup/Pbx.DownloadCallCostByExtensionGroup(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},groupFilter&#x3D;{groupFilter},callClass&#x3D;{callClass},clientTimeZone&#x3D;{clientTimeZone}) | Invoke function DownloadCallCostByExtensionGroup
[**GetCallCostByExtensionGroupData**](ReportCallCostByExtensionGroupApi.md#getcallcostbyextensiongroupdata) | **GET** /ReportCallCostByExtensionGroup/Pbx.GetCallCostByExtensionGroupData(periodFrom&#x3D;{periodFrom},periodTo&#x3D;{periodTo},groupFilter&#x3D;{groupFilter},callClass&#x3D;{callClass}) | Invoke function GetCallCostByExtensionGroupData

<a name="downloadcallcostbyextensiongroup"></a>
# **DownloadCallCostByExtensionGroup**
> CollectionOfCallCostByExtensionGroup DownloadCallCostByExtensionGroup (DateTime? periodFrom, DateTime? periodTo, string groupFilter, int? callClass, string clientTimeZone, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadCallCostByExtensionGroup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadCallCostByExtensionGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportCallCostByExtensionGroupApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var groupFilter = groupFilter_example;  // string | Usage: groupFilter={groupFilter}
            var callClass = 56;  // int? | Usage: callClass={callClass}
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
                // Invoke function DownloadCallCostByExtensionGroup
                CollectionOfCallCostByExtensionGroup result = apiInstance.DownloadCallCostByExtensionGroup(periodFrom, periodTo, groupFilter, callClass, clientTimeZone, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportCallCostByExtensionGroupApi.DownloadCallCostByExtensionGroup: " + e.Message );
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
 **groupFilter** | **string**| Usage: groupFilter&#x3D;{groupFilter} | 
 **callClass** | **int?**| Usage: callClass&#x3D;{callClass} | 
 **clientTimeZone** | **string**| Usage: clientTimeZone&#x3D;{clientTimeZone} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfCallCostByExtensionGroup**](CollectionOfCallCostByExtensionGroup.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcallcostbyextensiongroupdata"></a>
# **GetCallCostByExtensionGroupData**
> CollectionOfCallCostByExtensionGroup GetCallCostByExtensionGroupData (DateTime? periodFrom, DateTime? periodTo, string groupFilter, int? callClass, int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function GetCallCostByExtensionGroupData

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCallCostByExtensionGroupDataExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReportCallCostByExtensionGroupApi();
            var periodFrom = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodFrom={periodFrom}
            var periodTo = 2013-10-20T19:20:30+01:00;  // DateTime? | Usage: periodTo={periodTo}
            var groupFilter = groupFilter_example;  // string | Usage: groupFilter={groupFilter}
            var callClass = 56;  // int? | Usage: callClass={callClass}
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function GetCallCostByExtensionGroupData
                CollectionOfCallCostByExtensionGroup result = apiInstance.GetCallCostByExtensionGroupData(periodFrom, periodTo, groupFilter, callClass, top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportCallCostByExtensionGroupApi.GetCallCostByExtensionGroupData: " + e.Message );
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
 **groupFilter** | **string**| Usage: groupFilter&#x3D;{groupFilter} | 
 **callClass** | **int?**| Usage: callClass&#x3D;{callClass} | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfCallCostByExtensionGroup**](CollectionOfCallCostByExtensionGroup.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

