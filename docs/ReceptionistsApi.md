# IO.Swagger.Api.ReceptionistsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReceptionist**](ReceptionistsApi.md#createreceptionist) | **POST** /Receptionists | Add new entity to Receptionists
[**DeleteReceptionist**](ReceptionistsApi.md#deletereceptionist) | **DELETE** /Receptionists({Id}) | Delete entity from Receptionists
[**GetReceptionist**](ReceptionistsApi.md#getreceptionist) | **GET** /Receptionists({Id}) | Get entity from Receptionists by key
[**GetReceptionistByNumber**](ReceptionistsApi.md#getreceptionistbynumber) | **GET** /Receptionists/Pbx.GetByNumber(number&#x3D;{number}) | Invoke function GetByNumber
[**ListForwards**](ReceptionistsApi.md#listforwards) | **GET** /Receptionists({Id})/Forwards | Get Forwards from Receptionists
[**ListReceptionist**](ReceptionistsApi.md#listreceptionist) | **GET** /Receptionists | Get entities from Receptionists
[**UpdateReceptionist**](ReceptionistsApi.md#updatereceptionist) | **PATCH** /Receptionists({Id}) | Update entity in Receptionists

<a name="createreceptionist"></a>
# **CreateReceptionist**
> PbxReceptionist CreateReceptionist (PbxReceptionist body)

Add new entity to Receptionists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateReceptionistExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceptionistsApi();
            var body = new PbxReceptionist(); // PbxReceptionist | New entity

            try
            {
                // Add new entity to Receptionists
                PbxReceptionist result = apiInstance.CreateReceptionist(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceptionistsApi.CreateReceptionist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxReceptionist**](PbxReceptionist.md)| New entity | 

### Return type

[**PbxReceptionist**](PbxReceptionist.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletereceptionist"></a>
# **DeleteReceptionist**
> void DeleteReceptionist (int? id, string ifMatch)

Delete entity from Receptionists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteReceptionistExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceptionistsApi();
            var id = 56;  // int? | The unique identifier of Receptionist
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from Receptionists
                apiInstance.DeleteReceptionist(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceptionistsApi.DeleteReceptionist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Receptionist | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceptionist"></a>
# **GetReceptionist**
> PbxReceptionist GetReceptionist (int? id, List<string> select, string expand)

Get entity from Receptionists by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReceptionistExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceptionistsApi();
            var id = 56;  // int? | The unique identifier of Receptionist
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from Receptionists by key
                PbxReceptionist result = apiInstance.GetReceptionist(id, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceptionistsApi.GetReceptionist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Receptionist | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxReceptionist**](PbxReceptionist.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceptionistbynumber"></a>
# **GetReceptionistByNumber**
> PbxReceptionist GetReceptionistByNumber (string number)

Invoke function GetByNumber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetReceptionistByNumberExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceptionistsApi();
            var number = number_example;  // string | Usage: number={number}

            try
            {
                // Invoke function GetByNumber
                PbxReceptionist result = apiInstance.GetReceptionistByNumber(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceptionistsApi.GetReceptionistByNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **number** | **string**| Usage: number&#x3D;{number} | 

### Return type

[**PbxReceptionist**](PbxReceptionist.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listforwards"></a>
# **ListForwards**
> PbxReceptionistForwardCollectionResponse ListForwards (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get Forwards from Receptionists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListForwardsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceptionistsApi();
            var id = 56;  // int? | The unique identifier of Receptionist
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
                // Get Forwards from Receptionists
                PbxReceptionistForwardCollectionResponse result = apiInstance.ListForwards(id, top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceptionistsApi.ListForwards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Receptionist | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxReceptionistForwardCollectionResponse**](PbxReceptionistForwardCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listreceptionist"></a>
# **ListReceptionist**
> PbxReceptionistCollectionResponse ListReceptionist (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from Receptionists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListReceptionistExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceptionistsApi();
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
                // Get entities from Receptionists
                PbxReceptionistCollectionResponse result = apiInstance.ListReceptionist(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceptionistsApi.ListReceptionist: " + e.Message );
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

[**PbxReceptionistCollectionResponse**](PbxReceptionistCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereceptionist"></a>
# **UpdateReceptionist**
> void UpdateReceptionist (PbxReceptionist body, int? id)

Update entity in Receptionists

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateReceptionistExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReceptionistsApi();
            var body = new PbxReceptionist(); // PbxReceptionist | New property values
            var id = 56;  // int? | The unique identifier of Receptionist

            try
            {
                // Update entity in Receptionists
                apiInstance.UpdateReceptionist(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReceptionistsApi.UpdateReceptionist: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxReceptionist**](PbxReceptionist.md)| New property values | 
 **id** | **int?**| The unique identifier of Receptionist | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

