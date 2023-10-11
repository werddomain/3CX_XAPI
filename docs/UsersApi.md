# IO.Swagger.Api.UsersApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateUser**](UsersApi.md#createuser) | **POST** /Users | Add new entity to Users
[**DeleteUser**](UsersApi.md#deleteuser) | **DELETE** /Users({Id}) | Delete entity from Users
[**GetPhoneRegistrar**](UsersApi.md#getphoneregistrar) | **GET** /Users({Id})/Pbx.GetPhoneRegistrar(mac&#x3D;{mac}) | Invoke function GetPhoneRegistrar
[**GetPhoneRegistrars**](UsersApi.md#getphoneregistrars) | **POST** /Users/Pbx.GetPhoneRegistrars | Invoke action GetPhoneRegistrars
[**GetPhoneSecret**](UsersApi.md#getphonesecret) | **GET** /Users({Id})/Pbx.GetPhoneSecret() | Invoke function GetPhoneSecret
[**GetUser**](UsersApi.md#getuser) | **GET** /Users({Id}) | Get entity from Users by key
[**GetUserByNumber**](UsersApi.md#getuserbynumber) | **GET** /Users/Pbx.GetByNumber(number&#x3D;{number}) | Invoke function GetByNumber
[**ListForwardingProfiles**](UsersApi.md#listforwardingprofiles) | **GET** /Users({Id})/ForwardingProfiles | Get ForwardingProfiles from Users
[**ListGroups**](UsersApi.md#listgroups) | **GET** /Users({Id})/Groups | Get Groups from Users
[**ListUser**](UsersApi.md#listuser) | **GET** /Users | Get entities from Users
[**RebootPhone**](UsersApi.md#rebootphone) | **POST** /Users({Id})/Pbx.RebootPhone | Invoke action RebootPhone
[**Regenerate**](UsersApi.md#regenerate) | **POST** /Users({Id})/Pbx.Regenerate | Invoke action Regenerate
[**RegenerateAll**](UsersApi.md#regenerateall) | **POST** /Users/Pbx.RegenerateAll | Invoke action RegenerateAll
[**RegisterInRps**](UsersApi.md#registerinrps) | **POST** /Users({Id})/Pbx.RegisterInRps | Invoke action RegisterInRps
[**ReprovisionPhone**](UsersApi.md#reprovisionphone) | **POST** /Users({Id})/Pbx.ReprovisionPhone | Invoke action ReprovisionPhone
[**SendWelcomeEmail**](UsersApi.md#sendwelcomeemail) | **POST** /Users({Id})/Pbx.SendWelcomeEmail | Invoke action SendWelcomeEmail
[**UpdateUser**](UsersApi.md#updateuser) | **PATCH** /Users({Id}) | Update entity in Users
[**UpgradePhone**](UsersApi.md#upgradephone) | **POST** /Users({Id})/Pbx.UpgradePhone | Invoke action UpgradePhone

<a name="createuser"></a>
# **CreateUser**
> PbxUser CreateUser (PbxUser body)

Add new entity to Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateUserExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new PbxUser(); // PbxUser | New entity

            try
            {
                // Add new entity to Users
                PbxUser result = apiInstance.CreateUser(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.CreateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxUser**](PbxUser.md)| New entity | 

### Return type

[**PbxUser**](PbxUser.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteuser"></a>
# **DeleteUser**
> void DeleteUser (int? id, string ifMatch)

Delete entity from Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteUserExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from Users
                apiInstance.DeleteUser(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphoneregistrar"></a>
# **GetPhoneRegistrar**
> PbxPhoneRegistrar GetPhoneRegistrar (int? id, string mac)

Invoke function GetPhoneRegistrar

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPhoneRegistrarExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var mac = mac_example;  // string | Usage: mac={mac}

            try
            {
                // Invoke function GetPhoneRegistrar
                PbxPhoneRegistrar result = apiInstance.GetPhoneRegistrar(id, mac);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetPhoneRegistrar: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **mac** | **string**| Usage: mac&#x3D;{mac} | 

### Return type

[**PbxPhoneRegistrar**](PbxPhoneRegistrar.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphoneregistrars"></a>
# **GetPhoneRegistrars**
> InlineResponse2003 GetPhoneRegistrars (UsersGetPhoneRegistrarsRequestBody body)

Invoke action GetPhoneRegistrars

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPhoneRegistrarsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UsersGetPhoneRegistrarsRequestBody(); // UsersGetPhoneRegistrarsRequestBody | Action parameters

            try
            {
                // Invoke action GetPhoneRegistrars
                InlineResponse2003 result = apiInstance.GetPhoneRegistrars(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetPhoneRegistrars: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersGetPhoneRegistrarsRequestBody**](UsersGetPhoneRegistrarsRequestBody.md)| Action parameters | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphonesecret"></a>
# **GetPhoneSecret**
> InlineResponse2002 GetPhoneSecret (int? id)

Invoke function GetPhoneSecret

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPhoneSecretExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User

            try
            {
                // Invoke function GetPhoneSecret
                InlineResponse2002 result = apiInstance.GetPhoneSecret(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetPhoneSecret: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuser"></a>
# **GetUser**
> PbxUser GetUser (int? id, List<string> select, string expand)

Get entity from Users by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetUserExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from Users by key
                PbxUser result = apiInstance.GetUser(id, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxUser**](PbxUser.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getuserbynumber"></a>
# **GetUserByNumber**
> PbxUser GetUserByNumber (string number)

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
    public class GetUserByNumberExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var number = number_example;  // string | Usage: number={number}

            try
            {
                // Invoke function GetByNumber
                PbxUser result = apiInstance.GetUserByNumber(number);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserByNumber: " + e.Message );
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

[**PbxUser**](PbxUser.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listforwardingprofiles"></a>
# **ListForwardingProfiles**
> PbxForwardingProfileCollectionResponse ListForwardingProfiles (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get ForwardingProfiles from Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListForwardingProfilesExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
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
                // Get ForwardingProfiles from Users
                PbxForwardingProfileCollectionResponse result = apiInstance.ListForwardingProfiles(id, top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListForwardingProfiles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxForwardingProfileCollectionResponse**](PbxForwardingProfileCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgroups"></a>
# **ListGroups**
> PbxUserGroupCollectionResponse ListGroups (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get Groups from Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListGroupsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
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
                // Get Groups from Users
                PbxUserGroupCollectionResponse result = apiInstance.ListGroups(id, top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListGroups: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxUserGroupCollectionResponse**](PbxUserGroupCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listuser"></a>
# **ListUser**
> PbxUserCollectionResponse ListUser (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListUserExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
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
                // Get entities from Users
                PbxUserCollectionResponse result = apiInstance.ListUser(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ListUser: " + e.Message );
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

[**PbxUserCollectionResponse**](PbxUserCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rebootphone"></a>
# **RebootPhone**
> void RebootPhone (int? id, RebootPhoneRequestBody body)

Invoke action RebootPhone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RebootPhoneExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var body = new RebootPhoneRequestBody(); // RebootPhoneRequestBody |  (optional) 

            try
            {
                // Invoke action RebootPhone
                apiInstance.RebootPhone(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RebootPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **body** | [**RebootPhoneRequestBody**](RebootPhoneRequestBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="regenerate"></a>
# **Regenerate**
> void Regenerate (int? id, RegenerateRequestBody body)

Invoke action Regenerate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegenerateExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var body = new RegenerateRequestBody(); // RegenerateRequestBody |  (optional) 

            try
            {
                // Invoke action Regenerate
                apiInstance.Regenerate(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.Regenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **body** | [**RegenerateRequestBody**](RegenerateRequestBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="regenerateall"></a>
# **RegenerateAll**
> void RegenerateAll (UsersRegenerateAllRequestBody body)

Invoke action RegenerateAll

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegenerateAllExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new UsersRegenerateAllRequestBody(); // UsersRegenerateAllRequestBody | Action parameters

            try
            {
                // Invoke action RegenerateAll
                apiInstance.RegenerateAll(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RegenerateAll: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersRegenerateAllRequestBody**](UsersRegenerateAllRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerinrps"></a>
# **RegisterInRps**
> void RegisterInRps (int? id, RegisterInRpsRequestBody body)

Invoke action RegisterInRps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegisterInRpsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var body = new RegisterInRpsRequestBody(); // RegisterInRpsRequestBody |  (optional) 

            try
            {
                // Invoke action RegisterInRps
                apiInstance.RegisterInRps(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.RegisterInRps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **body** | [**RegisterInRpsRequestBody**](RegisterInRpsRequestBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reprovisionphone"></a>
# **ReprovisionPhone**
> void ReprovisionPhone (int? id, ReprovisionPhoneRequestBody body)

Invoke action ReprovisionPhone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReprovisionPhoneExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var body = new ReprovisionPhoneRequestBody(); // ReprovisionPhoneRequestBody |  (optional) 

            try
            {
                // Invoke action ReprovisionPhone
                apiInstance.ReprovisionPhone(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.ReprovisionPhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **body** | [**ReprovisionPhoneRequestBody**](ReprovisionPhoneRequestBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendwelcomeemail"></a>
# **SendWelcomeEmail**
> void SendWelcomeEmail (int? id)

Invoke action SendWelcomeEmail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SendWelcomeEmailExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User

            try
            {
                // Invoke action SendWelcomeEmail
                apiInstance.SendWelcomeEmail(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SendWelcomeEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateuser"></a>
# **UpdateUser**
> void UpdateUser (PbxUser body, int? id)

Update entity in Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateUserExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var body = new PbxUser(); // PbxUser | New property values
            var id = 56;  // int? | The unique identifier of User

            try
            {
                // Update entity in Users
                apiInstance.UpdateUser(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxUser**](PbxUser.md)| New property values | 
 **id** | **int?**| The unique identifier of User | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upgradephone"></a>
# **UpgradePhone**
> void UpgradePhone (int? id, UpgradePhoneRequestBody body)

Invoke action UpgradePhone

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpgradePhoneExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi();
            var id = 56;  // int? | The unique identifier of User
            var body = new UpgradePhoneRequestBody(); // UpgradePhoneRequestBody |  (optional) 

            try
            {
                // Invoke action UpgradePhone
                apiInstance.UpgradePhone(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UpgradePhone: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of User | 
 **body** | [**UpgradePhoneRequestBody**](UpgradePhoneRequestBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

