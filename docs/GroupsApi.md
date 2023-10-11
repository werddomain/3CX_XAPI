# IO.Swagger.Api.GroupsApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateGroup**](GroupsApi.md#creategroup) | **POST** /Groups | Add new entity to Groups
[**DeleteCompanyById**](GroupsApi.md#deletecompanybyid) | **POST** /Groups/Pbx.DeleteCompanyById | Invoke action DeleteCompanyById
[**DeleteCompanyByNumber**](GroupsApi.md#deletecompanybynumber) | **POST** /Groups/Pbx.DeleteCompanyByNumber | Invoke action DeleteCompanyByNumber
[**DeleteGroup**](GroupsApi.md#deletegroup) | **DELETE** /Groups({Id}) | Delete entity from Groups
[**GetGroup**](GroupsApi.md#getgroup) | **GET** /Groups({Id}) | Get entity from Groups by key
[**GetRestrictions**](GroupsApi.md#getrestrictions) | **GET** /Groups({Id})/Pbx.GetRestrictions() | Invoke function GetRestrictions
[**LinkGroupPartner**](GroupsApi.md#linkgrouppartner) | **POST** /Groups/Pbx.LinkGroupPartner | Invoke action LinkGroupPartner
[**ListGroup**](GroupsApi.md#listgroup) | **GET** /Groups | Get entities from Groups
[**ListMembers**](GroupsApi.md#listmembers) | **GET** /Groups({Id})/Members | Get Members from Groups
[**ListRights**](GroupsApi.md#listrights) | **GET** /Groups({Id})/Rights | Get Rights from Groups
[**ReplaceGroupLicenseKey**](GroupsApi.md#replacegrouplicensekey) | **POST** /Groups/Pbx.ReplaceGroupLicenseKey | Invoke action ReplaceGroupLicenseKey
[**UnlinkGroupPartner**](GroupsApi.md#unlinkgrouppartner) | **POST** /Groups/Pbx.UnlinkGroupPartner | Invoke action UnlinkGroupPartner
[**UpdateGroup**](GroupsApi.md#updategroup) | **PATCH** /Groups({Id}) | Update entity in Groups

<a name="creategroup"></a>
# **CreateGroup**
> PbxGroup CreateGroup (PbxGroup body)

Add new entity to Groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var body = new PbxGroup(); // PbxGroup | New entity

            try
            {
                // Add new entity to Groups
                PbxGroup result = apiInstance.CreateGroup(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.CreateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxGroup**](PbxGroup.md)| New entity | 

### Return type

[**PbxGroup**](PbxGroup.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecompanybyid"></a>
# **DeleteCompanyById**
> void DeleteCompanyById (GroupsDeleteCompanyByIdRequestBody body)

Invoke action DeleteCompanyById

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCompanyByIdExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var body = new GroupsDeleteCompanyByIdRequestBody(); // GroupsDeleteCompanyByIdRequestBody | Action parameters

            try
            {
                // Invoke action DeleteCompanyById
                apiInstance.DeleteCompanyById(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteCompanyById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupsDeleteCompanyByIdRequestBody**](GroupsDeleteCompanyByIdRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecompanybynumber"></a>
# **DeleteCompanyByNumber**
> void DeleteCompanyByNumber (GroupsDeleteCompanyByNumberRequestBody body)

Invoke action DeleteCompanyByNumber

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCompanyByNumberExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var body = new GroupsDeleteCompanyByNumberRequestBody(); // GroupsDeleteCompanyByNumberRequestBody | Action parameters

            try
            {
                // Invoke action DeleteCompanyByNumber
                apiInstance.DeleteCompanyByNumber(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteCompanyByNumber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupsDeleteCompanyByNumberRequestBody**](GroupsDeleteCompanyByNumberRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegroup"></a>
# **DeleteGroup**
> void DeleteGroup (int? id, string ifMatch)

Delete entity from Groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var id = 56;  // int? | The unique identifier of Group
            var ifMatch = ifMatch_example;  // string | ETag (optional) 

            try
            {
                // Delete entity from Groups
                apiInstance.DeleteGroup(id, ifMatch);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.DeleteGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Group | 
 **ifMatch** | **string**| ETag | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgroup"></a>
# **GetGroup**
> PbxGroup GetGroup (int? id, List<string> select, string expand)

Get entity from Groups by key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var id = 56;  // int? | The unique identifier of Group
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get entity from Groups by key
                PbxGroup result = apiInstance.GetGroup(id, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Group | 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxGroup**](PbxGroup.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrestrictions"></a>
# **GetRestrictions**
> PbxRestrictions GetRestrictions (int? id)

Invoke function GetRestrictions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRestrictionsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var id = 56;  // int? | The unique identifier of Group

            try
            {
                // Invoke function GetRestrictions
                PbxRestrictions result = apiInstance.GetRestrictions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.GetRestrictions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Group | 

### Return type

[**PbxRestrictions**](PbxRestrictions.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkgrouppartner"></a>
# **LinkGroupPartner**
> void LinkGroupPartner (GroupsLinkGroupPartnerRequestBody body)

Invoke action LinkGroupPartner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LinkGroupPartnerExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var body = new GroupsLinkGroupPartnerRequestBody(); // GroupsLinkGroupPartnerRequestBody | Action parameters

            try
            {
                // Invoke action LinkGroupPartner
                apiInstance.LinkGroupPartner(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.LinkGroupPartner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupsLinkGroupPartnerRequestBody**](GroupsLinkGroupPartnerRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgroup"></a>
# **ListGroup**
> PbxGroupCollectionResponse ListGroup (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get entities from Groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
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
                // Get entities from Groups
                PbxGroupCollectionResponse result = apiInstance.ListGroup(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.ListGroup: " + e.Message );
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

[**PbxGroupCollectionResponse**](PbxGroupCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmembers"></a>
# **ListMembers**
> PbxUserGroupCollectionResponse ListMembers (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get Members from Groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMembersExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var id = 56;  // int? | The unique identifier of Group
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
                // Get Members from Groups
                PbxUserGroupCollectionResponse result = apiInstance.ListMembers(id, top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.ListMembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Group | 
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

<a name="listrights"></a>
# **ListRights**
> PbxRightsCollectionResponse ListRights (int? id, int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get Rights from Groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListRightsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var id = 56;  // int? | The unique identifier of Group
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
                // Get Rights from Groups
                PbxRightsCollectionResponse result = apiInstance.ListRights(id, top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.ListRights: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The unique identifier of Group | 
 **top** | **int?**| Show only the first n items | [optional] 
 **skip** | **int?**| Skip the first n items | [optional] 
 **search** | **string**| Search items by search phrases | [optional] 
 **filter** | **string**| Filter items by property values | [optional] 
 **count** | **bool?**| Include count of items | [optional] 
 **orderby** | [**List<string>**](string.md)| Order items by property values | [optional] 
 **select** | [**List<string>**](string.md)| Select properties to be returned | [optional] 
 **expand** | **string**| Expand related entities | [optional] 

### Return type

[**PbxRightsCollectionResponse**](PbxRightsCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacegrouplicensekey"></a>
# **ReplaceGroupLicenseKey**
> void ReplaceGroupLicenseKey (GroupsReplaceGroupLicenseKeyRequestBody body)

Invoke action ReplaceGroupLicenseKey

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceGroupLicenseKeyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var body = new GroupsReplaceGroupLicenseKeyRequestBody(); // GroupsReplaceGroupLicenseKeyRequestBody | Action parameters

            try
            {
                // Invoke action ReplaceGroupLicenseKey
                apiInstance.ReplaceGroupLicenseKey(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.ReplaceGroupLicenseKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GroupsReplaceGroupLicenseKeyRequestBody**](GroupsReplaceGroupLicenseKeyRequestBody.md)| Action parameters | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlinkgrouppartner"></a>
# **UnlinkGroupPartner**
> void UnlinkGroupPartner ()

Invoke action UnlinkGroupPartner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnlinkGroupPartnerExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();

            try
            {
                // Invoke action UnlinkGroupPartner
                apiInstance.UnlinkGroupPartner();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UnlinkGroupPartner: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategroup"></a>
# **UpdateGroup**
> void UpdateGroup (PbxGroup body, int? id)

Update entity in Groups

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupsApi();
            var body = new PbxGroup(); // PbxGroup | New property values
            var id = 56;  // int? | The unique identifier of Group

            try
            {
                // Update entity in Groups
                apiInstance.UpdateGroup(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling GroupsApi.UpdateGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxGroup**](PbxGroup.md)| New property values | 
 **id** | **int?**| The unique identifier of Group | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

