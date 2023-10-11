# IO.Swagger.Api.PhoneTemplatesApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPhoneTemplate**](PhoneTemplatesApi.md#getphonetemplate) | **GET** /PhoneTemplates({Id}) | Get entity from PhoneTemplates by key
[**ListPhoneTemplate**](PhoneTemplatesApi.md#listphonetemplate) | **GET** /PhoneTemplates | Get entities from PhoneTemplates

<a name="getphonetemplate"></a>
# **GetPhoneTemplate**
> PbxPhoneTemplate GetPhoneTemplate (string id, List<string> select, string expand)

Get entity from PhoneTemplates by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPhoneTemplateExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneTemplatesApi();
            var id = id_example;  // string | The unique identifier of PhoneTemplate
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from PhoneTemplates by key
                PbxPhoneTemplate result = apiInstance.GetPhoneTemplate(id, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneTemplatesApi.GetPhoneTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The unique identifier of PhoneTemplate | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxPhoneTemplate**](PbxPhoneTemplate.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listphonetemplate"></a>
# **ListPhoneTemplate**
> PbxPhoneTemplateCollectionResponse ListPhoneTemplate (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from PhoneTemplates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListPhoneTemplateExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PhoneTemplatesApi();
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
                // Get entities from PhoneTemplates
                PbxPhoneTemplateCollectionResponse result = apiInstance.ListPhoneTemplate(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PhoneTemplatesApi.ListPhoneTemplate: " + e.Message );
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

[**PbxPhoneTemplateCollectionResponse**](PbxPhoneTemplateCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

