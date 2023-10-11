# IO.Swagger.Api.ContactsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateContact**](ContactsApi.md#createcontact) | **POST** /Contacts | Add new entity to Contacts
[**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /Contacts({Id}) | Delete entity from Contacts
[**GetContact**](ContactsApi.md#getcontact) | **GET** /Contacts({Id}) | Get entity from Contacts by key
[**ListContact**](ContactsApi.md#listcontact) | **GET** /Contacts | Get entities from Contacts
[**UpdateContact**](ContactsApi.md#updatecontact) | **PATCH** /Contacts({Id}) | Update entity in Contacts

<a name="createcontact"></a>
# **CreateContact**
> PbxContact CreateContact (PbxContact body)

Add new entity to Contacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new PbxContact(); // PbxContact | New entity

            try
            {
                // Add new entity to Contacts
                PbxContact result = apiInstance.CreateContact(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.CreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxContact**](PbxContact.md)| New entity | 

### Return type

[**PbxContact**](PbxContact.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (int? id, string ifMatch)

Delete entity from Contacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var id = 56;  // int? | The unique identifier of Contact
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from Contacts
                apiInstance.DeleteContact(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.DeleteContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Contact | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontact"></a>
# **GetContact**
> PbxContact GetContact (int? id, List<string> select, string expand)

Get entity from Contacts by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var id = 56;  // int? | The unique identifier of Contact
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from Contacts by key
                PbxContact result = apiInstance.GetContact(id, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.GetContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Contact | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxContact**](PbxContact.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcontact"></a>
# **ListContact**
> PbxContactCollectionResponse ListContact (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from Contacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
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
                // Get entities from Contacts
                PbxContactCollectionResponse result = apiInstance.ListContact(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.ListContact: " + e.Message );
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

[**PbxContactCollectionResponse**](PbxContactCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecontact"></a>
# **UpdateContact**
> void UpdateContact (PbxContact body, int? id)

Update entity in Contacts

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateContactExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ContactsApi();
            var body = new PbxContact(); // PbxContact | New property values
            var id = 56;  // int? | The unique identifier of Contact

            try
            {
                // Update entity in Contacts
                apiInstance.UpdateContact(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ContactsApi.UpdateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxContact**](PbxContact.md)| New property values | 
 **id** | **int?**| The unique identifier of Contact | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

