# IO.Swagger.Api.CallHistoryViewApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DownloadCallHistory**](CallHistoryViewApi.md#downloadcallhistory) | **GET** /CallHistoryView/Pbx.DownloadCallHistory() | Invoke function DownloadCallHistory
[**ListCallHistoryView**](CallHistoryViewApi.md#listcallhistoryview) | **GET** /CallHistoryView | Get entities from CallHistoryView

<a name="downloadcallhistory"></a>
# **DownloadCallHistory**
> CollectionOfCallHistoryView DownloadCallHistory (int? top, int? skip, string search, string filter, bool? count, List<string> select, List<string> orderby)

Invoke function DownloadCallHistory

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DownloadCallHistoryExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHistoryViewApi();
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 

            try
            {
                // Invoke function DownloadCallHistory
                CollectionOfCallHistoryView result = apiInstance.DownloadCallHistory(top, skip, search, filter, count, select, orderby);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallHistoryViewApi.DownloadCallHistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 

### Return type

[**CollectionOfCallHistoryView**](CollectionOfCallHistoryView.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcallhistoryview"></a>
# **ListCallHistoryView**
> PbxCallHistoryViewCollectionResponse ListCallHistoryView (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from CallHistoryView

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListCallHistoryViewExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CallHistoryViewApi();
            var top = 56;  // int? | Show only the first n items (optional) 
            var skip = 56;  // int? | Skip the first n items (optional) 
            var search = search_example;  // string | Search items by search phrases (optional) 
            var filter = filter_example;  // string | Filter items by property values (optional) 
            var count = true;  // bool? | Include count of items (optional) 
            var orderby = new List<string>(); // List<string> | Order items by property values (optional) 
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entities from CallHistoryView
                PbxCallHistoryViewCollectionResponse result = apiInstance.ListCallHistoryView(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallHistoryViewApi.ListCallHistoryView: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxCallHistoryViewCollectionResponse**](PbxCallHistoryViewCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

