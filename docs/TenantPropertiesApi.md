# IO.Swagger.Api.TenantPropertiesApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProperty**](TenantPropertiesApi.md#createproperty) | **POST** /TenantProperties | Add new entity to TenantProperties
[**DeleteProperty**](TenantPropertiesApi.md#deleteproperty) | **DELETE** /TenantProperties({Name}) | Delete entity from TenantProperties
[**GetProperty**](TenantPropertiesApi.md#getproperty) | **GET** /TenantProperties({Name}) | Get entity from TenantProperties by key
[**ListProperty**](TenantPropertiesApi.md#listproperty) | **GET** /TenantProperties | Get entities from TenantProperties
[**UpdateProperty**](TenantPropertiesApi.md#updateproperty) | **PATCH** /TenantProperties({Name}) | Update entity in TenantProperties

<a name="createproperty"></a>
# **CreateProperty**
> PbxProperty CreateProperty (PbxProperty body)

Add new entity to TenantProperties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreatePropertyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantPropertiesApi();
            var body = new PbxProperty(); // PbxProperty | New entity

            try
            {
                // Add new entity to TenantProperties
                PbxProperty result = apiInstance.CreateProperty(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantPropertiesApi.CreateProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxProperty**](PbxProperty.md)| New entity | 

### Return type

[**PbxProperty**](PbxProperty.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteproperty"></a>
# **DeleteProperty**
> void DeleteProperty (string name, string ifMatch)

Delete entity from TenantProperties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePropertyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantPropertiesApi();
            var name = name_example;  // string | The unique identifier of Property
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from TenantProperties
                apiInstance.DeleteProperty(name, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantPropertiesApi.DeleteProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The unique identifier of Property | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getproperty"></a>
# **GetProperty**
> PbxProperty GetProperty (string name, List<string> select, string expand)

Get entity from TenantProperties by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPropertyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantPropertiesApi();
            var name = name_example;  // string | The unique identifier of Property
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from TenantProperties by key
                PbxProperty result = apiInstance.GetProperty(name, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantPropertiesApi.GetProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The unique identifier of Property | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxProperty**](PbxProperty.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listproperty"></a>
# **ListProperty**
> PbxPropertyCollectionResponse ListProperty (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from TenantProperties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPropertyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantPropertiesApi();
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
                // Get entities from TenantProperties
                PbxPropertyCollectionResponse result = apiInstance.ListProperty(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantPropertiesApi.ListProperty: " + e.Message );
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

[**PbxPropertyCollectionResponse**](PbxPropertyCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateproperty"></a>
# **UpdateProperty**
> void UpdateProperty (PbxProperty body, string name)

Update entity in TenantProperties

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePropertyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantPropertiesApi();
            var body = new PbxProperty(); // PbxProperty | New property values
            var name = name_example;  // string | The unique identifier of Property

            try
            {
                // Update entity in TenantProperties
                apiInstance.UpdateProperty(body, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantPropertiesApi.UpdateProperty: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxProperty**](PbxProperty.md)| New property values | 
 **name** | **string**| The unique identifier of Property | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

