# IO.Swagger.Api.TrunksApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTrunk**](TrunksApi.md#createtrunk) | **POST** /Trunks | Add new entity to Trunks
[**DeleteTrunk**](TrunksApi.md#deletetrunk) | **DELETE** /Trunks({Id}) | Delete entity from Trunks
[**GetTrunk**](TrunksApi.md#gettrunk) | **GET** /Trunks({Id}) | Get entity from Trunks by key
[**GetTrunkByNumber**](TrunksApi.md#gettrunkbynumber) | **GET** /Trunks/Pbx.GetTrunkByNumber(number&#x3D;{number}) | Invoke function GetTrunkByNumber
[**InitMasterBridge**](TrunksApi.md#initmasterbridge) | **GET** /Trunks/Pbx.InitMasterBridge() | Invoke function InitMasterBridge
[**InitSlaveBridge**](TrunksApi.md#initslavebridge) | **GET** /Trunks/Pbx.InitSlaveBridge() | Invoke function InitSlaveBridge
[**InitTrunk**](TrunksApi.md#inittrunk) | **GET** /Trunks/Pbx.InitTrunk(template&#x3D;{template}) | Invoke function InitTrunk
[**ListTrunk**](TrunksApi.md#listtrunk) | **GET** /Trunks | Get entities from Trunks
[**SetRoutes**](TrunksApi.md#setroutes) | **POST** /Trunks/Pbx.SetRoutes | Invoke action SetRoutes
[**TelegramSession**](TrunksApi.md#telegramsession) | **POST** /Trunks/Pbx.TelegramSession | Invoke action TelegramSession
[**UpdateTrunk**](TrunksApi.md#updatetrunk) | **PATCH** /Trunks({Id}) | Update entity in Trunks

<a name="createtrunk"></a>
# **CreateTrunk**
> PbxTrunk CreateTrunk (PbxTrunk body)

Add new entity to Trunks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateTrunkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var body = new PbxTrunk(); // PbxTrunk | New entity

            try
            {
                // Add new entity to Trunks
                PbxTrunk result = apiInstance.CreateTrunk(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.CreateTrunk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxTrunk**](PbxTrunk.md)| New entity | 

### Return type

[**PbxTrunk**](PbxTrunk.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetrunk"></a>
# **DeleteTrunk**
> void DeleteTrunk (int? id, string ifMatch)

Delete entity from Trunks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTrunkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var id = 56;  // int? | The unique identifier of Trunk
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from Trunks
                apiInstance.DeleteTrunk(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.DeleteTrunk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Trunk | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrunk"></a>
# **GetTrunk**
> PbxTrunk GetTrunk (int? id, List<string> select, string expand)

Get entity from Trunks by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTrunkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var id = 56;  // int? | The unique identifier of Trunk
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from Trunks by key
                PbxTrunk result = apiInstance.GetTrunk(id, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.GetTrunk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Trunk | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxTrunk**](PbxTrunk.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettrunkbynumber"></a>
# **GetTrunkByNumber**
> PbxTrunk GetTrunkByNumber (string number)

Invoke function GetTrunkByNumber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTrunkByNumberExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var number = number_example;  // string | Usage: number={number}

            try
            {
                // Invoke function GetTrunkByNumber
                PbxTrunk result = apiInstance.GetTrunkByNumber(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.GetTrunkByNumber: " + e.Message );
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

[**PbxTrunk**](PbxTrunk.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initmasterbridge"></a>
# **InitMasterBridge**
> PbxTrunk InitMasterBridge ()

Invoke function InitMasterBridge

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitMasterBridgeExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();

            try
            {
                // Invoke function InitMasterBridge
                PbxTrunk result = apiInstance.InitMasterBridge();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.InitMasterBridge: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxTrunk**](PbxTrunk.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initslavebridge"></a>
# **InitSlaveBridge**
> PbxTrunk InitSlaveBridge ()

Invoke function InitSlaveBridge

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitSlaveBridgeExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();

            try
            {
                // Invoke function InitSlaveBridge
                PbxTrunk result = apiInstance.InitSlaveBridge();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.InitSlaveBridge: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxTrunk**](PbxTrunk.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inittrunk"></a>
# **InitTrunk**
> PbxTrunk InitTrunk (string template)

Invoke function InitTrunk

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitTrunkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var template = template_example;  // string | Usage: template={template}

            try
            {
                // Invoke function InitTrunk
                PbxTrunk result = apiInstance.InitTrunk(template);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.InitTrunk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | **string**| Usage: template&#x3D;{template} | 

### Return type

[**PbxTrunk**](PbxTrunk.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtrunk"></a>
# **ListTrunk**
> PbxTrunkCollectionResponse ListTrunk (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from Trunks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListTrunkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
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
                // Get entities from Trunks
                PbxTrunkCollectionResponse result = apiInstance.ListTrunk(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.ListTrunk: " + e.Message );
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

[**PbxTrunkCollectionResponse**](PbxTrunkCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setroutes"></a>
# **SetRoutes**
> void SetRoutes (TrunksSetRoutesRequestBody body)

Invoke action SetRoutes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SetRoutesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var body = new TrunksSetRoutesRequestBody(); // TrunksSetRoutesRequestBody | Action parameters

            try
            {
                // Invoke action SetRoutes
                apiInstance.SetRoutes(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.SetRoutes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrunksSetRoutesRequestBody**](TrunksSetRoutesRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="telegramsession"></a>
# **TelegramSession**
> PbxXTelegramAuth TelegramSession (TrunksTelegramSessionRequestBody body)

Invoke action TelegramSession

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TelegramSessionExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var body = new TrunksTelegramSessionRequestBody(); // TrunksTelegramSessionRequestBody | Action parameters

            try
            {
                // Invoke action TelegramSession
                PbxXTelegramAuth result = apiInstance.TelegramSession(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.TelegramSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TrunksTelegramSessionRequestBody**](TrunksTelegramSessionRequestBody.md)| Action parameters | 

### Return type

[**PbxXTelegramAuth**](PbxXTelegramAuth.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetrunk"></a>
# **UpdateTrunk**
> void UpdateTrunk (PbxTrunk body, int? id)

Update entity in Trunks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateTrunkExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TrunksApi();
            var body = new PbxTrunk(); // PbxTrunk | New property values
            var id = 56;  // int? | The unique identifier of Trunk

            try
            {
                // Update entity in Trunks
                apiInstance.UpdateTrunk(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrunksApi.UpdateTrunk: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxTrunk**](PbxTrunk.md)| New property values | 
 **id** | **int?**| The unique identifier of Trunk | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

