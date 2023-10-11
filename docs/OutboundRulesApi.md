# IO.Swagger.Api.OutboundRulesApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOutboundRule**](OutboundRulesApi.md#createoutboundrule) | **POST** /OutboundRules | Add new entity to OutboundRules
[**DeleteOutboundRule**](OutboundRulesApi.md#deleteoutboundrule) | **DELETE** /OutboundRules({Id}) | Delete entity from OutboundRules
[**GetOutboundRule**](OutboundRulesApi.md#getoutboundrule) | **GET** /OutboundRules({Id}) | Get entity from OutboundRules by key
[**ListOutboundRule**](OutboundRulesApi.md#listoutboundrule) | **GET** /OutboundRules | Get entities from OutboundRules
[**UpdateOutboundRule**](OutboundRulesApi.md#updateoutboundrule) | **PATCH** /OutboundRules({Id}) | Update entity in OutboundRules

<a name="createoutboundrule"></a>
# **CreateOutboundRule**
> PbxOutboundRule CreateOutboundRule (PbxOutboundRule body)

Add new entity to OutboundRules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOutboundRuleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OutboundRulesApi();
            var body = new PbxOutboundRule(); // PbxOutboundRule | New entity

            try
            {
                // Add new entity to OutboundRules
                PbxOutboundRule result = apiInstance.CreateOutboundRule(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundRulesApi.CreateOutboundRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxOutboundRule**](PbxOutboundRule.md)| New entity | 

### Return type

[**PbxOutboundRule**](PbxOutboundRule.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteoutboundrule"></a>
# **DeleteOutboundRule**
> void DeleteOutboundRule (int? id, string ifMatch)

Delete entity from OutboundRules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOutboundRuleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OutboundRulesApi();
            var id = 56;  // int? | The unique identifier of OutboundRule
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from OutboundRules
                apiInstance.DeleteOutboundRule(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundRulesApi.DeleteOutboundRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of OutboundRule | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getoutboundrule"></a>
# **GetOutboundRule**
> PbxOutboundRule GetOutboundRule (int? id, List<string> select, string expand)

Get entity from OutboundRules by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOutboundRuleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OutboundRulesApi();
            var id = 56;  // int? | The unique identifier of OutboundRule
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from OutboundRules by key
                PbxOutboundRule result = apiInstance.GetOutboundRule(id, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundRulesApi.GetOutboundRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of OutboundRule | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxOutboundRule**](PbxOutboundRule.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listoutboundrule"></a>
# **ListOutboundRule**
> PbxOutboundRuleCollectionResponse ListOutboundRule (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from OutboundRules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListOutboundRuleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OutboundRulesApi();
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
                // Get entities from OutboundRules
                PbxOutboundRuleCollectionResponse result = apiInstance.ListOutboundRule(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundRulesApi.ListOutboundRule: " + e.Message );
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

[**PbxOutboundRuleCollectionResponse**](PbxOutboundRuleCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateoutboundrule"></a>
# **UpdateOutboundRule**
> void UpdateOutboundRule (PbxOutboundRule body, int? id)

Update entity in OutboundRules

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateOutboundRuleExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OutboundRulesApi();
            var body = new PbxOutboundRule(); // PbxOutboundRule | New property values
            var id = 56;  // int? | The unique identifier of OutboundRule

            try
            {
                // Update entity in OutboundRules
                apiInstance.UpdateOutboundRule(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OutboundRulesApi.UpdateOutboundRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxOutboundRule**](PbxOutboundRule.md)| New property values | 
 **id** | **int?**| The unique identifier of OutboundRule | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

