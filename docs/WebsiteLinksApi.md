# IO.Swagger.Api.WebsiteLinksApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkLinksDelete**](WebsiteLinksApi.md#bulklinksdelete) | **POST** /WebsiteLinks/Pbx.BulkLinksDelete | Invoke action BulkLinksDelete
[**CreateWeblink**](WebsiteLinksApi.md#createweblink) | **POST** /WebsiteLinks | Add new entity to WebsiteLinks
[**DeleteWeblink**](WebsiteLinksApi.md#deleteweblink) | **DELETE** /WebsiteLinks({Link}) | Delete entity from WebsiteLinks
[**GetWeblink**](WebsiteLinksApi.md#getweblink) | **GET** /WebsiteLinks({Link}) | Get entity from WebsiteLinks by key
[**ListWeblink**](WebsiteLinksApi.md#listweblink) | **GET** /WebsiteLinks | Get entities from WebsiteLinks
[**UpdateWeblink**](WebsiteLinksApi.md#updateweblink) | **PATCH** /WebsiteLinks({Link}) | Update entity in WebsiteLinks
[**ValidateLink**](WebsiteLinksApi.md#validatelink) | **POST** /WebsiteLinks/Pbx.ValidateLink | Invoke action ValidateLink

<a name="bulklinksdelete"></a>
# **BulkLinksDelete**
> void BulkLinksDelete (WebsiteLinksBulkLinksDeleteRequestBody body)

Invoke action BulkLinksDelete

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkLinksDeleteExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteLinksApi();
            var body = new WebsiteLinksBulkLinksDeleteRequestBody(); // WebsiteLinksBulkLinksDeleteRequestBody | Action parameters

            try
            {
                // Invoke action BulkLinksDelete
                apiInstance.BulkLinksDelete(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteLinksApi.BulkLinksDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebsiteLinksBulkLinksDeleteRequestBody**](WebsiteLinksBulkLinksDeleteRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createweblink"></a>
# **CreateWeblink**
> PbxWeblink CreateWeblink (PbxWeblink body)

Add new entity to WebsiteLinks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateWeblinkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteLinksApi();
            var body = new PbxWeblink(); // PbxWeblink | New entity

            try
            {
                // Add new entity to WebsiteLinks
                PbxWeblink result = apiInstance.CreateWeblink(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteLinksApi.CreateWeblink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxWeblink**](PbxWeblink.md)| New entity | 

### Return type

[**PbxWeblink**](PbxWeblink.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteweblink"></a>
# **DeleteWeblink**
> void DeleteWeblink (string link, string ifMatch)

Delete entity from WebsiteLinks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteWeblinkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteLinksApi();
            var link = link_example;  // string | The unique identifier of Weblink
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from WebsiteLinks
                apiInstance.DeleteWeblink(link, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteLinksApi.DeleteWeblink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **link** | **string**| The unique identifier of Weblink | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getweblink"></a>
# **GetWeblink**
> PbxWeblink GetWeblink (string link, List<string> select, string expand)

Get entity from WebsiteLinks by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWeblinkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteLinksApi();
            var link = link_example;  // string | The unique identifier of Weblink
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from WebsiteLinks by key
                PbxWeblink result = apiInstance.GetWeblink(link, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteLinksApi.GetWeblink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **link** | **string**| The unique identifier of Weblink | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxWeblink**](PbxWeblink.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listweblink"></a>
# **ListWeblink**
> PbxWeblinkCollectionResponse ListWeblink (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from WebsiteLinks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListWeblinkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteLinksApi();
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
                // Get entities from WebsiteLinks
                PbxWeblinkCollectionResponse result = apiInstance.ListWeblink(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteLinksApi.ListWeblink: " + e.Message );
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

[**PbxWeblinkCollectionResponse**](PbxWeblinkCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateweblink"></a>
# **UpdateWeblink**
> void UpdateWeblink (PbxWeblink body, string link)

Update entity in WebsiteLinks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateWeblinkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteLinksApi();
            var body = new PbxWeblink(); // PbxWeblink | New property values
            var link = link_example;  // string | The unique identifier of Weblink

            try
            {
                // Update entity in WebsiteLinks
                apiInstance.UpdateWeblink(body, link);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteLinksApi.UpdateWeblink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxWeblink**](PbxWeblink.md)| New property values | 
 **link** | **string**| The unique identifier of Weblink | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatelink"></a>
# **ValidateLink**
> void ValidateLink (WebsiteLinksValidateLinkRequestBody body)

Invoke action ValidateLink

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ValidateLinkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WebsiteLinksApi();
            var body = new WebsiteLinksValidateLinkRequestBody(); // WebsiteLinksValidateLinkRequestBody | Action parameters

            try
            {
                // Invoke action ValidateLink
                apiInstance.ValidateLink(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebsiteLinksApi.ValidateLink: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WebsiteLinksValidateLinkRequestBody**](WebsiteLinksValidateLinkRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

