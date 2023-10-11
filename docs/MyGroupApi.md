# IO.Swagger.Api.MyGroupApi

All URIs are relative to */xapi/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMyGroup**](MyGroupApi.md#getmygroup) | **GET** /MyGroup | Get MyGroup
[**GetMyGroupPartnerInfo**](MyGroupApi.md#getmygrouppartnerinfo) | **GET** /MyGroup/Pbx.GetMyGroupPartnerInfo(resellerId&#x3D;{resellerId}) | Invoke function GetMyGroupPartnerInfo
[**GetMyGroupRestrictions**](MyGroupApi.md#getmygrouprestrictions) | **GET** /MyGroup/Pbx.GetRestrictions() | Invoke function GetRestrictions
[**LinkMyGroupPartner**](MyGroupApi.md#linkmygrouppartner) | **POST** /MyGroup/Pbx.LinkMyGroupPartner | Invoke action LinkMyGroupPartner
[**ListMyGroupMembers**](MyGroupApi.md#listmygroupmembers) | **GET** /MyGroup/Members | Get Members from MyGroup
[**ListMyGroupRights**](MyGroupApi.md#listmygrouprights) | **GET** /MyGroup/Rights | Get Rights from MyGroup
[**ReplaceMyGroupLicenseKey**](MyGroupApi.md#replacemygrouplicensekey) | **POST** /MyGroup/Pbx.ReplaceMyGroupLicenseKey | Invoke action ReplaceMyGroupLicenseKey
[**UnlinkMyGroupPartner**](MyGroupApi.md#unlinkmygrouppartner) | **POST** /MyGroup/Pbx.UnlinkMyGroupPartner | Invoke action UnlinkMyGroupPartner
[**UpdateMyGroup**](MyGroupApi.md#updatemygroup) | **PATCH** /MyGroup | Update MyGroup

<a name="getmygroup"></a>
# **GetMyGroup**
> PbxGroup GetMyGroup (List<string> select, string expand)

Get MyGroup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMyGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();
            var select = new List<string>(); // List<string> | Select properties to be returned (optional) 
            var expand = expand_example;  // string | Expand related entities (optional) 

            try
            {
                // Get MyGroup
                PbxGroup result = apiInstance.GetMyGroup(select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.GetMyGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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

<a name="getmygrouppartnerinfo"></a>
# **GetMyGroupPartnerInfo**
> PbxResellerInfo GetMyGroupPartnerInfo (string resellerId)

Invoke function GetMyGroupPartnerInfo

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetMyGroupPartnerInfoExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();
            var resellerId = resellerId_example;  // string | Usage: resellerId={resellerId}

            try
            {
                // Invoke function GetMyGroupPartnerInfo
                PbxResellerInfo result = apiInstance.GetMyGroupPartnerInfo(resellerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.GetMyGroupPartnerInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resellerId** | **string**| Usage: resellerId&#x3D;{resellerId} | 

### Return type

[**PbxResellerInfo**](PbxResellerInfo.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmygrouprestrictions"></a>
# **GetMyGroupRestrictions**
> PbxRestrictions GetMyGroupRestrictions ()

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
    public class GetMyGroupRestrictionsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();

            try
            {
                // Invoke function GetRestrictions
                PbxRestrictions result = apiInstance.GetMyGroupRestrictions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.GetMyGroupRestrictions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PbxRestrictions**](PbxRestrictions.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="linkmygrouppartner"></a>
# **LinkMyGroupPartner**
> void LinkMyGroupPartner (LinkMyGroupPartnerRequestBody body)

Invoke action LinkMyGroupPartner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LinkMyGroupPartnerExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();
            var body = new LinkMyGroupPartnerRequestBody(); // LinkMyGroupPartnerRequestBody |  (optional) 

            try
            {
                // Invoke action LinkMyGroupPartner
                apiInstance.LinkMyGroupPartner(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.LinkMyGroupPartner: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LinkMyGroupPartnerRequestBody**](LinkMyGroupPartnerRequestBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmygroupmembers"></a>
# **ListMyGroupMembers**
> PbxUserGroupCollectionResponse ListMyGroupMembers (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get Members from MyGroup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMyGroupMembersExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();
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
                // Get Members from MyGroup
                PbxUserGroupCollectionResponse result = apiInstance.ListMyGroupMembers(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.ListMyGroupMembers: " + e.Message );
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

[**PbxUserGroupCollectionResponse**](PbxUserGroupCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmygrouprights"></a>
# **ListMyGroupRights**
> PbxRightsCollectionResponse ListMyGroupRights (int? top, int? skip, string search, string filter, bool? count, List<string> orderby, List<string> select, string expand)

Get Rights from MyGroup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ListMyGroupRightsExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();
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
                // Get Rights from MyGroup
                PbxRightsCollectionResponse result = apiInstance.ListMyGroupRights(top, skip, search, filter, count, orderby, select, expand);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.ListMyGroupRights: " + e.Message );
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

[**PbxRightsCollectionResponse**](PbxRightsCollectionResponse.md)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacemygrouplicensekey"></a>
# **ReplaceMyGroupLicenseKey**
> void ReplaceMyGroupLicenseKey (ReplaceMyGroupLicenseKeyRequestBody body)

Invoke action ReplaceMyGroupLicenseKey

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ReplaceMyGroupLicenseKeyExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();
            var body = new ReplaceMyGroupLicenseKeyRequestBody(); // ReplaceMyGroupLicenseKeyRequestBody |  (optional) 

            try
            {
                // Invoke action ReplaceMyGroupLicenseKey
                apiInstance.ReplaceMyGroupLicenseKey(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.ReplaceMyGroupLicenseKey: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReplaceMyGroupLicenseKeyRequestBody**](ReplaceMyGroupLicenseKeyRequestBody.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unlinkmygrouppartner"></a>
# **UnlinkMyGroupPartner**
> void UnlinkMyGroupPartner ()

Invoke action UnlinkMyGroupPartner

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnlinkMyGroupPartnerExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();

            try
            {
                // Invoke action UnlinkMyGroupPartner
                apiInstance.UnlinkMyGroupPartner();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.UnlinkMyGroupPartner: " + e.Message );
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

<a name="updatemygroup"></a>
# **UpdateMyGroup**
> void UpdateMyGroup (PbxGroup body)

Update MyGroup

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateMyGroupExample
    {
        public void main()
        {

            // Configure OAuth2 access token for authorization: Application
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyGroupApi();
            var body = new PbxGroup(); // PbxGroup | New property values

            try
            {
                // Update MyGroup
                apiInstance.UpdateMyGroup(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyGroupApi.UpdateMyGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PbxGroup**](PbxGroup.md)| New property values | 

### Return type

void (empty response body)

### Authorization

[Application](../README.md#Application)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

